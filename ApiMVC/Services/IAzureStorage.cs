using Microsoft.AspNetCore.Mvc;

namespace ApiMVC.Services
{
    public interface IAzureStorage
    {

        string Upload(IFormFile file, string fileName);
    }
}
