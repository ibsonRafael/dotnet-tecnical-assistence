using System;
using System.Collections.Generic;

namespace TecnicalAssistence.Domain.Model
{
    public class Empreendimento
    {
        public String id { get; set; }
        
        public String nome { get; set; }
        
        public List<Bloco> Blocos { get; set; }
    }
}