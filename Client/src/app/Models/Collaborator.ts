export class Collaborator {
  id: number = 0;
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
  nom: string = '';
  prenom: string = '';
  dateNaissance: Date = new Date();
  matricule: string = '';
  civilite: string = '';
  modeRecrutement: string = '';
  datePremiereExperience: Date = new Date();
  dateEntreeSqli: Date = new Date();
  dateSortieSqli: Date = new Date();
  dateDebutStage: Date = new Date();
  diplomes: string = '';

  note: string = '';
  phonePersonnel: string = '';
  phoneProfesionnel: string = '';
  autreTechnos: string = '';
  typeContrat: string = '';
  niveauName: string = ''; // TODO: To be Changed ==> the API doesn't return this value at all and it should be an ID
  site: string = '';
  skillCenter: string = '';
  emailPersonnel: string = '';
  email: string = '';
  competencePrincipale: string = '';
  adresse: string = '';
  technos: string = '';
  certifications: string = '';
  langues: string = '';
  poste: string = '';
  nationnalite: string = '';
  lieuNaissance: string = '';
  numCin: string = '';
  files: string = '';
  situationFamiliale: string = '';
  hadAlreadyWorkedAtSQLI: boolean = false;
}
