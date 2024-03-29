﻿namespace API_MySIRH.DTOs
{
    public class DemissionDTO : DtoBase
    {
        public DateTime? DateSortieSqli { get; set; } // cas exception
        public DateTime? DateDemission { get; set; }
        public int? ReasonDemissionId { get; set; }
        public ReasonDemissionDTO? ReasonDemission { get; set; } // Not needed for now !!
        public string? Comment { get; set; }
        public bool IsCanceled { get; set; } = false;
        public int CollaborateurId { get; set; }
    }
}
