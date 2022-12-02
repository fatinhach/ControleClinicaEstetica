using ControleClinicaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace ControleClinicaEstetica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult CadastrarProcedimentos()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CadastrarClientes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AgendarClientes()
        {
            

            return View();
        }
        public ActionResult AgendaDiaria()
        {
            clinicaesteticaEntities db = new clinicaesteticaEntities();
            var result = (from c in db.AgendarCliente
                          select new AgendarClientes
                          {
                              IdAgendamento = c.IdAgendamento,
                              Nome_do_Cliente = c.Nome_do_Cliente,
                              Tipo_de_Procedimento = c.Tipo_de_Procedimento,
                              Data_da_Realizacao = c.Data_da_Realizacao,
                              Valor_do_procedimento = c.Valor_do_procedimento
                          }).ToList();

            return View(result);
        }
        public ActionResult RelatorioMensal()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}