using Beltzac.Arquiteto.Modelos;
using Refit;
using System.Threading.Tasks;

namespace Beltzac.Arquiteto.Infraestrutura.Externo
{
    public interface IArquitetoAPI
    {
        [Get("/Configuracao/")]
        public Task<Configuracao> GetConfiguracao();

        [Post("/Configuracao/")]
        public Task SetConfiguracao(Configuracao configuracao);

        [Get("/RetaPilares?tamanho={tamanhoReta}")]
        public Task<RetaPilares> CalcularRetaPilares(double tamanhoReta);
    }
}
