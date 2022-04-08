namespace API_MySIRH.Interfaces
{
    public interface IUploadService
    {
        Task<ICollection<string>> UploadFile(IFormFileCollection files);
    }
}