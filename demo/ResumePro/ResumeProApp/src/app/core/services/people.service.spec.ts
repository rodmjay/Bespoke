import { HttpTestingController } from '@angular/common/http/testing';
import { expectRequest, setupTestBed } from '../tests/test-utils';
import { PeopleService } from './people.service';
import { PersonaDetails, PersonaDto, PersonOptions } from '../models/person.model';

describe('PeopleService', () => {
  let service: PeopleService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    const testBed = setupTestBed<PeopleService>(PeopleService);
    service = testBed.service as PeopleService;
    httpMock = testBed.httpMock;
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should get people with search', () => {
    const mockResponse = {
      items: [{ id: 1, firstName: 'John', lastName: 'Doe' }] as PersonaDto[],
      pageIndex: 0,
      totalPages: 1,
      totalCount: 1,
      hasPreviousPage: false,
      hasNextPage: false
    };
    
    const filters = { searchTerm: 'John' };
    const paging = { pageIndex: 0, pageSize: 10 };

    service.getPeople(filters, paging).subscribe(response => {
      expect(response).toEqual(mockResponse);
    });

    const req = expectRequest(httpMock, 'POST', '/people/Search', filters);
    req.flush(mockResponse);
  });

  it('should get a person by id', () => {
    const mockPerson: PersonaDetails = {
      id: 1,
      firstName: 'John',
      lastName: 'Doe',
      email: 'john@example.com',
      phoneNumber: '123-456-7890',
      linkedIn: 'linkedin.com/johndoe',
      gitHub: 'github.com/johndoe',
      city: 'New York',
      state: 'NY',
      country: 'USA',
      resumeCount: 2,
      skillCount: 5,
      skills: [],
      languages: []
    };

    service.getPerson(1).subscribe(person => {
      expect(person).toEqual(mockPerson);
    });

    const req = expectRequest(httpMock, 'GET', '/people/1');
    req.flush(mockPerson);
  });

  it('should create a person', () => {
    const options: PersonOptions = {
      firstName: 'John',
      lastName: 'Doe',
      email: 'john@example.com',
      phoneNumber: '123-456-7890',
      linkedIn: 'linkedin.com/johndoe',
      gitHub: 'github.com/johndoe',
      city: 'New York',
      state: 'NY',
      country: 'USA'
    };

    const mockResponse: PersonaDetails = {
      id: 1,
      ...options,
      resumeCount: 0,
      skillCount: 0,
      skills: [],
      languages: []
    };

    service.createPerson(options).subscribe(response => {
      expect(response).toEqual(mockResponse);
    });

    const req = expectRequest(httpMock, 'POST', '/people', options);
    req.flush(mockResponse);
  });

  it('should update a person', () => {
    const personId = 1;
    const options: PersonOptions = {
      firstName: 'John',
      lastName: 'Smith',
      email: 'john@example.com',
      phoneNumber: '123-456-7890',
      linkedIn: 'linkedin.com/johnsmith',
      gitHub: 'github.com/johnsmith',
      city: 'New York',
      state: 'NY',
      country: 'USA'
    };

    const mockResponse: PersonaDetails = {
      id: personId,
      ...options,
      resumeCount: 2,
      skillCount: 5,
      skills: [],
      languages: []
    };

    service.updatePerson(personId, options).subscribe(response => {
      expect(response).toEqual(mockResponse);
    });

    const req = expectRequest(httpMock, 'PUT', `/people/${personId}`, options);
    req.flush(mockResponse);
  });

  it('should delete a person', () => {
    const personId = 1;
    const mockResponse = { succeeded: true, errors: [] };

    service.deletePerson(personId).subscribe(response => {
      expect(response).toEqual(mockResponse);
    });

    const req = expectRequest(httpMock, 'DELETE', `/people/${personId}`);
    req.flush(mockResponse);
  });
});
