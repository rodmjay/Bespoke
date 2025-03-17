import { Component } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-dashboard',
  imports: [],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {
  menuItems: MenuItem[] = [
    { label: 'People', icon: 'pi pi-users', routerLink: '/people' },
    { label: 'Skills', icon: 'pi pi-star', routerLink: '/skills' }
  ];
}
