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
  modeRecrutementId: number = 0;
  modeRecrutement?: RecruteMode;
  datePremiereExperience: Date = new Date();
  dateEntreeSqli: Date = new Date();
  // dateSortieSqli: Date = new Date(); // ikhadem: changed to relation
  demissions: Demission[] = [];
  dateDebutStage: Date = new Date();
  diplomes: Diplome[] = [];

  note: string = '';
  phonePersonnel: string = '';
  phoneProfesionnel: string = '';
  autreTechnos: string = '';
  niveauId: number = 0;
  niveau?: Niveau;
  siteId?: number;
  site?: Site;
  skillCenter: string = '';
  emailPersonnel: string = '';
  email: string = '';
  competencePrincipale: string = '';
  adresse: string = '';
  technos: string = '';
  certifications: string = '';
  langues: string = '';
  posteId: number = 0;
  poste?: Poste;
  nationnalite: string = '';
  lieuNaissance: string = '';
  numCin: string = '';
  documents?: CollabFile[];
  situationFamiliale: string = '';
}

export class Demission {
  id: number = 0;
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
  dateSortieSqli: Date = new Date();
  dateDemission: Date = new Date();
  reasonDemission: string = "";
  isCanceled: boolean = false;
}
