using ApiMVC.Models;

namespace ApiMVC.Services
{
    public interface IArquivoService
    {
        void AddArquivo (Arquivo file);
        List<Arquivo> ListaArquivo();
    }
}
