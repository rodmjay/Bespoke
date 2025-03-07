import { Routes } from '@angular/router';
import { IntroductionComponent } from './introduction/introduction.component';

export const routes: Routes = [
  { path: '', component: IntroductionComponent },
  { path: 'introduction', component: IntroductionComponent },
  { path: '**', redirectTo: '' }
];
