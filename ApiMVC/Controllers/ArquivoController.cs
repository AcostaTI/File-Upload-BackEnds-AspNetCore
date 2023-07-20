using ApiMVC.Models;
using ApiMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMVC.Controllers;

[ApiController]
[Route("[Controller]")]
public class ArquivoController : ControllerBase
{

    private readonly IAzureStorage _azureStorage;
    private readonly IArquivoService _arquivoService;

    public ArquivoController(IArquivoService arquivoService, IAzureStorage azureStorage)
    {
        _arquivoService = arquivoService;
        _azureStorage = azureStorage;
    }


    [HttpPost]
    public async Task<ActionResult> Post(IFormFile file)
    {

        var extension = Path.GetExtension(file.FileName);

        var fileName = Guid.NewGuid().ToString() + extension;

        var caminho = _azureStorage.Upload(file, fileName);

        var arquivo = new Arquivo()
        {
            Nome = fileName,
            Caminho = caminho
        };
        
        _arquivoService.AddArquivo(arquivo);

        return Ok(file);

    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var arquivos = _arquivoService.ListaArquivo();
        return Ok(arquivos);

    }
}
