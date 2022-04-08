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

    }
}
