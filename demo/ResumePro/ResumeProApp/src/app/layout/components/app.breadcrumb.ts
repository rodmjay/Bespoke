import { Component, Injector } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
    ActivatedRouteSnapshot,
    NavigationEnd,
    Router,
    RouterModule,
} from '@angular/router';

import { BehaviorSubject, filter } from 'rxjs';
import { BreadcrumbModule } from 'primeng/breadcrumb';
import { PeopleService } from '../../core/services/people.service';

interface Breadcrumb {
    label: string;
    url?: string;
}

@Component({
    selector: '[app-breadcrumb]',
    standalone: true,
    imports: [CommonModule, RouterModule, BreadcrumbModule],
    template: `<nav class="layout-breadcrumb">
        <p-breadcrumb 
            [model]="(breadcrumbItems$ | async) || []" 
            [home]="breadcrumbHome"
            styleClass="border-none surface-ground"
        ></p-breadcrumb>
    </nav> `,
})
export class AppBreadcrumb {
    private readonly _breadcrumbs$ = new BehaviorSubject<any[]>([]);

    readonly breadcrumbItems$ = this._breadcrumbs$.asObservable();
    
    breadcrumbHome = { icon: 'pi pi-home', routerLink: '/' };

    constructor(private router: Router, private injector: Injector) {
        this.router.events
            .pipe(filter((event) => event instanceof NavigationEnd))
            .subscribe((event) => {
                const root = this.router.routerState.snapshot.root;
                const breadcrumbs: any[] = [];
                this.addBreadcrumb(root, [], breadcrumbs);

                this._breadcrumbs$.next(breadcrumbs);
            });
    }

    private addBreadcrumb(
        route: ActivatedRouteSnapshot,
        parentUrl: string[],
        breadcrumbs: any[],
    ) {
        const routeUrl = parentUrl.concat(route.url.map((url) => url.path));
        let breadcrumb = route.data['breadcrumb'];
        const parentBreadcrumb =
            route.parent && route.parent.data
                ? route.parent.data['breadcrumb']
                : null;

        // Handle dynamic breadcrumb labels for routes with parameters
        if (breadcrumb && route.params) {
            // Replace parameter placeholders with actual values
            if (route.params['personId'] && route.routeConfig?.path?.includes(':personId')) {
                const personService = this.injector.get(PeopleService);
                personService.getPerson(route.params['personId']).subscribe(person => {
                    if (person) {
                        const personName = `${person.firstName} ${person.lastName}`;
                        const updatedBreadcrumbs = breadcrumbs.map(item => {
                            if (item.label === breadcrumb) {
                                return { ...item, label: `${breadcrumb}: ${personName}` };
                            }
                            return item;
                        });
                        this._breadcrumbs$.next(updatedBreadcrumbs);
                    }
                });
            }
        }

        if (breadcrumb && breadcrumb !== parentBreadcrumb) {
            breadcrumbs.push({
                label: breadcrumb,
                routerLink: '/' + routeUrl.join('/'),
            });
        }

        if (route.firstChild) {
            this.addBreadcrumb(route.firstChild, routeUrl, breadcrumbs);
        }
    }
}
