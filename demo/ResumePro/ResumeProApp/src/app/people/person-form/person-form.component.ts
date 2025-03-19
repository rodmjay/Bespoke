import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { ToastModule } from 'primeng/toast';
import { MessageService } from 'primeng/api';
import { PeopleService } from '../../core/services/people.service';
import { PersonOptions } from '../../core/models/person.model';
import { DropdownModule } from 'primeng/dropdown';
import { RippleModule } from 'primeng/ripple';

@Component({
  selector: 'app-person-form',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    DialogModule,
    ButtonModule,
    InputTextModule,
    ToastModule,
    DropdownModule,
    RippleModule
  ],
  providers: [MessageService],
  templateUrl: './person-form.component.html',
  styleUrl: './person-form.component.scss'
})
export class PersonFormComponent implements OnInit {
  @Output() personCreated = new EventEmitter<any>();
  @Output() dialogClosed = new EventEmitter<void>();
  
  personForm!: FormGroup;
  visible = false;
  loading = false;
  countries = [
    { name: 'United States', code: 'USA' },
    { name: 'Canada', code: 'CAN' },
    { name: 'United Kingdom', code: 'GBR' }
  ];
  
  constructor(
    private fb: FormBuilder,
    private peopleService: PeopleService,
    private messageService: MessageService
  ) {}

  ngOnInit(): void {
    this.initForm();
  }

  initForm(): void {
    this.personForm = this.fb.group({
      firstName: ['', [Validators.required, Validators.maxLength(50)]],
      lastName: ['', [Validators.required, Validators.maxLength(50)]],
      email: ['', [Validators.required, Validators.email, Validators.maxLength(100)]],
      phoneNumber: ['', [Validators.required, Validators.pattern(/^\d{3}-\d{3}-\d{4}$/)]],
      linkedIn: [''],
      gitHub: [''],
      city: ['', [Validators.required]],
      state: ['', [Validators.required]],
      country: ['USA', [Validators.required]]
    });
  }

  showDialog(): void {
    this.visible = true;
    this.initForm();
  }

  hideDialog(): void {
    this.visible = false;
    this.dialogClosed.emit();
  }

  onSubmit(): void {
    if (this.personForm.invalid) {
      this.markFormGroupTouched(this.personForm);
      return;
    }

    this.loading = true;
    const personData: PersonOptions = this.personForm.value;
    
    this.peopleService.createPerson(personData).subscribe({
      next: (response) => {
        this.messageService.add({
          severity: 'success',
          summary: 'Success',
          detail: 'Person created successfully'
        });
        this.loading = false;
        this.personCreated.emit(response);
        this.hideDialog();
      },
      error: (error) => {
        console.error('Error creating person:', error);
        this.messageService.add({
          severity: 'error',
          summary: 'Error',
          detail: 'Failed to create person. Please try again.'
        });
        this.loading = false;
      }
    });
  }

  // Helper method to mark all form controls as touched
  markFormGroupTouched(formGroup: FormGroup): void {
    Object.values(formGroup.controls).forEach(control => {
      control.markAsTouched();
      if (control instanceof FormGroup) {
        this.markFormGroupTouched(control);
      }
    });
  }
}
