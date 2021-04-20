using System;
using TecnicalAssistence.Domain.Emuns;
using TecnicalAssistence.Domain.Model;

namespace TecnicalAssistence.Api.Dto
{
    public class TecnicalAssistence
    {
        public DateTime ActualStart { get; set; }
        
        public DateTime EstimatedEnd { get; set; }
        
        public DateTime ActualEnd { get; set; }
        
        public TipoAtividade TipoAtividade { get; set;  }

        public Assunto Assunto { get; set; }
        
        public Empreendimento Empreendimento { get; set; }
    
        public Bloco Bloco { get; set; }
        
        public Unidade Unidade { get; set; }

    }
}
