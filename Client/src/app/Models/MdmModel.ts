class BaseMDM {
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
}

export class Poste extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class Niveau extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class Site extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class RecruteMode extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class SkillCenter extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class Contrat extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class ReasonDemission extends BaseMDM {
  id: number = 0;
  name: string = '';
}

export class CollabTypeContrat extends BaseMDM {
  id: number = 0;
  dateDebut: Date = new Date();
  dateFin: Date = new Date();
  isInSQLI: Boolean = true;
  typeContratId: number = 0;
  typeContrat?: Contrat;
  collaborateurId: number = 0;
}

export class Diplome extends BaseMDM {
  id: number = 0;
  annee?: number;
  label?: string;
  detail?: string;
  description?: string;
}
