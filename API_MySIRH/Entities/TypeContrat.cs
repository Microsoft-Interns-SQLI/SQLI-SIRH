using API_MySIRH.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.Entities
{
    public class TypeContrat : EntityBase, IStringName
    {
        public string Name { get; set; }
    }
}
