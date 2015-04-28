﻿using Data.Object;
using Kanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Controllers
{
    public class ProjetoController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Index()
        {
            var model = ProjetoModel.Index();
            return View(model);
        }

        public ActionResult Criar()
        {
            return View("ProjetoManager");
        }
        
        [HttpGet]
        public ActionResult Editar(int projetoId)
        {
            ProjetoRequest model = ProjetoModel.EditarProjeto(projetoId);
            return View("ProjetoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Projeto request)
        {
            var response = ProjetoModel.EditarProjeto(request);
            return Json(response);
        }

    }
}