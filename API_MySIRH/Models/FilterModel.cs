using Newtonsoft.Json;

namespace API_MySIRH.Models
{
    public class FilterModel : FilterModelBase
    {
        public String Term { get; set; } = String.Empty;

        public override object Clone()
        {
            var jsonString = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject(jsonString, this.GetType());
        }
    }
}