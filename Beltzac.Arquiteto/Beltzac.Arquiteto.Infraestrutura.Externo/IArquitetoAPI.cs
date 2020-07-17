using Beltzac.Arquiteto.Modelos;
using Refit;
using System.Threading.Tasks;

namespace Beltzac.Arquiteto.Infraestrutura.Externo
{
    public interface IArquitetoAPI
    {
        [Get("/configuracao/")]
        public Task<Configuracao> GetConfiguracao();
        [Post("/configuracao/")]
        public Task GetConfiguracao(Configuracao configuracao);
        [Get("/reta-pilares?tamanho={tamanhoReta}")]
        public Task<RetaPilares> CalcularRetaPilares(double tamanhoReta);
    }
}
