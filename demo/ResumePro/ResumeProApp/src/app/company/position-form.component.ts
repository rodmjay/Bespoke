import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { CalendarModule } from 'primeng/calendar';
import { TextareaModule } from 'primeng/textarea';
import { MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { PositionService } from '../core/services/position.service';
import { PositionDetails, PositionOptions } from '../core/models/company.model';

@Component({
  selector: 'app-position-form',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    DialogModule,
    ButtonModule,
    InputTextModule,
    CalendarModule,
    TextareaModule,
    ToastModule
  ],
  providers: [MessageService],
  templateUrl: './position-form.component.html'
})
export class PositionFormComponent implements OnInit {
  @Input() personId!: number;
  @Input() companyId!: number;
  @Output() positionUpdated = new EventEmitter<PositionDetails>();

  positionForm!: FormGroup;
  displayDialog = false;
  dialogTitle = 'Add Position';
  isEdit = false;
  positionId?: number;
  loading = false;

  constructor(
    private formBuilder: FormBuilder,
    private positionService: PositionService,
    private messageService: MessageService
  ) {}

  ngOnInit(): void {
    this.initForm();
  }

  initForm(): void {
    this.positionForm = this.formBuilder.group({
      title: ['', Validators.required],
      description: ['', Validators.required],
      startDate: ['', Validators.required],
      endDate: ['']
    });
  }

  showDialog(position?: PositionDetails): void {
    this.isEdit = !!position;
    this.dialogTitle = this.isEdit ? 'Edit Position' : 'Add Position';
    
    if (position) {
      this.positionId = position.id;
      this.positionForm.patchValue({
        title: position.title,
        description: position.description,
        startDate: new Date(position.startDate),
        endDate: position.endDate ? new Date(position.endDate) : null
      });
    } else {
      this.positionForm.reset();
      this.positionForm.patchValue({
        startDate: new Date()
      });
    }
    
    this.displayDialog = true;
  }

  hideDialog(): void {
    this.displayDialog = false;
  }

  onSubmit(): void {
    if (this.positionForm.invalid) {
      return;
    }

    this.loading = true;
    const formValues = this.positionForm.value;
    
    // Format dates for API
    const positionOptions: PositionOptions = {
      title: formValues.title,
      description: formValues.description,
      startDate: formValues.startDate.toISOString().split('T')[0],
      endDate: formValues.endDate ? formValues.endDate.toISOString().split('T')[0] : undefined
    };

    if (this.isEdit && this.positionId) {
      this.positionService.updatePosition(this.personId, this.companyId, this.positionId, positionOptions).subscribe({
        next: (position) => {
          this.messageService.add({
            severity: 'success',
            summary: 'Success',
            detail: 'Position updated successfully'
          });
          this.positionUpdated.emit(position);
          this.hideDialog();
          this.loading = false;
        },
        error: (error) => {
          console.error('Error updating position:', error);
          this.messageService.add({
            severity: 'error',
            summary: 'Error',
            detail: 'Failed to update position'
          });
          this.loading = false;
        }
      });
    } else {
      this.positionService.createPosition(this.personId, this.companyId, positionOptions).subscribe({
        next: (position) => {
          this.messageService.add({
            severity: 'success',
            summary: 'Success',
            detail: 'Position created successfully'
          });
          this.positionUpdated.emit(position);
          this.hideDialog();
          this.loading = false;
        },
        error: (error) => {
          console.error('Error creating position:', error);
          this.messageService.add({
            severity: 'error',
            summary: 'Error',
            detail: 'Failed to create position'
          });
          this.loading = false;
        }
      });
    }
  }
}
