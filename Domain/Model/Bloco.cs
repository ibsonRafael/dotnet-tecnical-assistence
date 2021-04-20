using System;
using System.Collections.Generic;

namespace TecnicalAssistence.Domain.Model
{
    public class Bloco
    {
        public String id { get; set; } 
        
        public String numero { get; set; }
        
        public List<Unidade> Unidades { get; set; }
    }
}