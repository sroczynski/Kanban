using Data.Object;
using Data.Object.Validation;
using Kanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Controllers
{
    public class TipoController : Controller
    {
        //
        // GET: /Tipo/

        public ActionResult Index()
        {
            return View(TipoModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("TipoManager", new TipoRequest() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Tipo request)
        {
            Result response = TipoModel.CriarTipo(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int TipoId)
        {
            TipoRequest model = TipoModel.EditarTipo(TipoId);
            return View("TipoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Tipo request)
        {
            var response = TipoModel.EditarTipo(request);
            return Json(response);
        }

        public ActionResult Excluir(int TipoId)
        {
            return Json(TipoModel.ExcluirTipo(TipoId),JsonRequestBehavior.AllowGet);
        }
    }
}
