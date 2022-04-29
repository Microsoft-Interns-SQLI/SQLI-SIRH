using API_MySIRH.Interfaces;

namespace API_MySIRH.Entities
{
    public class Post : EntityBase, IStringName
    {
        public string Name { get; set; } = String.Empty;

    }
}
