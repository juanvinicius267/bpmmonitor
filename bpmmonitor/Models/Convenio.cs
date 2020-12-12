using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Convenio
    {
        [Key]
        public int IdConvenio { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
        public string Categoria { get; set; }
        public string Modalidade { get; set; }
        public string TipoDeContrato { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
