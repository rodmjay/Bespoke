import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { TestRunnerComponent } from './test-runner.component';
import { TestResultComponent } from './test-result.component';
import { ButtonModule } from 'primeng/button';
import { CardModule } from 'primeng/card';
import { ProgressBarModule } from 'primeng/progressbar';
import { TreeModule } from 'primeng/tree';

@NgModule({
  declarations: [
    TestRunnerComponent,
    TestResultComponent
  ],
  imports: [
    CommonModule,
    ButtonModule,
    CardModule,
    ProgressBarModule,
    TreeModule,
    RouterModule.forChild([
      { path: '', component: TestRunnerComponent }
    ])
  ]
})
export class TestRunnerModule { }
