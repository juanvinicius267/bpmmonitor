using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public string Pais { get; set; }
        public string Uf { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
    }
}
