import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../core/services/people.service';
import { PagedList, PagingQuery } from '../core/models/base.model';
import { PersonaDto, PersonaFilters } from '../core/models/person.model';

@Component({
  selector: 'app-people',
  imports: [],
  templateUrl: './people.component.html',
  styleUrl: './people.component.scss'
})
export class PeopleComponent implements OnInit {
  people: PersonaDto[] = [];
  loading = true;
  error: string | null = null;

  constructor(private peopleService: PeopleService) {}

  ngOnInit(): void {
    this.loadPeople();
  }

  loadPeople(): void {
    this.loading = true;
    this.peopleService.getPeople().subscribe({
      next: (response) => {
        this.people = response.items;
        this.loading = false;
      },
      error: (err) => {
        this.error = 'Failed to load people data';
        this.loading = false;
        console.error(err);
      }
    });
  }
}
