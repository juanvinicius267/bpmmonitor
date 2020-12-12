using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Atendimentos
    {
        [Key]
        public int IdAtendimentos { get; set; }
        public int IdHospital { get; set; }
        public Hospitais Hospital { get; set; }
        public int IdPaciente { get; set; }
        public Pessoas Paciente { get; set; }
        public int IdStatus { get; set; }
        public Status Status { get; set; }
        public int IdDoenca { get; set; }
        public Doenca Doenca { get; set; }
        public TimeSpan Inicio { get; set; }
        public TimeSpan Fim { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
        public string Comentarios { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
