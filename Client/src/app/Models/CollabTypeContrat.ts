import { BaseMDM, Contrat } from "./MdmModel";

export class CollabTypeContrat extends BaseMDM {
    id: number = 0;
    dateDebut: Date = new Date();
    dateFin: Date = new Date();
    isInSQLI: Boolean = true;
    typeContratId: number = 0;
    typeContrat?: Contrat;
    collaborateurId: number = 0;
}