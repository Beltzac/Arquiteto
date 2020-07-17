using Beltzac.Arquiteto.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beltzac.Arquiteto.Dominio
{
    public interface IConfiguracaoRepository
    {
        Configuracao GetConfiguracao();
        void SetConfiguracao(Configuracao configuracao);
    }
}
