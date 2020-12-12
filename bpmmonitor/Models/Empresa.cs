using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
