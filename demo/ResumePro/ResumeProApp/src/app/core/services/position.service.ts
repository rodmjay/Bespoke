import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Result } from '../models/base.model';
import { PositionDetails, PositionOptions, HighlightDto } from '../models/company.model';

@Injectable({
  providedIn: 'root'
})
export class PositionService extends ApiService {
  getPositions(personId: number, companyId: number): Observable<PositionDetails[]> {
    return this.get<PositionDetails[]>(`/people/${personId}/companies/${companyId}/positions`);
  }

  getPosition(personId: number, companyId: number, positionId: number): Observable<PositionDetails> {
    return this.get<PositionDetails>(`/people/${personId}/companies/${companyId}/positions/${positionId}`);
  }

  createPosition(personId: number, companyId: number, options: PositionOptions): Observable<PositionDetails> {
    return this.post<PositionDetails>(`/people/${personId}/companies/${companyId}/positions`, options);
  }

  updatePosition(personId: number, companyId: number, positionId: number, options: PositionOptions): Observable<PositionDetails> {
    return this.put<PositionDetails>(`/people/${personId}/companies/${companyId}/positions/${positionId}`, options);
  }

  deletePosition(personId: number, companyId: number, positionId: number): Observable<Result> {
    return this.delete<Result>(`/people/${personId}/companies/${companyId}/positions/${positionId}`);
  }

  // Highlight management
  addHighlight(personId: number, companyId: number, positionId: number, text: string): Observable<HighlightDto> {
    return this.post<HighlightDto>(`/people/${personId}/companies/${companyId}/positions/${positionId}/highlights`, { text });
  }

  updateHighlight(personId: number, companyId: number, positionId: number, highlightId: number, text: string): Observable<HighlightDto> {
    return this.put<HighlightDto>(`/people/${personId}/companies/${companyId}/positions/${positionId}/highlights/${highlightId}`, { text });
  }

  deleteHighlight(personId: number, companyId: number, positionId: number, highlightId: number): Observable<Result> {
    return this.delete<Result>(`/people/${personId}/companies/${companyId}/positions/${positionId}/highlights/${highlightId}`);
  }
}
