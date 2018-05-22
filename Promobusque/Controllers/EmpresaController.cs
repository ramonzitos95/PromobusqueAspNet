using Promobusque.Aplicacao;
using Promobusque.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Promobusque.Site
{
    public class EmpresaController : Controller
    {
        private EmpresaAplicacao EmpresaAplicacao;

        public EmpresaController()
        {
            EmpresaAplicacao = new EmpresaAplicacao();
        }

        public ActionResult Index()
        {
            return View(new EmpresaModelo());
        }

        public ActionResult Gravar(EmpresaModelo empresaModelo)
        {
            if (empresaModelo == null)
                throw new Exception("Modelo está nulo!");

            try
            {
                EmpresaAplicacao.Gravar(empresaModelo);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}