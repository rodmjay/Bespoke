import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PeopleService } from '../core/services/people.service';
import { ResumeService } from '../core/services/resume.service';
import { PersonaDetails } from '../core/models/person.model';
import { ResumeDto } from '../core/models/resume.model';

@Component({
  selector: 'app-person-detail',
  imports: [],
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
      this.personId = +params['id'];
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
        this.error = 'Failed to load person details';
        this.loading = false;
        console.error(err);
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
        this.error = 'Failed to load resumes';
        this.loading = false;
        console.error(err);
      }
    });
  }
}
