using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteColmeiaAPI.Models;

namespace TesteColmeiaAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return RedirectToRoute(new { controller = "Empresas", action = "Index" });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SaveEmpresa(string NomeFantasia, string cep, string logradouro, string localidade, string cnpj, string telefone, string bairro, string email, string uf) // MÉTODO CHAMADO PELO FORMULÁRIO
        {

            var db = new Model1(); // INSTANCIANDO O CONTEXTO DO BD

            DateTime today = DateTime.Now;

            //Empresa
            var empresa = new Empresa();
            empresa.nome_fantasia = NomeFantasia;
            empresa.data_do_cadastro = today;
            empresa.cnpj = cnpj;
            empresa.telefone = telefone;
            empresa.email = email;


            db.empresas.Add(empresa);
            db.SaveChanges(); // SALVANDO INFORMAÇÕES NO BD

            var empresaAll = db.empresas.ToList(); // LISTANDO TODOS OS REGISTROS
            ViewBag.empresas = empresaAll; // ADICIONANDO RETORNO PARA A VISUALIZAÇÃO

            return View();

        }
    }
}