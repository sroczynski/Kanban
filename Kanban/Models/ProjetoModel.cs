using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class ProjetoModel
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

        public static Result CriarProjeto(Projeto request)
        {
            Result response = new Result() { success = true, Message = "Projeto Salvo com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.projeto.Add(new Kanban.projeto()
                {
                    descricao = request.descricao,
                    titulo = request.titulo
                });
                db.SaveChanges();
            }

            return response;
        }

        public static ProjetoRequest EditarProjeto(int projetoId)
        {
            ProjetoRequest response = new ProjetoRequest();
            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.projeto.Select(x => new ProjetoRequest() { id = x.id, titulo = x.titulo, descricao = x.descricao, newRegister = false }).FirstOrDefault(x => x.id == projetoId);
            }

            return response;
        }

        public static Result EditarProjeto(Projeto request)
        {
            Result response = new Result() { success = true, Message = "Projeto Salvo com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.projeto editProject = db.projeto.FirstOrDefault(x => x.id == request.id);
                    editProject.titulo = request.titulo;
                    editProject.descricao = request.descricao;

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações do projeto, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }




    }
}