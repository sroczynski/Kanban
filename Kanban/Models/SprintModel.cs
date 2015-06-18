using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class SprintModel
    {
        public static List<Sprint> Index()
        {
            List<Sprint> response = new List<Sprint>();
            using (var db = new KANBANEntities())
            {
                response = db.sprints.Select(x => new Sprint() { idSprint = x.id, descricao = x.descricao}).ToList();
            }
            return response;
        }

        public static Result CriarSprint(Sprint request)
        {
            Result response = new Result() { success = true, Message = "Sprint salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.sprints.Add(new Kanban.sprints()
                {
                    descricao = request.descricao,
                    
                    
                });
                db.SaveChanges();
            }

            return response;
        }

        public static SprintRequest EditarSprint(int sprintId)
        {
            SprintRequest response = new SprintRequest();
            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.sprints.Select(x => new SprintRequest() { idSprint = x.id, descricao = x.descricao, newRegister = false }).FirstOrDefault(x => x.idSprint == sprintId);
            }

            return response;
        }

        public static Result EditarSprint(Sprint request)
        {
            Result response = new Result() { success = true, Message = "Sprint Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.sprints editSprint = db.sprints.FirstOrDefault(x => x.id == request.idSprint);
                    editSprint.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da sprint, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result ExcluirSprint(int sprintId)
        {
            Result response = new Result() { success = true, Message = "Sprint Excluída com sucesso." };
            
            using (KANBANEntities db = new KANBANEntities())
            {
                sprints sprintExcluir = db.sprints.FirstOrDefault(x => x.id == sprintId);

                if (sprintExcluir != null)
                {
                    db.sprints.Remove(sprintExcluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da sprint. Contate o suporte técnico.";
                }
            }

            return response;
        }
    }
}