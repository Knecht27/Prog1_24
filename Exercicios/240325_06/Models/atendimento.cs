using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_06.Models
{
    public class atendimento
    {
        public int Id { get; set ;}
        public DateTime DtAtendimento { get; set ;}
        public animal Animal { get; set ;}
        public veterinario Veterinario { get; set ;}
        public string Observacao { get; set ;}
        
    }
}