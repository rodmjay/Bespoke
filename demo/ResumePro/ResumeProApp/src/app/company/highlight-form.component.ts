import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { ButtonModule } from 'primeng/button';
import { TextareaModule } from 'primeng/textarea';
import { MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { PositionService } from '../core/services/position.service';
import { HighlightDto } from '../core/models/company.model';

@Component({
  selector: 'app-highlight-form',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    DialogModule,
    ButtonModule,
    TextareaModule,
    ToastModule
  ],
  providers: [MessageService],
  templateUrl: './highlight-form.component.html'
})
export class HighlightFormComponent implements OnInit {
  @Input() personId!: number;
  @Input() companyId!: number;
  @Input() positionId!: number;
  @Output() highlightUpdated = new EventEmitter<HighlightDto>();

  highlightForm!: FormGroup;
  displayDialog = false;
  dialogTitle = 'Add Highlight';
  isEdit = false;
  highlightId?: number;
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
    this.highlightForm = this.formBuilder.group({
      text: ['', Validators.required]
    });
  }

  showDialog(highlight?: HighlightDto): void {
    this.isEdit = !!highlight;
    this.dialogTitle = this.isEdit ? 'Edit Highlight' : 'Add Highlight';
    
    if (highlight) {
      this.highlightId = highlight.id;
      this.highlightForm.patchValue({
        text: highlight.text
      });
    } else {
      this.highlightForm.reset();
    }
    
    this.displayDialog = true;
  }

  hideDialog(): void {
    this.displayDialog = false;
  }

  onSubmit(): void {
    if (this.highlightForm.invalid) {
      return;
    }

    this.loading = true;
    const text = this.highlightForm.value.text;

    if (this.isEdit && this.highlightId) {
      this.positionService.updateHighlight(this.personId, this.companyId, this.positionId, this.highlightId, text).subscribe({
        next: (highlight) => {
          this.messageService.add({
            severity: 'success',
            summary: 'Success',
            detail: 'Highlight updated successfully'
          });
          this.highlightUpdated.emit(highlight);
          this.hideDialog();
          this.loading = false;
        },
        error: (error) => {
          console.error('Error updating highlight:', error);
          this.messageService.add({
            severity: 'error',
            summary: 'Error',
            detail: 'Failed to update highlight'
          });
          this.loading = false;
        }
      });
    } else {
      this.positionService.addHighlight(this.personId, this.companyId, this.positionId, text).subscribe({
        next: (highlight) => {
          this.messageService.add({
            severity: 'success',
            summary: 'Success',
            detail: 'Highlight added successfully'
          });
          this.highlightUpdated.emit(highlight);
          this.hideDialog();
          this.loading = false;
        },
        error: (error) => {
          console.error('Error adding highlight:', error);
          this.messageService.add({
            severity: 'error',
            summary: 'Error',
            detail: 'Failed to add highlight'
          });
          this.loading = false;
        }
      });
    }
  }
}
