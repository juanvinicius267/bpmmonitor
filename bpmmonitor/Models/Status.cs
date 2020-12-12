using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Status
    {
        [Key]
        public int IdStatus { get; set; }
        public string Tipo { get; set; }
        public string OndeEsta { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime PrevisaoDeSaida { get; set; }
    }
}
