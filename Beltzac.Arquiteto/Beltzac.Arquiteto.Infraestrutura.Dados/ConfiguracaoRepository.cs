using Beltzac.Arquiteto.Dominio;
using Beltzac.Arquiteto.Modelos;
using System;

namespace Beltzac.Arquiteto.Infraestrutura.Dados
{
    public class ConfiguracaoRepository : IConfiguracaoRepository
    {
        public Configuracao GetConfiguracao()
        {
            return new Configuracao
            {
                DistanciaMaximaEntrePilaresMetros = 3,
                DistanciaMaximaParaBaseReforcadaMetros = 10,
                DistanciaTotalMinimaMetros = 5
            };
        }

        public void SetConfiguracao(Configuracao configuracao)
        {
            throw new NotImplementedException();
        }
    }
}
