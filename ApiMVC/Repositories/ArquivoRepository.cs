using API.Repositories;
using ApiMVC.Models;

namespace ApiMVC.Repositories
{
    public class ArquivoRepository : IArquivoRepository
    {
        private readonly AppDBContext _dbContext;

        public ArquivoRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddArquivo(Arquivo arquivo)
        {
            _dbContext.Arquivos.Add(arquivo);
            _dbContext.SaveChanges();
        }

        public List<Arquivo> ListaArquivo()
        {
            return _dbContext.Arquivos.ToList();
        }
    }
}
