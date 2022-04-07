using API_MySIRH.Entities;
using Syncfusion.XlsIO;

namespace API_MySIRH.Helpers
{
    public static class ImportFeatures
    {
        public static async Task UploadFileLocaly(IFormFile file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Archives", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }

        public static IEnumerable<Collaborateur> ConvertToList(IFormFile file)
        {
            var list = new List<Collaborateur>();

            ExcelEngine excelEngine = new ExcelEngine();

            //Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Archives", file.FileName);

            FileStream fileStream = new FileStream(path, FileMode.Open);

            IWorkbook workbook = application.Workbooks.Open(fileStream);

            foreach (IWorksheet worksheet in workbook.Worksheets)
            {
                for(int i = 1; i <= worksheet.Rows.Count(); i++)
                {
                    var nomComplet = worksheet.Rows[i].Cells[3].Value.Split(' ');

                    var Nom = nomComplet[0];

                    var Prenom = nomComplet[1];

                    if(nomComplet.Length>2)
                        Nom += $"{string.Join(" ", nomComplet.Skip(2))}";

                    var collaborator = new Collaborateur
                    {
                        Matricule= worksheet.Rows[i].Cells[0].Value,
                        Nom = Nom,
                        Prenom = Prenom,
                        //Site
                        Civilite = worksheet.Rows[i].Cells[5].Value,
                        DateNaissance = Convert.ToDateTime(worksheet.Rows[i].Cells[6].Value),
                        //SkillCenter
                        //Poste
                        //Niveau
                        //Type de contrat
                        ModeRecrutement = worksheet.Rows[i].Cells[11].Value,

                        DatePremiereExperience = 
                            worksheet.Rows[i].Cells[12].Value.Length!=0 ?
                            Convert.ToDateTime(worksheet.Rows[i].Cells[12].Value) :
                            null,
                        DateEntreeSqli = Convert.ToDateTime(worksheet.Rows[i].Cells[13].Value),
                        DateDebutStage =
                            worksheet.Rows[i].Cells[14].Value.Length != 0 ?
                            Convert.ToDateTime(worksheet.Rows[i].Cells[14].Value) :
                            null,
                        DateSortieSqli =
                            worksheet.Rows[i].Cells[15].Value.Length != 0 ?
                            Convert.ToDateTime(worksheet.Rows[i].Cells[14].Value) :
                            null,
                        Diplomes = worksheet.Rows[i].Cells[16].Value
                        //Responsable Skill Center
                    };
                    list.Add(collaborator);
                }

            }

            return list;
        }
    }
}
