namespace API_MySIRH.DTOs
{
    public class ImportResult : Dictionary<string,int>
    {
        public ImportResult()
        {
            this.Add("AddingCollab", 0);   
            this.Add("ExistsCollab", 0);

        }
    }
}
