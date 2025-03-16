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

export interface PersonaDetails extends PersonaDto {
  skills: any[]; // Will be typed as PersonaSkillDto[] after creating skill models
  languages: any[]; // Will be typed as PersonaLanguageDto[] after creating language models
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
