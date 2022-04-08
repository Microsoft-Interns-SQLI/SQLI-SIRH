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

            fileStream.Close();
            

            foreach (IWorksheet worksheet in workbook.Worksheets)
            {
                for(int i = 1; i < worksheet.Rows.Count(); i++)
                {

                    var nomComplet = worksheet.Rows[i].Cells[3].Value.Split(' ');

                    var Nom = nomComplet[1];

                    var Prenom = nomComplet[0];

                    if(nomComplet.Length>2)
                        Nom += $"{string.Join(" ", nomComplet.Skip(2))}";

                    Collaborateur collaborateur = new Collaborateur();
                    collaborateur.Matricule = worksheet.Rows[i].Cells[0].Value.ToString();
                    collaborateur.Nom = Nom;
                    collaborateur.Prenom = Prenom;
                    collaborateur.Email = worksheet.Rows[i].Cells[2].Value.ToString();
                    collaborateur.Civilite = worksheet.Rows[i].Cells[5].Value.ToString();
                    collaborateur.Diplomes = worksheet.Rows[i].Cells[16].Value.ToString();
                    collaborateur.ModeRecrutement = worksheet.Rows[i].Cells[11].Value.ToString();

                    if (worksheet.Rows[i].Cells[6].Value != "")
                        collaborateur.DateNaissance = Convert.ToDateTime(worksheet.Rows[i].Cells[6].Value);
                    if(worksheet.Rows[i].Cells[12].Value !="")
                        collaborateur.DatePremiereExperience = Convert.ToDateTime(worksheet.Rows[i].Cells[12].Value);
                    if(worksheet.Rows[i].Cells[13].Value != "")
                        collaborateur.DateEntreeSqli = Convert.ToDateTime(worksheet.Rows[i].Cells[13].Value);
                    if(worksheet.Rows[i].Cells[14].Value != "")
                        collaborateur.DateDebutStage = Convert.ToDateTime(worksheet.Rows[i].Cells[14].Value);
                    if(worksheet.Rows[i].Cells[15].Value != "")
                        collaborateur.DateSortieSqli = Convert.ToDateTime(worksheet.Rows[i].Cells[15].Value);

                    
                    list.Add(collaborateur);
                }

            }
            workbook.Close();

            excelEngine.Dispose();

            return list;
        }
    }
}
