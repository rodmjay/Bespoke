import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PeopleService } from '../core/services/people.service';
import { ResumeService } from '../core/services/resume.service';
import { PersonaDetails, PersonaLanguage, School, Degree, Skill } from '../core/models/person.model';
import { ResumeDto, ResumeOptions } from '../core/models/resume.model';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CardModule } from 'primeng/card';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { TabViewModule } from 'primeng/tabview';
import { ChipModule } from 'primeng/chip';
import { TagModule } from 'primeng/tag';
import { ToastModule } from 'primeng/toast';
import { MessageService, ConfirmationService } from 'primeng/api';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { PersonEditFormComponent } from './person-edit-form/person-edit-form.component';

@Component({
  selector: 'app-person-detail',
  standalone: true,
  imports: [
    CommonModule, 
    RouterModule, 
    CardModule, 
    TableModule, 
    ButtonModule, 
    ProgressSpinnerModule, 
    TabViewModule, 
    ChipModule, 
    TagModule,
    ToastModule,
    ConfirmDialogModule,
    PersonEditFormComponent
  ],
  providers: [MessageService, ConfirmationService],
  templateUrl: './person-detail.component.html',
  styleUrl: './person-detail.component.scss'
})
export class PersonDetailComponent implements OnInit {
  @ViewChild('personEditForm') personEditForm!: PersonEditFormComponent;
  
  personId!: number;
  person: PersonaDetails | null = null;
  resumes: ResumeDto[] = [];
  loading = true;
  error: string | null = null;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private peopleService: PeopleService,
    private resumeService: ResumeService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
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
          skills: [
            { id: 1, title: 'C#' },
            { id: 2, title: 'Azure' },
            { id: 4, title: 'Angular' },
            { id: 5, title: 'Entity Framework' },
            { id: 6, title: 'TypeScript' }
          ],
          languages: [
            {
              code3: 'eng',
              name: 'English',
              proficiency: 5,
              proficiencyName: 'Fluent'
            },
            {
              code3: 'spa',
              name: 'Spanish',
              proficiency: 3,
              proficiencyName: 'Intermediate'
            },
            {
              code3: 'fra',
              name: 'French',
              proficiency: 2,
              proficiencyName: 'Elementary'
            }
          ],
          schools: [
            {
              id: 1,
              name: 'University of Washington',
              location: 'Seattle, WA',
              startDate: '2010-09-01',
              endDate: '2014-05-31',
              degrees: [
                { id: 1, name: 'Bachelor of Science in Computer Science', order: 1 }
              ]
            },
            {
              id: 2,
              name: 'Stanford University',
              location: 'Palo Alto, CA',
              startDate: '2014-09-01',
              endDate: '2016-05-31',
              degrees: [
                { id: 1, name: 'Master of Science in Computer Science', order: 1 }
              ]
            }
          ]
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

  getLanguageProficiencySeverity(proficiency: number): 'success' | 'info' | 'warn' | 'danger' | 'secondary' {
    switch (proficiency) {
      case 1: return 'info';      // Beginner
      case 2: return 'info';      // Elementary
      case 3: return 'warn';      // Intermediate
      case 4: return 'warn';      // Advanced
      case 5: return 'success';   // Fluent
      default: return 'secondary'; // None
    }
  }

  showEditPersonDialog(): void {
    this.personEditForm.showDialog();
  }

  onPersonUpdated(person: PersonaDetails): void {
    this.person = person;
    this.messageService.add({
      severity: 'success',
      summary: 'Success',
      detail: 'Person information updated successfully'
    });
  }

  createResume(): void {
    if (!this.person) return;

    const resumeOptions: ResumeOptions = {
      jobTitle: 'New Resume',
      description: 'Resume Description',
      settings: {
        showEmail: true,
        showPhone: true,
        showLinkedIn: true,
        showGitHub: true,
        showLocation: true
      },
      skillIds: [],
      companyIds: []
    };

    this.resumeService.createResume(this.personId, resumeOptions).subscribe({
      next: (resume) => {
        this.messageService.add({
          severity: 'success',
          summary: 'Success',
          detail: 'Resume created successfully'
        });
        this.loadResumes();
      },
      error: (error) => {
        console.error('Error creating resume:', error);
        this.messageService.add({
          severity: 'error',
          summary: 'Error',
          detail: 'Failed to create resume'
        });
      }
    });
  }

  deleteResume(resumeId: number): void {
    this.confirmationService.confirm({
      message: 'Are you sure you want to delete this resume?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.resumeService.deleteResume(this.personId, resumeId).subscribe({
          next: () => {
            this.messageService.add({
              severity: 'success',
              summary: 'Success',
              detail: 'Resume deleted successfully'
            });
            this.loadResumes();
          },
          error: (error) => {
            console.error('Error deleting resume:', error);
            this.messageService.add({
              severity: 'error',
              summary: 'Error',
              detail: 'Failed to delete resume'
            });
          }
        });
      }
    });
  }

  addSkills(): void {
    // Navigate to skills component with return URL
    this.router.navigate(['/skills'], { 
      queryParams: { 
        personId: this.personId,
        returnUrl: `/people/${this.personId}`
      } 
    });
  }

  removeSkill(skillId: number): void {
    if (!this.person) return;

    this.peopleService.toggleSkill(this.personId, skillId).subscribe({
      next: () => {
        // Update local skills list
        if (this.person && this.person.skills) {
          this.person.skills = this.person.skills.filter(s => s.id !== skillId);
          this.person.skillCount = this.person.skills.length;
        }
        
        this.messageService.add({
          severity: 'success',
          summary: 'Success',
          detail: 'Skill removed successfully'
        });
      },
      error: (error) => {
        console.error('Error removing skill:', error);
        this.messageService.add({
          severity: 'error',
          summary: 'Error',
          detail: 'Failed to remove skill'
        });
      }
    });
  }

  addEducation(): void {
    // This would open a dialog to add a new school
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Add Education functionality will be implemented in the next phase'
    });
  }

  editSchool(school: School): void {
    // This would open a dialog to edit the school
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Edit School functionality will be implemented in the next phase'
    });
  }

  deleteSchool(schoolId: number): void {
    // This would confirm and delete the school
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Delete School functionality will be implemented in the next phase'
    });
  }

  addDegree(schoolId: number): void {
    // This would open a dialog to add a new degree
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Add Degree functionality will be implemented in the next phase'
    });
  }

  editDegree(schoolId: number, degree: Degree): void {
    // This would open a dialog to edit the degree
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Edit Degree functionality will be implemented in the next phase'
    });
  }

  deleteDegree(schoolId: number, degreeId: number): void {
    // This would confirm and delete the degree
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Delete Degree functionality will be implemented in the next phase'
    });
  }

  addLanguage(): void {
    // This would open a dialog to add a new language
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Add Language functionality will be implemented in the next phase'
    });
  }

  editLanguage(language: PersonaLanguage): void {
    // This would open a dialog to edit the language
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Edit Language functionality will be implemented in the next phase'
    });
  }

  removeLanguage(languageCode: string): void {
    // This would confirm and remove the language
    // For now, we'll just show a message
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Remove Language functionality will be implemented in the next phase'
    });
  }
}
