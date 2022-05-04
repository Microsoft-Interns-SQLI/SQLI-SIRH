using API_MySIRH.Interfaces;

namespace API_MySIRH.Entities
{
    public class Site : EntityBase, IStringName
    {
        public string Name { get; set; } = String.Empty;
    }
}