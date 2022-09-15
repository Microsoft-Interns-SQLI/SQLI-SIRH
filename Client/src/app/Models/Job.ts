export class Job {
  id: number = 0;
  salairePrevu: number = 0;
  label: string = '';
  entite: string = '';
  besoinEffectif: number = 0;
  isClosed: boolean = false;
  dateCreation: Date = new Date();
  dateDebut: Date = new Date();
  dateFin?: Date = new Date();

  typeContrat: string = '';
}
