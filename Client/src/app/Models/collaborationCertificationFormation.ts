import { CertificationOrFormation } from "./certification-formation";
import { Collaborator } from "./Collaborator";

export interface CollabFormationCertif{
    status:string,
    dateDebut: Date,
    dateFin: Date,
    collaborateurId: number,
    id: number
}