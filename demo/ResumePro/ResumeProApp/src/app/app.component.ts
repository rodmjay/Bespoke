import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';

@Component({
  selector: 'app-root',
  template: '<app-dashboard></app-dashboard>',
  standalone: false
})
export class AppComponent {
  title = 'resumepro';
}
