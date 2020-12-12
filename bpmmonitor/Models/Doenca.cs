using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Doenca
    {
        [Key]
        public int IdDoenca { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public int Periculosidade { get; set; }
        public string Classificacao { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
