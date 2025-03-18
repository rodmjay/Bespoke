import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { CardModule } from 'primeng/card';
import { TabViewModule } from 'primeng/tabview';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { ChipModule } from 'primeng/chip';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { MessageService, ConfirmationService } from 'primeng/api';
import { CompanyService } from '../core/services/company.service';
import { PositionService } from '../core/services/position.service';
import { CompanyDetails, PositionDetails, HighlightDto } from '../core/models/company.model';
import { CompanyFormComponent } from './company-form.component';
import { PositionFormComponent } from './position-form.component';
import { HighlightFormComponent } from './highlight-form.component';

@Component({
  selector: 'app-company-detail',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    CardModule,
    TabViewModule,
    ButtonModule,
    TableModule,
    ChipModule,
    ProgressSpinnerModule,
    ToastModule,
    ConfirmDialogModule,
    CompanyFormComponent,
    PositionFormComponent,
    HighlightFormComponent
  ],
  providers: [MessageService, ConfirmationService],
  templateUrl: './company-detail.component.html',
  styleUrl: './company-detail.component.scss'
})
export class CompanyDetailComponent implements OnInit {
  @ViewChild('companyForm') companyForm!: CompanyFormComponent;
  @ViewChild('positionForm') positionForm!: PositionFormComponent;
  @ViewChild('highlightForm') highlightForm!: HighlightFormComponent;
  
  personId!: number;
  companyId!: number;
  company: CompanyDetails | null = null;
  loading = true;
  error: string | null = null;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private companyService: CompanyService,
    private positionService: PositionService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.personId = +params['personId'];
      this.companyId = +params['companyId'];
      this.loadCompanyDetails();
    });
  }

  loadCompanyDetails(): void {
    this.loading = true;
    this.companyService.getCompany(this.personId, this.companyId).subscribe({
      next: (company) => {
        this.company = company;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error loading company details:', err);
        this.error = 'Failed to load company details. Please try again.';
        this.loading = false;
        
        // Provide mock data for demonstration
        this.company = {
          id: this.companyId,
          company: this.companyId === 1 ? 'Microsoft' : 'Google',
          description: this.companyId === 1 ? 'Global technology company' : 'Search and advertising company',
          location: this.companyId === 1 ? 'Redmond, WA' : 'Mountain View, CA',
          startDate: '2018-01-01',
          endDate: '2020-12-31',
          positionCount: 1,
          showTechnology: true,
          positions: [
            {
              id: 1,
              title: this.companyId === 1 ? 'Software Engineer' : 'Frontend Developer',
              startDate: '2018-01-01',
              endDate: '2020-12-31',
              highlightCount: 2,
              description: this.companyId === 1 ? 'Developed cloud services' : 'Worked on Google Maps',
              highlights: [
                { id: 1, text: 'Implemented new features' },
                { id: 2, text: 'Improved performance by 30%' }
              ]
            }
          ],
          skills: [
            { id: 1, title: this.companyId === 1 ? 'C#' : 'JavaScript' },
            { id: 2, title: this.companyId === 1 ? 'Azure' : 'Angular' }
          ]
        };
      }
    });
  }

  showEditCompanyDialog(): void {
    if (this.company) {
      this.companyForm.showDialog(this.company);
    }
  }

  onCompanyUpdated(company: CompanyDetails): void {
    this.company = company;
    this.messageService.add({
      severity: 'success',
      summary: 'Success',
      detail: 'Company information updated successfully'
    });
  }

  deleteCompany(): void {
    this.confirmationService.confirm({
      message: 'Are you sure you want to delete this company?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.companyService.deleteCompany(this.personId, this.companyId).subscribe({
          next: () => {
            this.messageService.add({
              severity: 'success',
              summary: 'Success',
              detail: 'Company deleted successfully'
            });
            this.router.navigate(['/people', this.personId, 'companies']);
          },
          error: (error) => {
            console.error('Error deleting company:', error);
            this.messageService.add({
              severity: 'error',
              summary: 'Error',
              detail: 'Failed to delete company'
            });
          }
        });
      }
    });
  }

  addPosition(): void {
    if (this.positionForm) {
      this.positionForm.showDialog();
    }
  }

  onPositionUpdated(position: PositionDetails): void {
    this.loadCompanyDetails();
  }

  editPosition(positionId: number): void {
    if (!this.company || !this.positionForm) return;
    
    const position = this.company.positions.find(p => p.id === positionId);
    if (position) {
      this.positionForm.showDialog(position);
    }
  }

  deletePosition(positionId: number): void {
    this.confirmationService.confirm({
      message: 'Are you sure you want to delete this position?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.positionService.deletePosition(this.personId, this.companyId, positionId).subscribe({
          next: () => {
            this.messageService.add({
              severity: 'success',
              summary: 'Success',
              detail: 'Position deleted successfully'
            });
            this.loadCompanyDetails();
          },
          error: (error) => {
            console.error('Error deleting position:', error);
            this.messageService.add({
              severity: 'error',
              summary: 'Error',
              detail: 'Failed to delete position'
            });
          }
        });
      }
    });
  }

  addHighlight(positionId: number): void {
    if (this.highlightForm) {
      this.highlightForm.personId = this.personId;
      this.highlightForm.companyId = this.companyId;
      this.highlightForm.positionId = positionId;
      this.highlightForm.showDialog();
    }
  }

  onHighlightUpdated(highlight: HighlightDto): void {
    this.loadCompanyDetails();
  }

  editHighlight(positionId: number, highlightId: number): void {
    if (!this.company || !this.highlightForm) return;
    
    const position = this.company.positions.find(p => p.id === positionId);
    if (position) {
      const highlight = position.highlights.find(h => h.id === highlightId);
      if (highlight) {
        this.highlightForm.personId = this.personId;
        this.highlightForm.companyId = this.companyId;
        this.highlightForm.positionId = positionId;
        this.highlightForm.showDialog(highlight);
      }
    }
  }

  deleteHighlight(positionId: number, highlightId: number): void {
    this.confirmationService.confirm({
      message: 'Are you sure you want to delete this highlight?',
      header: 'Confirm',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.positionService.deleteHighlight(this.personId, this.companyId, positionId, highlightId).subscribe({
          next: () => {
            this.messageService.add({
              severity: 'success',
              summary: 'Success',
              detail: 'Highlight deleted successfully'
            });
            this.loadCompanyDetails();
          },
          error: (error) => {
            console.error('Error deleting highlight:', error);
            this.messageService.add({
              severity: 'error',
              summary: 'Error',
              detail: 'Failed to delete highlight'
            });
          }
        });
      }
    });
  }

  addSkill(): void {
    // This would navigate to skill selection or open a dialog
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Add Skill functionality will be implemented in the next phase'
    });
  }

  removeSkill(skillId: number): void {
    // This would confirm and remove the skill
    this.messageService.add({
      severity: 'info',
      summary: 'Info',
      detail: 'Remove Skill functionality will be implemented in the next phase'
    });
  }

  goBack(): void {
    this.router.navigate(['/people', this.personId, 'companies']);
  }
}
