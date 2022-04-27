import { CollabFile } from './collabFile';
import { Diplome, Site } from './MdmModel';
import { Niveau, Poste, RecruteMode } from './MdmModel';
export class Collaborator {
  id: number = 0;
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
  nom: string = '';
  prenom: string = '';
  dateNaissance: Date = new Date();
  matricule: string = '';
  civilite: string = '';
  modeRecrutement: RecruteMode = new RecruteMode();
  datePremiereExperience: Date = new Date();
  dateEntreeSqli: Date = new Date();
  dateSortieSqli: Date = new Date();
  dateDebutStage: Date = new Date();
  diplomes: Diplome[] = [];

  note: string = '';
  phonePersonnel: string = '';
  phoneProfesionnel: string = '';
  autreTechnos: string = '';
  typeContrat: string = '';
  niveau: Niveau = new Niveau();
  site: Site = new Site();
  skillCenter: string = '';
  emailPersonnel: string = '';
  email: string = '';
  competencePrincipale: string = '';
  adresse: string = '';
  technos: string = '';
  certifications: string = '';
  langues: string = '';
  poste: Poste = new Poste();
  nationnalite: string = '';
  lieuNaissance: string = '';
  numCin: string = '';
  documents?: CollabFile[];
  situationFamiliale: string = '';
  hadAlreadyWorkedAtSQLI: boolean = false;
}

export class CollabAddUpdate {
  id?: number
  creationDate?: Date
  modificationDate?: Date
  nom?: string
  prenom?: string
  email?: string
  dateNaissance?: string
  matricule?: string
  civilite?: string
  autreTechnos?: string
  situationFamiliale?: string
  numCin?: string
  nationnalite?: string
  lieuNaissance?: string
  phoneProfesionnel?: string
  phonePersonnel?: string
  emailPersonnel?: string
  adresse?: string
  langues?: string
  note?: string
  datePremiereExperience?: Date
  dateEntreeSqli?: Date
  dateSortieSqli?: Date
  dateDebutStage?: Date
  certifications?: string
  hadAlreadyWorkedAtSQLI?: boolean
  posteId?: number
  skillCenterId?: number
  siteId?: number
  niveauId?: number
  typeContratId?: number
  modeRecrutementId?: number
}
