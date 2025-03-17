export interface PersonaDto {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  phoneNumber: string;
  linkedIn: string;
  gitHub: string;
  city: string;
  state: string;
  country: string;
  resumeCount: number;
  skillCount: number;
}

export interface Skill {
  id: number;
  title: string;
}

export interface School {
  id: number;
  name: string;
  location: string;
  startDate: string;
  endDate?: string;
  degrees: Degree[];
}

export interface Degree {
  id: number;
  name: string;
  order: number;
}

export interface PersonaDetails extends PersonaDto {
  skills: Skill[]; // Properly typed as Skill[]
  languages: any[]; // Will be typed as PersonaLanguageDto[] after creating language models
  schools: School[];
}

export interface PersonOptions {
  firstName: string;
  lastName: string;
  email: string;
  phoneNumber: string;
  linkedIn: string;
  gitHub: string;
  city: string;
  state: string;
  country: string;
}

export interface PersonaFilters {
  searchTerm?: string;
}
