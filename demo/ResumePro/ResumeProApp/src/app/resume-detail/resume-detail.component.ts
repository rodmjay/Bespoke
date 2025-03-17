import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ResumeService } from '../core/services/resume.service';
import { ResumeDetails } from '../core/models/resume.model';

@Component({
  selector: 'app-resume-detail',
  imports: [],
  templateUrl: './resume-detail.component.html',
  styleUrl: './resume-detail.component.scss'
})
export class ResumeDetailComponent implements OnInit {
  personId!: number;
  resumeId!: number;
  resume: ResumeDetails | null = null;
  loading = true;
  error: string | null = null;

  constructor(
    private route: ActivatedRoute,
    private resumeService: ResumeService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.personId = +params['personId'];
      this.resumeId = +params['resumeId'];
      this.loadResumeDetails();
    });
  }

  loadResumeDetails(): void {
    this.loading = true;
    this.resumeService.getResume(this.personId, this.resumeId).subscribe({
      next: (resume) => {
        this.resume = resume;
        this.loading = false;
      },
      error: (err) => {
        this.error = 'Failed to load resume details';
        this.loading = false;
        console.error(err);
      }
    });
  }
}
