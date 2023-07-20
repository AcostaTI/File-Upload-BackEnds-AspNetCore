using ApiMVC.Models;
using ApiMVC.Repositories;

namespace ApiMVC.Services
{

    public class ArquivoService : IArquivoService
    {
        private readonly IArquivoRepository _arquivoRepository;
        public ArquivoService(IArquivoRepository arquivoRepository) {
            _arquivoRepository = arquivoRepository;
        }
        public void AddArquivo(Arquivo file)
        {

            _arquivoRepository.AddArquivo(file);   
        }

        public List<Arquivo> ListaArquivo()
        {

            var arquivos = _arquivoRepository.ListaArquivo();
            
            if(arquivos == null ) 
                arquivos = new List<Arquivo> { new Arquivo() { } };


            return arquivos;
        }
    }
}
