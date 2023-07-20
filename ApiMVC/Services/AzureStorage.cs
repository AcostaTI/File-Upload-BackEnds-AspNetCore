using Azure.Storage.Blobs;
using System.Reflection.Metadata;
using static System.Reflection.Metadata.BlobBuilder;

namespace ApiMVC.Services;

public class AzureStorage : IAzureStorage
{
    private readonly string _storageConnectionString;
    private readonly string _storageContainerName;
    public AzureStorage(IConfiguration configuration)
    {
        _storageConnectionString = configuration.GetValue<string>("BlobConnectionString");
        _storageContainerName = configuration.GetValue<string>("BlobContainerName");
    }

    
    public  string Upload(IFormFile file, string fileName)
    {
        BlobContainerClient container = new BlobContainerClient(_storageConnectionString, _storageContainerName);
        BlobClient client = container.GetBlobClient(fileName);

        using (Stream? data = file.OpenReadStream())
        {
    
            client.Upload(data);
        }

        return client.Uri.AbsoluteUri;
    }
}
