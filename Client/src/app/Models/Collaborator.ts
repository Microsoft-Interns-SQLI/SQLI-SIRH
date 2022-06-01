import { Carriere } from './Carriere';
import { CollabFile } from './collabFile';
import { Diplome, ReasonDemission, Site, SkillCenter } from './MdmModel';
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
  site?: Site;
  skillCenter?: SkillCenter;
  emailPersonnel: string = '';
  email: string = '';
  competencePrincipale: string = '';
  adresse: string = '';
  technos: string = '';
  certifications: string = '';
  langues: string = '';
  niveauId: number = 0;
  niveau?: Niveau;
  posteId: number = 0;
  poste?: Poste;
  carrieres: Carriere[] = [];
  nationnalite: string = '';
  siteId?: number;
  lieuNaissance: string = '';
  numCin: string = '';
  documents?: CollabFile[];
  situationFamiliale: string = '';
  imgPath: string = "";
}

export class Demission {
  id: number = 0;
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
  dateSortieSqli: Date = new Date();
  dateDemission: Date = new Date();
  reasonDemissionId: number = 0;
  reasonDemission?: ReasonDemission;
  comment: string = "";
  isCanceled: boolean = false;
}