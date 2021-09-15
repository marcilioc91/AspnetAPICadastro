using System;
using System.Collections.Generic;
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
        public string email { get; set; }
        public DateTime data_do_cadastro { get; set; }
    }
}