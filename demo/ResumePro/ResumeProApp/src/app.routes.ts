import { Routes } from '@angular/router';
import { AppLayout } from './app/layout/components/app.layout';
// Temporarily comment out unused imports
// import { Landing } from '@/pages/landing/landing';
// import { Notfound } from '@/pages/notfound/notfound';

export const appRoutes: Routes = [
    {
        path: '',
        component: AppLayout,
        children: [
            {
                path: '',
                loadComponent: () => import('./app/dashboard/dashboard.component').then(c => c.DashboardComponent),
                data: { breadcrumb: 'Dashboard' },
            },
            {
                path: 'people',
                loadComponent: () => import('./app/people/people.component').then(c => c.PeopleComponent),
                data: { breadcrumb: 'People' },
            },
            // Only keep the essential routes for ResumePro
            // Additional routes can be added as needed
        ],
    },
    // Simplified routing for ResumePro
    { path: '**', redirectTo: '' },
];
