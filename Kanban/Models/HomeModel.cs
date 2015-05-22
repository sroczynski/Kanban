using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class HomeModel
    {
        public static List<Projeto> Index()
        {
            List<Projeto> response = new List<Projeto>();
            using (var db = new KANBANEntities())
            {
                response = db.projeto.Select(x => new Projeto() { id = x.id, titulo = x.titulo, descricao = x.descricao }).ToList();
            }
            return response;
        }
    }
}