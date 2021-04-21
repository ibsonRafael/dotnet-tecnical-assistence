using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TecnicalAssistence.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/empreendimento")]
    public class EmpreendimentoController
    {
        private readonly ILogger<EmpreendimentoController> _logger;
        
        
        public EmpreendimentoController(ILogger<EmpreendimentoController> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// Lista todos os empreendimentos disponíveis no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public String ListaEmpreendimento()
        {
            return null;
        }
        
        /// <summary>
        /// Lista os blocos existentes em um determinado empreendimento com base no identificado único do
        /// empreendimento.
        /// </summary>
        /// <param name="idEmpreendimento"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idEmpreendimento}/blocos")]
        public String ListaBlocos(String idEmpreendimento)
        {
            return null;
        }
        
        /// <summary>
        /// Lista as unidades existentes em um determinado bloco com base no identificado único do bloco e do
        /// empreendimento.
        /// </summary>
        /// <param name="idEmpreendimento"></param>
        /// <param name="idBloco"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idEmpreendimento}/blocos/{idBloco}")]
        public String ListaUnidadesBlocos(String idEmpreendimento, String idBloco)
        {
            return null;
        }
        
        
        
        /// <summary>
        /// Lista todas as unidades de um determinado cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("findByClient")]
        public String ListaUnidadePorCliente(String idCliente)
        {
            return null;
        }
    }
}