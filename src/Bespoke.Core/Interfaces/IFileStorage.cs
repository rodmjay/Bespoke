namespace Bespoke.Core.Interfaces
{
    public interface IFileStorage
    {
        Task<string> SaveFile(byte[] content, string fileName, string extension, string location);
    }

    public class FileStorageService : IFileStorage
    {
        public async Task<string> SaveFile(byte[] content, string fileName, string extension, string location)
        {
            throw new NotImplementedException();
        }
    }
}
