using API_MySIRH.Interfaces;

namespace API_MySIRH.Entities
{
    public class ReasonDemission : EntityBase, IStringName
    {
        public string Name { get; set; } = string.Empty;
    }
}
