import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';
import {AppConfigurator} from "@/layout/components/app.configurator";

@Component({
    selector: 'app-access',
    standalone: true,
    imports: [ButtonModule, RouterModule, RippleModule, ButtonModule, AppConfigurator],
    template: `
        <svg
            viewBox="0 0 960 540"
            xmlns="http://www.w3.org/2000/svg"
            xmlns:xlink="http://www.w3.org/1999/xlink"
            version="1.1"
            class="min-h-screen min-w-[100vw] fixed left-0"
            style="bottom:-10rem"
            preserveAspectRatio="none"
        >
            <rect
                x="0"
                y="0"
                width="960"
                height="540"
                fill="var(--surface-ground)"
            ></rect>
            <path
                d="M0 331L26.7 321C53.3 311 106.7 291 160 291C213.3 291 266.7 311 320 329.5C373.3 348 426.7 365 480 373.2C533.3 381.3 586.7 380.7 640 373.8C693.3 367 746.7 354 800 341.2C853.3 328.3 906.7 315.7 933.3 309.3L960 303L960 541L933.3 541C906.7 541 853.3 541 800 541C746.7 541 693.3 541 640 541C586.7 541 533.3 541 480 541C426.7 541 373.3 541 320 541C266.7 541 213.3 541 160 541C106.7 541 53.3 541 26.7 541L0 541Z"
                fill="var(--p-purple-500)"
                stroke-linecap="round"
                stroke-linejoin="miter"
            ></path>
        </svg>
        <div
            class="px-8 min-h-screen flex justify-center items-center -mt-20 sm:mt-0"
        >
            <div class="z-10 text-center">
                <div
                    class="text-surface-900 dark:text-surface-0 font-bold text-8xl mb-6"
                >
                    Access Denied
                </div>
                <p
                    class="leading-normal mt-0 mb-8 text-surface-700 dark:text-surface-100 text-xl font-medium"
                >
                    You don't have the permissions to access this page
                </p>
                <p-button [routerLink]="['/']" severity="help" raised
                    >Go to Dashboard</p-button
                >
            </div>
        </div>
        <app-configurator [simple]="true" />`,
})
export class Access {}
