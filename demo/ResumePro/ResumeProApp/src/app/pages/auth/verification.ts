import { Component, computed, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { AppConfigurator } from '../../../layout/components/app.configurator';
import { FormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { LayoutService } from '../../../layout/service/layout.service';
import {RippleModule} from "primeng/ripple";
import {KeyFilterModule} from "primeng/keyfilter";
import {InputNumber, InputNumberModule} from "primeng/inputnumber";

@Component({
    selector: 'app-verification',
    imports: [
        ButtonModule,
        RouterModule,
        AppConfigurator,
        FormsModule,
        InputNumberModule,
        RippleModule,
    ],
    standalone: true,
    template: `<svg
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 1600 800"
            class="fixed left-0 top-0 min-h-screen min-w-[100vw]"
            preserveAspectRatio="none"
        >
            <rect
                [attr.fill]="
                    isDarkTheme()
                        ? 'var(--p-primary-900)'
                        : 'var(--p-primary-500)'
                "
                width="1600"
                height="800"
            />
            <path
                [attr.fill]="
                    isDarkTheme()
                        ? 'var(--p-primary-800)'
                        : 'var(--p-primary-400)'
                "
                d="M478.4 581c3.2 0.8 6.4 1.7 9.5 2.5c196.2 52.5 388.7 133.5 593.5 176.6c174.2 36.6 349.5 29.2 518.6-10.2V0H0v574.9c52.3-17.6 106.5-27.7 161.1-30.9C268.4 537.4 375.7 554.2 478.4 581z"
            />
            <path
                [attr.fill]="
                    isDarkTheme()
                        ? 'var(--p-primary-700)'
                        : 'var(--p-primary-300)'
                "
                d="M181.8 259.4c98.2 6 191.9 35.2 281.3 72.1c2.8 1.1 5.5 2.3 8.3 3.4c171 71.6 342.7 158.5 531.3 207.7c198.8 51.8 403.4 40.8 597.3-14.8V0H0v283.2C59 263.6 120.6 255.7 181.8 259.4z"
            />
            <path
                [attr.fill]="
                    isDarkTheme()
                        ? 'var(--p-primary-600)'
                        : 'var(--p-primary-200)'
                "
                d="M454.9 86.3C600.7 177 751.6 269.3 924.1 325c208.6 67.4 431.3 60.8 637.9-5.3c12.8-4.1 25.4-8.4 38.1-12.9V0H288.1c56 21.3 108.7 50.6 159.7 82C450.2 83.4 452.5 84.9 454.9 86.3z"
            />
            <path
                [attr.fill]="
                    isDarkTheme()
                        ? 'var(--p-primary-500)'
                        : 'var(--p-primary-100)'
                "
                d="M1397.5 154.8c47.2-10.6 93.6-25.3 138.6-43.8c21.7-8.9 43-18.8 63.9-29.5V0H643.4c62.9 41.7 129.7 78.2 202.1 107.4C1020.4 178.1 1214.2 196.1 1397.5 154.8z"
            />
        </svg>
        <div class="px-8 min-h-screen flex justify-center items-center">
            <div
                class="border border-surface-200 dark:border-surface-700 bg-surface-0 dark:bg-surface-900 rounded py-16 px-6 md:px-16 z-10"
            >
                <div class="mb-6">
                    <div
                        class="text-surface-900 dark:text-surface-0 text-xl font-bold mb-2"
                    >
                        Verification
                    </div>
                    <span
                        class="text-surface-600 dark:text-surface-200 font-medium"
                        >We have sent code to you email:</span
                    >
                    <div class="flex items-center mt-1">
                        <i
                            class="pi pi-envelope text-surface-600 dark:text-surface-200"
                        ></i>
                        <span
                            class="text-surface-900 dark:text-surface-0 font-bold ml-2"
                            >dm**&#64;gmail.com</span
                        >
                    </div>
                </div>
                <div class="flex flex-col">
                    <div
                        class="flex justify-between w-full items-center mb-6 gap-4"
                    >
                        <p-inputNumber inputStyleClass="text-center w-12" [maxlength]="1" (onInput)="focusOnNext(input2)"></p-inputNumber>
                        <p-inputNumber #input2 inputStyleClass="text-center w-12" [maxlength]="1" (onInput)="focusOnNext(input3)"></p-inputNumber>
                        <p-inputNumber #input3 inputStyleClass="text-center w-12" [maxlength]="1" (onInput)="focusOnNext(input4)"></p-inputNumber>
                        <p-inputNumber #input4 inputStyleClass="text-center w-12" [maxlength]="1"></p-inputNumber>
                    </div>

                    <div class="flex flex-wrap gap-2 justify-between">
                        <button
                            pButton
                            pRipple
                            label="Cancel"
                            class="flex-auto"
                            outlined
                            [routerLink]="['/']"
                        ></button>
                        <button
                            pButton
                            pRipple
                            label="Verify"
                            class="flex-auto"
                            [routerLink]="['/']"
                        ></button>
                    </div>
                </div>
            </div>
        </div>

          <app-configurator [simple]="true"/>`,
})
export class Verification {
    layoutService = inject(LayoutService);

    isDarkTheme = computed(() => this.layoutService.isDarkTheme());

    focusOnNext(inputEl: InputNumber) {
        inputEl.input.nativeElement.focus();
    }

}
