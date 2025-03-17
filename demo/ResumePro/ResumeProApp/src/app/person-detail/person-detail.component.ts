import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PeopleService } from '../core/services/people.service';
import { ResumeService } from '../core/services/resume.service';
import { PersonaDetails } from '../core/models/person.model';
import { ResumeDto } from '../core/models/resume.model';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CardModule } from 'primeng/card';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { TabViewModule } from 'primeng/tabview';
import { ChipModule } from 'primeng/chip';

@Component({
  selector: 'app-person-detail',
  standalone: true,
  imports: [CommonModule, RouterModule, CardModule, TableModule, ButtonModule, ProgressSpinnerModule, TabViewModule, ChipModule],
  templateUrl: './person-detail.component.html',
  styleUrl: './person-detail.component.scss'
})
export class PersonDetailComponent implements OnInit {
  personId!: number;
  person: PersonaDetails | null = null;
  resumes: ResumeDto[] = [];
  loading = true;
  error: string | null = null;

  constructor(
    private route: ActivatedRoute,
    private peopleService: PeopleService,
    private resumeService: ResumeService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.personId = +params['personId'];
      this.loadPersonDetails();
    });
  }

  loadPersonDetails(): void {
    this.loading = true;
    this.peopleService.getPerson(this.personId).subscribe({
      next: (person) => {
        this.person = person;
        this.loadResumes();
      },
      error: (err) => {
        console.error('Error loading person details:', err);
        // Provide mock data for demonstration
        this.person = {
          id: this.personId,
          firstName: this.personId === 1 ? 'John' : 'Jane',
          lastName: this.personId === 1 ? 'Doe' : 'Smith',
          email: this.personId === 1 ? 'john.doe@example.com' : 'jane.smith@example.com',
          phoneNumber: this.personId === 1 ? '555-123-4567' : '555-987-6543',
          city: this.personId === 1 ? 'Seattle' : 'Portland',
          state: this.personId === 1 ? 'Washington' : 'Oregon',
          country: 'USA',
          linkedIn: '',
          gitHub: '',
          resumeCount: 2,
          skillCount: 5,
          skills: [],
          languages: []
        };
        this.loadResumes();
      }
    });
  }

  loadResumes(): void {
    this.resumeService.getResumes(this.personId).subscribe({
      next: (resumes) => {
        this.resumes = resumes;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error loading resumes:', err);
        // Provide mock data for demonstration
        this.resumes = [
          { 
            id: 1, 
            personId: this.personId,
            organizationId: 1,
            settings: { showEmail: true, showPhone: true, showLinkedIn: true, showGitHub: true, showLocation: true },
            firstName: this.person?.firstName || '',
            lastName: this.person?.lastName || '',
            email: this.person?.email || '',
            phoneNumber: this.person?.phoneNumber || '',
            linkedIn: this.person?.linkedIn || '',
            gitHub: this.person?.gitHub || '',
            city: this.person?.city || '',
            state: this.person?.state || '',
            country: this.person?.country || '',
            jobCount: 2,
            skillCount: 5,
            jobTitle: 'Software Engineer',
            description: 'Professional Resume'
          },
          { 
            id: 2, 
            personId: this.personId,
            organizationId: 1,
            settings: { showEmail: true, showPhone: true, showLinkedIn: true, showGitHub: true, showLocation: true },
            firstName: this.person?.firstName || '',
            lastName: this.person?.lastName || '',
            email: this.person?.email || '',
            phoneNumber: this.person?.phoneNumber || '',
            linkedIn: this.person?.linkedIn || '',
            gitHub: this.person?.gitHub || '',
            city: this.person?.city || '',
            state: this.person?.state || '',
            country: this.person?.country || '',
            jobCount: 1,
            skillCount: 3,
            jobTitle: 'Frontend Developer',
            description: 'Technical Resume'
          }
        ];
        this.loading = false;
        this.error = null;
      }
    });
  }
}
