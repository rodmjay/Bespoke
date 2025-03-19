import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { catchError, map, switchMap } from 'rxjs/operators';
import { timer } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environments/environment';
import * as ApiActions from './api.actions';

@Injectable()
export class ApiEffects {
  checkHealth$ = createEffect(() => this.actions$.pipe(
    ofType(ApiActions.checkApiHealth),
    switchMap(() => this.http.get(`${environment.apiUrl}/health`).pipe(
      map(() => ApiActions.apiHealthSuccess()),
      catchError(() => [ApiActions.apiHealthFailure()])
    ))
  ));

  // Check health every 30 seconds
  periodicHealthCheck$ = createEffect(() => timer(0, 30000).pipe(
    map(() => ApiActions.checkApiHealth())
  ));

  constructor(
    private actions$: Actions,
    private http: HttpClient
  ) {}
}
