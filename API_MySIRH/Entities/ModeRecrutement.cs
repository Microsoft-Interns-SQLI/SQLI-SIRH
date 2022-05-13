using API_MySIRH.Interfaces;

namespace API_MySIRH.Entities
{
    public class ModeRecrutement : EntityBase, IStringName
    {
        public string Name { get; set; } = "Autre";
    }
}