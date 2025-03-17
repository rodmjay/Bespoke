import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PeopleComponent } from './people/people.component';
import { PersonDetailComponent } from './person-detail/person-detail.component';
import { ResumeDetailComponent } from './resume-detail/resume-detail.component';
import { SkillsComponent } from './skills/skills.component';

const routes: Routes = [
  { path: '', redirectTo: '/people', pathMatch: 'full' },
  { path: 'people', component: PeopleComponent },
  { path: 'person/:id', component: PersonDetailComponent },
  { path: 'person/:personId/resume/:resumeId', component: ResumeDetailComponent },
  { path: 'skills', component: SkillsComponent },
  { path: '**', redirectTo: '/people' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
