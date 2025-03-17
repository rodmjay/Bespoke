import { Component } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { RouterModule } from '@angular/router';
import { MenuModule } from 'primeng/menu';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterModule, MenuModule],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {
  menuItems: MenuItem[] = [
    { label: 'People', icon: 'pi pi-users', routerLink: '/people' },
    { label: 'Skills', icon: 'pi pi-star', routerLink: '/skills' }
  ];
}
