using ApiMVC.Models;

namespace ApiMVC.Repositories
{
    public interface IArquivoRepository
    {
        void AddArquivo(Arquivo arquivo);

        List<Arquivo> ListaArquivo();
    }
}
