using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnicalAssistence.Infrastructure.Models
{
    public class HorarioAssistenciaEntity
    {
        [Column("DT_DISPONIVEL")]
        public String dataDisponivel { get; set; }
        
        [Column("HR_DISPONIVEL")]
        public String horarioDisponivel { get; set; }
    }
}