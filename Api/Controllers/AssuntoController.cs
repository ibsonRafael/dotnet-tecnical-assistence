using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TecnicalAssistence.Api.Controllers
{
    
    [ApiController]
    [Route("/api/v1/agendamento/assuntos")]
    public class AssuntoController
    {
        
        
        private readonly ILogger<AssuntoController> _logger;
        
        public AssuntoController(ILogger<AssuntoController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Lista todos os tipos de assuntos que estão habilitados para serem solicitados pelo cliente como por exemplo
        /// Agendamento de Vistoria de Unidades, Pedidos de assistência técnica, Agendamento de visita de Obra, etc.
        /// Assim como está pronto para futuras expanções. 
        /// </summary>
        /// 
        /// <returns>Listagem de Assuntos habilitados</returns>
        [HttpGet]
        public String ListaAssuntos()
        {
            return null;
        }
        
    }
}