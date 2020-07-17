using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beltzac.Arquiteto.Dominio;
using Beltzac.Arquiteto.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Beltzac.Arquiteto.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfiguracaoController : ControllerBase
    {
        private readonly ILogger<ConfiguracaoController> _logger;
        private readonly IConfiguracaoRepository _configuracaoRepository;

        public ConfiguracaoController(ILogger<ConfiguracaoController> logger, IConfiguracaoRepository configuracaoRepository)
        {
            _logger = logger;
            _configuracaoRepository = configuracaoRepository;
        }

        [HttpGet]
        public Configuracao Get()
        {
            return _configuracaoRepository.GetConfiguracao();
        }

        [HttpPost]
        public void Post(Configuracao configuracao)
        {
            _configuracaoRepository.SetConfiguracao(configuracao);
        }
    }
}
