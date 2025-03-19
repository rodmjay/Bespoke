import { Component, OnInit } from '@angular/core';
import { TestRunnerService, TestSuite } from './test-runner.service';
import { Observable } from 'rxjs';
import { TreeNode } from 'primeng/api';

@Component({
  selector: 'app-test-runner',
  template: `
    <div class="test-runner-container">
      <div class="test-runner-header">
        <h1>Jasmine Test Runner</h1>
        <p-button 
          label="Run Tests" 
          icon="pi pi-play" 
          [disabled]="(running$ | async) === true"
          (click)="runTests()">
        </p-button>
      </div>
      
      <p-progressBar *ngIf="running$ | async" mode="indeterminate"></p-progressBar>
      
      <div *ngIf="(testSuites$ | async)?.length === 0 && (running$ | async) === false" class="empty-state">
        <p>No tests have been run yet. Click "Run Tests" to start.</p>
      </div>
      
      <div *ngFor="let suite of testSuites$ | async" class="test-suite">
        <p-card [header]="suite.name">
          <div class="test-summary">
            <span class="passed">Passed: {{suite.passed}}</span>
            <span class="failed">Failed: {{suite.failed}}</span>
            <span class="pending">Pending: {{suite.pending}}</span>
            <span class="total">Total: {{suite.total}}</span>
          </div>
          
          <p-tree [value]="transformResults(suite.results)" [expandedKeys]="expandedKeys"></p-tree>
        </p-card>
      </div>
    </div>
  `,
  styles: [`
    .test-runner-container {
      padding: 1rem;
    }
    .test-runner-header {
      display: flex;
      justify-content: space-between;
      align-items: center;
      margin-bottom: 1rem;
    }
    .empty-state {
      text-align: center;
      padding: 2rem;
      background-color: #f8f9fa;
      border-radius: 4px;
      margin: 1rem 0;
    }
    .test-summary {
      display: flex;
      gap: 1rem;
      margin-bottom: 1rem;
    }
    .passed {
      color: #22c55e;
    }
    .failed {
      color: #ef4444;
    }
    .pending {
      color: #f59e0b;
    }
    .test-suite {
      margin-bottom: 1rem;
    }
  `]
})
export class TestRunnerComponent implements OnInit {
  testSuites$!: Observable<TestSuite[]>;
  running$!: Observable<boolean>;
  expandedKeys: {[key: string]: boolean} = {};
  
  constructor(private testRunnerService: TestRunnerService) {
    this.testSuites$ = this.testRunnerService.testSuites$;
    this.running$ = this.testRunnerService.running$;
  }
  
  ngOnInit(): void {
    // Auto-expand all nodes
    this.expandedKeys = {'0': true, '0-0': true, '0-1': true};
  }
  
  runTests(): void {
    this.testRunnerService.runTests();
  }
  
  transformResults(results: any[]): TreeNode[] {
    return results.map((result, index) => {
      const node: TreeNode = {
        key: index.toString(),
        label: result.description,
        icon: this.getStatusIcon(result.status),
        styleClass: result.status,
        data: result
      };
      
      if (result.children && result.children.length > 0) {
        node.children = this.transformResults(result.children).map((child, childIndex) => {
          child.key = `${index}-${childIndex}`;
          return child;
        });
      }
      
      return node;
    });
  }
  
  getStatusIcon(status: string): string {
    switch (status) {
      case 'passed': return 'pi pi-check-circle';
      case 'failed': return 'pi pi-times-circle';
      case 'pending': return 'pi pi-clock';
      default: return 'pi pi-question-circle';
    }
  }
}
