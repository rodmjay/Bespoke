import { Component, OnInit } from '@angular/core';
import { SkillService } from '../core/services/skill.service';
import { SkillDto } from '../core/models/skill.model';

@Component({
  selector: 'app-skills',
  imports: [],
  templateUrl: './skills.component.html',
  styleUrl: './skills.component.scss'
})
export class SkillsComponent implements OnInit {
  skills: SkillDto[] = [];
  loading = true;
  error: string | null = null;

  constructor(private skillService: SkillService) {}

  ngOnInit(): void {
    this.loadSkills();
  }

  loadSkills(): void {
    this.loading = true;
    this.skillService.getSkills().subscribe({
      next: (skills) => {
        this.skills = skills;
        this.loading = false;
      },
      error: (err) => {
        this.error = 'Failed to load skills';
        this.loading = false;
        console.error(err);
      }
    });
  }
}
