using API_MySIRH.Entities;

namespace API_MySIRH.Helpers
{
    public class FilterParamsForCertifAndFormation
    {
        public Status status { get; set; }
        public int annee { get; set; } = DateTime.Now.Year;
    }
}
