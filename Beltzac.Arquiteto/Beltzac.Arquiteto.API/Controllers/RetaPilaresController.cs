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
    public class RetaPilaresController : ControllerBase
    {
        private readonly ILogger<RetaPilaresController> _logger;
        private readonly IRetaPilaresFactory _retaPilaresFactory;

        public RetaPilaresController(ILogger<RetaPilaresController> logger, IRetaPilaresFactory retaPilaresFactory)
        {
            _logger = logger;
            _retaPilaresFactory = retaPilaresFactory;
        }

        [HttpGet]
        public RetaPilares Get(double tamanho)
        {
            return _retaPilaresFactory.Gerar(tamanho);
        }
    }
}
