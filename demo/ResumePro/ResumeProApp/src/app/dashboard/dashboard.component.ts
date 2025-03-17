import { Component } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { RouterModule } from '@angular/router';
import { MenuModule } from 'primeng/menu';
import { ButtonModule } from 'primeng/button';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterModule, MenuModule, ButtonModule, CommonModule],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {
  menuItems: MenuItem[] = [
    { label: 'People', icon: 'pi pi-users', routerLink: '/people' },
    { label: 'Skills', icon: 'pi pi-star', routerLink: '/skills' }
  ];
  
  menuActive: boolean = false;
  
  toggleMenu(): void {
    this.menuActive = !this.menuActive;
  }
  
  hideMenu(): void {
    this.menuActive = false;
  }
}
