import { CollabFile } from './collabFile';
import { Diplome } from './MdmModel';
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
  diplomesList: Diplome[] = [];

  note: string = '';
  phonePersonnel: string = '';
  phoneProfesionnel: string = '';
  autreTechnos: string = '';
  typeContrat: string = '';
  niveau: Niveau = new Niveau();
  site: string = '';
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
