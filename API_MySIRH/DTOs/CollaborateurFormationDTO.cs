﻿namespace API_MySIRH.DTOs
{
    public class CollaborateurFormationDTO
    {
        public string? Status { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int CollaborateurId { get; set; }
        public int FormationId { get; set; }
        public string FormationLibelle { get; set; }
    }

    public class CollaborateurFormationResponse
    {
        public int Annee { get; set; }
        public List<CollaborateurFormationDTO> List { get; set; }
    }
}
