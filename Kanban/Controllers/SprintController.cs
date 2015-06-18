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
    public class SprintController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Index()
        {
            return View(SprintModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("SprintManager", new SprintRequest() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Sprint request)
        {
            Result response = SprintModel.CriarSprint(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int sprintId)
        {
            SprintRequest model = SprintModel.EditarSprint(sprintId);
            return View("SprintManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Sprint request)
        {
            var response = SprintModel.EditarSprint(request);
            return Json(response);
        }

        public ActionResult Excluir(int sprintId)
        {
            return Json(SprintModel.ExcluirSprint(sprintId),JsonRequestBehavior.AllowGet);
        }
    }
}
