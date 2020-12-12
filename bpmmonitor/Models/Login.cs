using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Login
    {
        [Key]
        public int IdLogin { get; set; }
        public int IdPessoa { get; set; }
        public Pessoas Pessoa { get; set; }
        public int NivelDeAcesso { get; set; }
        public string TipoDeAcesso { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }        
        public DateTime DataDeGravacao { get; set; }
    }
}
