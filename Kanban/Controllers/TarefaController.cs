using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Controllers
{
    public class TarefaController : Controller
    {
        //
        // GET: /Tarefa/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Criar()
        {
            return View("TarefaManager");
        }
        
        public ActionResult Editar()
        {
            return View("TarefaManager");
        }

    }
}
