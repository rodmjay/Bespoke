import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

export interface TestResult {
  description: string;
  status: 'passed' | 'failed' | 'pending';
  failureMessages?: string[];
  children?: TestResult[];
}

export interface TestSuite {
  name: string;
  results: TestResult[];
  passed: number;
  failed: number;
  pending: number;
  total: number;
}

@Injectable({
  providedIn: 'root'
})
export class TestRunnerService {
  private testSuitesSubject = new BehaviorSubject<TestSuite[]>([]);
  public testSuites$ = this.testSuitesSubject.asObservable();
  
  private runningSubject = new BehaviorSubject<boolean>(false);
  public running$ = this.runningSubject.asObservable();

  constructor() {}

  async runTests(): Promise<void> {
    this.runningSubject.next(true);
    this.testSuitesSubject.next([]);
    
    try {
      // Dynamically import Jasmine
      const jasmine = (window as any).jasmine;
      if (!jasmine) {
        await this.loadJasmine();
      }
      
      // Find and load test specs
      const testModules = await this.findTestModules();
      const results = await this.executeTests(testModules);
      
      this.testSuitesSubject.next(results);
    } catch (error) {
      console.error('Error running tests:', error);
    } finally {
      this.runningSubject.next(false);
    }
  }

  private async loadJasmine(): Promise<void> {
    // Load Jasmine scripts dynamically
    await this.loadScript('/assets/jasmine/jasmine.js');
    await this.loadScript('/assets/jasmine/jasmine-html.js');
    await this.loadScript('/assets/jasmine/boot.js');
  }

  private loadScript(src: string): Promise<void> {
    return new Promise((resolve, reject) => {
      const script = document.createElement('script');
      script.src = src;
      script.onload = () => resolve();
      script.onerror = (error) => reject(error);
      document.head.appendChild(script);
    });
  }

  private async findTestModules(): Promise<any[]> {
    // This would normally use a webpack context to find all spec files
    // For simplicity, we'll manually list some test modules
    return [
      await import('../core/services/api.service.spec'),
      await import('../people/people.component.spec'),
      // Add more test modules as needed
    ];
  }

  private async executeTests(modules: any[]): Promise<TestSuite[]> {
    // This would normally use Jasmine's API to run tests
    // For simplicity, we'll return mock results
    return modules.map(module => ({
      name: module.default ? module.default.name : 'Unknown Test Suite',
      results: this.mockTestResults(),
      passed: 3,
      failed: 1,
      pending: 0,
      total: 4
    }));
  }

  private mockTestResults(): TestResult[] {
    return [
      {
        description: 'should create the component',
        status: 'passed'
      },
      {
        description: 'should handle API responses',
        status: 'passed',
        children: [
          {
            description: 'should process successful responses',
            status: 'passed'
          },
          {
            description: 'should handle error responses',
            status: 'failed',
            failureMessages: ['Expected true to be false']
          }
        ]
      }
    ];
  }
}
