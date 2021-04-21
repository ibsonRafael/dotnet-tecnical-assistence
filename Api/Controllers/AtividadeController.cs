using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TecnicalAssistence.Api.Controllers
{
    
    [ApiController]
    [Route("/api/v1/agendamento/atividades")]
    public class AtividadeController
    {
        
        private readonly ILogger<AtividadeController> _logger;
        
        
        public AtividadeController(ILogger<AtividadeController> logger)
        {
            _logger = logger;
        }
        
        
        /// <summary>
        /// Lista todos os tipos de atividade que estão habilitados para serem solicitados pelo cliente ou
        /// para a visita de manutenção que podem ser de menutenção elétrica, pintura, alvenaria, etc.
        /// Assim como está pronto para futuras expanções. 
        /// </summary>
        /// <returns>Listagem de Atividades disponíveis</returns>
        [HttpGet]
        public String ListaAtividade()
        {
            return null;
        }
        
    }
}