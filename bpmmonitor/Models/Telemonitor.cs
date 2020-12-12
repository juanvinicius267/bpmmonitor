using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Telemonitor
    {
        [Key]
        public int IdMedicao { get; set; }
        public int IdPessoa { get; set; }
        public Pessoas Pessoa { get; set; }
        public int Batimentos { get; set; }
        public Double Temperatura { get; set; }
        public Double Pressão { get; set; }
        public string MedicaoDiabete { get; set; }
        public string FrequenciaCardiaca { get; set; }
        public string SaturacaoDeOxigenacao { get; set; }
        public string Situacao { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
