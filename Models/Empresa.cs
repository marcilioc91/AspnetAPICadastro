using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteColmeiaAPI.Models
{
    public class Empresa
    {
        public int id { get; set; }
        public string cnpj { get; set; }
        public string nome_fantasia { get; set; }
        public string telefone { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public DateTime data_do_cadastro { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }
    }
}