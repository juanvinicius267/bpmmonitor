using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Pessoas
    {
        [Key]
        public int IdPessoa { get; set; }
        public int IdEndereco { get; set; }
        public Endereco EnderecoPessoa { get; set; }
        public int IdDoenca { get; set; }
        public Doenca Doenca { get; set; }
        public int IdConvenio { get; set; }
        public Convenio Convenio { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string Carteirinha { get; set; }
        public DateTime DataDeGravacao { get; set; }
    }
}
