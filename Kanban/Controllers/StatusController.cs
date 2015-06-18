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
    public class StatusController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Index()
        {
            return View(StatusModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("StatusManager", new StatusRequest() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Status request)
        {
            Result response = StatusModel.CriarStatus(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int StatusId)
        {
            StatusRequest model = StatusModel.EditarStatus(StatusId);
            return View("StatusManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Status request)
        {
            var response = StatusModel.EditarStatus(request);
            return Json(response);
        }

        public ActionResult Excluir(int StatusId)
        {
            return Json(StatusModel.ExcluirStatus(StatusId),JsonRequestBehavior.AllowGet);
        }
    }
}
