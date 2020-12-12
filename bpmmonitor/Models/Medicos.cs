using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Medicos
    {
        [Key]
        public int IdMedicos { get; set; }
        public int IdPessoa { get; set; }
        public Pessoas Pessoa { get; set; }
        public string Especialidade { get; set; }
        public string Atuacao { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
