using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Hospitais
    {
        [Key]
        public int IdHospitais { get; set; }
        public int IdEndereco { get; set; }
        public Endereco Endeco { get; set; }
        public int LeitosDeinternacao { get; set; }
        public int LeitosCirurgicos { get; set; }
        public int UtiAdulta { get; set; }
        public int UtiInfantil { get; set; }
        public int ProntoSocorro { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public DateTime DataDeGravacao { get; set; }

    }
}
