using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnicalAssistence.Infrastructure.Models
{
    public class DataAssistenciaEntity
    {
        [Column("DT_DISPONIVEL")]
        public String dataDisponivel { get; set; }
    }
}