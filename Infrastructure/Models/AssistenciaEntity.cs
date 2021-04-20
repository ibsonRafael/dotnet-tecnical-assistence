using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.CompilerServices;

namespace TecnicalAssistence.Infrastructure.Models
{
    
    [Table("ASSISTENCIA")]
    public class AssistenciaEntity
    {
        [Key]
        [Column("ID") ]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        
        [Column("DT_INICIO_PREV")]
        public DateTime dataInicioPrevista { get; set; }
        
        [Column("DT_INICIO_REAL")]
        public DateTime dataInicioRealizada { get; set; }
        
        [Column("DT_FIM_PREV")]
        public DateTime dataFimPrevista { get; set; }
        
        [Column("DT_FIM_REAL")]
        public DateTime dataFimRealizada { get; set; }
        
        [Column("ID_TIPO_ATIVIDADE")]
        public int? IdTipoAtividade { get; set; }
        
        [Column("ID_ASSUNTO")]
        public int? IdAssunto { get; set; }
        
        [Column("ID_UNIDADE")]
        public int? IdUnidade { get; set; }
        
        [Column("ID_BLOCO")]
        public int? IdBloco { get; set; }
        
        [Column("ID_EMPREENDIMENTO")]
        public int?  IdEmpreendimento { get; set; }
        
        [Column("ID_STATUS")]
        public int? IdStatus { get; set; }
        
        [Column("ID_VISITA")]
        public int? IdVisita { get; set; }
        
        [Column("ID_SITUACAO")]
        public int? IdSituacao { get; set; }
        
    }
}