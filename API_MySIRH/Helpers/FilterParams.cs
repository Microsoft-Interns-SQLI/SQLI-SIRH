namespace API_MySIRH.Helpers
{
    public class FilterParams
    {
        private const int MaxPageSize = 50;
        public int pageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int pageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string Search { get; set; } = String.Empty;
        public string Site { get; set; } = String.Empty;
        public string OrderBy { get; set; } = "nom_asc";

        public List<int> postesId { get; set; } = new List<int>();
        public List<int> niveauxId { get; set; } = new List<int>();

        public string OrderByCertification { get; set; } =String.Empty;
        public string OrderByFormation { get; set; } =String.Empty;

        public int Year { get; set; } = DateTime.Now.Year;

    }
}