namespace Bespoke.Azure.BlobStorage;

public interface IBlobStorageService
{
    Task UploadBlobAsync(string containerName, string blobName, Stream content);
    Task<Stream> DownloadBlobAsync(string containerName, string blobName);
    Task DeleteBlobAsync(string containerName, string blobName);
    Task<bool> BlobExistsAsync(string containerName, string blobName);
}