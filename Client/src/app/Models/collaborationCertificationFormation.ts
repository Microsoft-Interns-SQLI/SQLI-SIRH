import { Certification } from "./certification";
import { Collaborator } from "./Collaborator";

export interface CollabFormationCertif{
    status:string,
    dateDebut: Date,
    dateFin: Date,
    collaborateurId: number,
    certificationId: number
}