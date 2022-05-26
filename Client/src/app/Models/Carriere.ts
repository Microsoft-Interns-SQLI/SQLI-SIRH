import { Collaborator } from "./Collaborator";
import { BaseMDM, Niveau, Poste } from "./MdmModel";

export class Carriere extends BaseMDM {
    id: number = 0;
    collaborateurId?: number = 0;
    collaborateur?: Collaborator;
    niveauId?: number = 0;
    niveau?: Niveau;
    posteId?: number = 0;
    poste?: Poste;
    profilDeCout?: string = "";
    salaireNet?: number = 0;
    variableNet?: number = 0;
    salaireBrut?: number = 0;
    variableBrut?: number = 0;
    tlrh?: string = "";
    annee: number = 0;
}