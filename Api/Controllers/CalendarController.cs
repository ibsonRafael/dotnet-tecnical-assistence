

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TecnicalAssistence.Domain.Emuns;
using TecnicalAssistence.Infrastructure.Models;
using TecnicalAssistence.Infrastructure.Repository;

namespace TecnicalAssistence.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/tecnical-assistence")]
    public class CalendarController
    {

        private readonly ILogger<CalendarController> _logger;
        private readonly CalendarRepository _calendarRepository;

        
        public CalendarController(ILogger<CalendarController> logger)
        {
            _logger = logger;
            _calendarRepository = new CalendarRepository();
        }
        
        
        

        /// <summary>
        /// Lista todas as datas disponíveis para realizar um agendamento com base no IdAssunto selecionado, ou IdTipoAtividade
        /// imposta pela IdAssunto passada, visando extender a longo prazo as capacidades e assuntos tratados sem a
        /// necessidade de refatoração.
        /// </summary>
        /// <param name="assunto">Tipo de IdAssunto para o qual busca-se a data de atendimento</param>
        /// <returns>Listagem de datas disponíveis</returns>
        [HttpGet]
        [Route("datas/{IdAssunto}")]
        public List<DataAssistenciaEntity> ListaDatasDisponiveisAtendimento([FromRoute] Assunto assunto)
        {
            
            return (List<DataAssistenciaEntity>) _calendarRepository.Listar();
        }
        
        
        
        /// <summary>
        /// Lista todos os horários disponíveis para realizar um agendamente com base no IdAssunto e data selecionados,
        /// ou IdTipoAtividade imposta pela IdAssunto passada, visando extender a longo prazo as capacidades e assuntos tratados
        /// sem a necessidade de refatoração.
        /// </summary>
        /// <param name="assunto">Tipo de IdAssunto para o qual busca-se a data de atendimento</param>
        /// <param name="data">Data para qual deseja-se lista o horário.</param>
        /// <returns>Listagem de data e horários dispoíveis</returns>
        [HttpGet]
        [Route("datas/{data}/{IdAssunto}/")]
        public List<DataAssistenciaEntity> ListaDatasDisponiveisAtendimento([FromRoute] Assunto assunto, [FromRoute] String data)
        {
            return (List<DataAssistenciaEntity>) _calendarRepository.ListarHoratios(data);
        }
    }
}