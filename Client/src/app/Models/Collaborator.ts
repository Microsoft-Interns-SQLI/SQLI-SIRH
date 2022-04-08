export class Collaborator {
  id: number = 0;
  creationDate: Date = new Date();
  modificationDate: Date = new Date();
  nom: string = "";
  prenom: string = "";
  dateNaissance: Date = new Date();
  matricule: string = "";
  civilite: string = "";
  modeRecrutement: string = "";
  datePremiereExperience: Date = new Date();
  dateEntreeSqli: Date = new Date();
  dateSortieSqli: Date = new Date();
  dateDebutStage: Date = new Date();
  diplomes: string = "";

  emailPerso: string = "";
  emailPro: string = "";
  phonePerso: string = "";
  phonePro: string = "";
  competencePrincipale: string = "";
  adresse: string = "";
  technos: string = "";
  certifications: string = "";
  langues: string = "";
  poste: string = "";
  expertise: string = "";
  nationnalite: string = "";
  lieuNaissance: string = "";
  numCin: string = "";
  situationFamiliale: string = "";
  hadAlreadyWorkedAtSQLI: boolean = false;
}