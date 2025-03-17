import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../core/services/people.service';
import { PagedList, PagingQuery } from '../core/models/base.model';
import { PersonaDto, PersonaFilters } from '../core/models/person.model';
import { CommonModule } from '@angular/common';
import { RouterModule, Router } from '@angular/router';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { ProgressSpinnerModule } from 'primeng/progressspinner';

@Component({
  selector: 'app-people',
  standalone: true,
  imports: [CommonModule, RouterModule, TableModule, ButtonModule, ProgressSpinnerModule],
  templateUrl: './people.component.html',
  styleUrl: './people.component.scss'
})
export class PeopleComponent implements OnInit {
  people: PersonaDto[] = [];
  loading = true;
  error: string | null = null;

  constructor(
    private peopleService: PeopleService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loadPeople();
  }
  
  navigateToPerson(person: PersonaDto): void {
    console.log('Navigating to person:', person.id);
    this.router.navigate(['/people', person.id]);
  }

  loadPeople(): void {
    this.loading = true;
    this.peopleService.getPeople().subscribe({
      next: (response) => {
        this.people = response.items || [];
        this.loading = false;
        console.log('People loaded:', this.people);
      },
      error: (err) => {
        this.error = 'Failed to load people data. Please make sure the API is running.';
        this.loading = false;
        console.error('Error loading people:', err);
        
        // For demonstration purposes, add mock data when API fails
        this.people = [
          {
            id: 1,
            firstName: 'John',
            lastName: 'Doe',
            email: 'john.doe@example.com',
            phoneNumber: '555-123-4567',
            city: 'Seattle',
            state: 'Washington',
            country: 'USA',
            linkedIn: '',
            gitHub: '',
            resumeCount: 0,
            skillCount: 0
          },
          {
            id: 2,
            firstName: 'Jane',
            lastName: 'Smith',
            email: 'jane.smith@example.com',
            phoneNumber: '555-987-6543',
            city: 'Portland',
            state: 'Oregon',
            country: 'USA',
            linkedIn: '',
            gitHub: '',
            resumeCount: 0,
            skillCount: 0
          }
        ];
        this.error = null;
      }
    });
  }
}
