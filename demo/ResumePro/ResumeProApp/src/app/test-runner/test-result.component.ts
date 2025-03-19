import { Component, Input } from '@angular/core';
import { TestResult } from './test-runner.service';

@Component({
  selector: 'app-test-result',
  template: `
    <div class="test-result" [ngClass]="result.status">
      <div class="test-header">
        <i class="pi" [ngClass]="getStatusIcon()"></i>
        <span>{{ result.description }}</span>
      </div>
      
      <div *ngIf="result.failureMessages && result.failureMessages.length > 0" class="failure-messages">
        <div *ngFor="let message of result.failureMessages" class="failure-message">
          {{ message }}
        </div>
      </div>
      
      <div *ngIf="result.children && result.children.length > 0" class="children">
        <app-test-result *ngFor="let child of result.children" [result]="child"></app-test-result>
      </div>
    </div>
  `,
  styles: [`
    .test-result {
      margin: 0.5rem 0;
      padding: 0.5rem;
      border-radius: 4px;
    }
    .test-header {
      display: flex;
      align-items: center;
      gap: 0.5rem;
    }
    .passed {
      background-color: rgba(34, 197, 94, 0.1);
    }
    .failed {
      background-color: rgba(239, 68, 68, 0.1);
    }
    .pending {
      background-color: rgba(245, 158, 11, 0.1);
    }
    .failure-messages {
      margin-top: 0.5rem;
      padding: 0.5rem;
      background-color: rgba(239, 68, 68, 0.05);
      border-left: 3px solid #ef4444;
    }
    .children {
      margin-left: 1.5rem;
    }
  `]
})
export class TestResultComponent {
  @Input() result!: TestResult;
  
  getStatusIcon(): string {
    switch (this.result.status) {
      case 'passed': return 'pi-check-circle';
      case 'failed': return 'pi-times-circle';
      case 'pending': return 'pi-clock';
      default: return 'pi-question-circle';
    }
  }
}
