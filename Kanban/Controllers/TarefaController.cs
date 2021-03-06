﻿using Data.Object;
using Data.Object.Validation;
using Kanban.Models;
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
        // GET: /Projeto/

        public ActionResult Index()
        {
            var model = TarefaModel.Index();
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            TarefaView view = TarefaModel.CriarView();
            return View("TarefaManager", view);
        }

        [HttpPost]
        public ActionResult Criar(Tarefa request)
        {
            Result response = TarefaModel.Criar(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int TarefaId)
        {
            TarefaView model = TarefaModel.EditarView(TarefaId);
            return View("TarefaManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Projeto request)
        {
            //var response = TarefaModel.EditarTarefa(request);
            return Json(new object());
        }
    }
}
