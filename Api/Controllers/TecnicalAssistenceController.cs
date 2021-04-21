using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TecnicalAssistence.Api.Dto.Request;
using TecnicalAssistence.Domain.Emuns;
using TecnicalAssistence.Infrastructure.Models;
using TecnicalAssistence.Infrastructure.Repository;


namespace TecnicalAssistence.Api.Controllers
{
    
    /// <summary>
    /// Controller responsável pelos agentamentos de manutenção, visita, obras etc...
    /// </summary>
    [ApiController]
    [Route("/api/v1/agendamento")]
    public class TecnicalAssistenceController : ControllerBase
    {
        
        private readonly ILogger<TecnicalAssistenceController> _logger;

        private readonly AssistenciaRepository _assistenciaRepository;

        
        
        
        /// <summary>
        /// Construtor da classe controller. Responsável por realizar a configuiração e
        /// injeção do Logger.
        /// </summary>
        /// <param name="logger"></param>
        public TecnicalAssistenceController(ILogger<TecnicalAssistenceController> logger)
        {
            _logger = logger;
            _assistenciaRepository = new AssistenciaRepository();
        }

        
        
        /// <summary>
        /// Lista todos os agendamentos em aberto com possibilidade de aplicar filtragem baseada em IdTipoAtividade, stituação,
        /// IdAssunto e demais atributos da solicitação...
        /// </summary>
        /// <param name="filtros">Filtros para uso na listagem</param>
        /// <returns>Listagem com todos os agendamentos.</returns>
        [HttpGet]
        public List<AssistenciaEntity> ListaAgendamentos([FromQuery] FiltroAgendamento filtros)
        {
            _logger.LogInformation("Listando agendamentos todos os agendamento");
            
            if(filtros.TemFiltros())
                return (List<AssistenciaEntity>) _assistenciaRepository.Listar(filtros);
            
            return (List<AssistenciaEntity>) _assistenciaRepository.Listar();
        }
        
        
        
        /// <summary>
        /// Carrega agendamentos de visita técnica/manutenções agendadas realizads por um cliente específico
        /// </summary>
        /// <param name="idAgendamento">Identificador único do agendamento (GUID)</param>
        /// <param name="filtros">Filtros para uso na listagem</param>
        /// <returns>Lista de Agendamentos do clinte</returns>
        [HttpGet]
        [Route("{idAgendamento}")]
        public List<Dto.TecnicalAssistence> SelecionaAgendamentoAssistenciaPorId(String idAgendamento)
        {
            _logger.LogInformation("Listando agendamentos de cliente");
            return null;
        }
        
        
        
        
        /// <summary>
        /// Atualiza um determinado agendamento permitindo a alteração de alguns atributos, assim como a mudança de
        /// situação.
        /// </summary>
        /// <param name="idAgendamento"></param>
        /// <param name="tecnicalAssistence"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{idAgendamento}")]
        public List<AssistenciaEntity> AtualizaAgendamentoAssistencia(String idAgendamento, [FromBody] AssistenciaEntity tecnicalAssistence)
        {
            _logger.LogInformation("Salvando novo agendamento");
            return null;
        }

        
        
        /// <summary>
        /// Faz o pré-agendamento do horário criando um bloqueio temporário de 5 mintutos para que seja confirmado
        /// do contrário a janele de horário é disponibilizada para seleção novamente.
        /// </summary>
        /// <param name="tecnicalAssistence"></param>
        /// <returns></returns>
        [HttpPost]
        public AssistenciaEntity PreAgendar([FromBody] AssistenciaEntity tecnicalAssistence)
        {
            _logger.LogInformation("Pre-Agendar atendimento e bloquear a janela de horários por 5 minutos");
            tecnicalAssistence = _assistenciaRepository.Inserir(tecnicalAssistence);
            _logger.LogInformation(tecnicalAssistence.ToString());
            return tecnicalAssistence;
        }
        
        
        /// <summary>
        /// Remove um determinado agendamento com base no seu identificador único
        /// </summary>
        /// <param name="idAgendamento"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{idAgendamento}")]
        public List<Dto.TecnicalAssistence> RemoveAgendamentoAssistencia(String idAgendamento)
        {
            _logger.LogInformation("Remove novo agendamento");
            return null;
        }

    }
}
