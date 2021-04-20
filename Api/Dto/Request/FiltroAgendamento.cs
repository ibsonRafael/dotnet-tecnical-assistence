using Microsoft.AspNetCore.Mvc;
using TecnicalAssistence.Domain.Emuns;

namespace TecnicalAssistence.Api.Dto.Request
{
    public class FiltroAgendamento
    {
        /// <summary>
        /// Assunto pelo qual deseja-se filtrar as requisições
        /// </summary>
        public int? IdAssunto { get; set; }
        
        /// <summary>
        /// Tipo de atividada a ser realizada
        /// </summary>
        public int? IdTipoAtividade { get; set; }
        
        /// <summary>
        /// Situação atual do atendimento
        /// </summary>
        public int? IdSituacao { get; set; }
        
        /// <summary>
        /// Empreendimento pelo qual deseja-se filtrar os agendamentos
        /// </summary>
        public int? IdEmpreendimento { get; set; }
        
        /// <summary>
        /// Bloco pelo qual deseja-se filtrar os agendamentos
        /// </summary>
        public int? IdBloco { get; set; }
        
        /// <summary>
        /// Unidade pela qual deseja-se filtrar os agendamentos
        /// </summary>
        public int? IdUnidade { get; set; }
        
        /// <summary>
        /// Cliente pelo qual deseja-se filtrar os agendamentos
        /// </summary>
        public int? IdCliente { get; set; }
        
        /// <summary>
        /// Visita técnica pelo qual deseja-se filtrar os agendamentos gerados
        /// </summary>
        public int? IdAgendamentoOrigem { get; set; }


        public bool TemFiltros()
        {
            return this.IdAssunto != null ||
                   this.IdTipoAtividade != null ||
                   this.IdSituacao != null ||
                   this.IdEmpreendimento != null ||
                   this.IdBloco != null ||
                   this.IdUnidade != null ||
                   this.IdCliente != null ||
                   this.IdAgendamentoOrigem != null;
        }
        
        
    }
}