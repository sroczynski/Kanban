using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class StatusModel
    {
        public static List<Status> Index()
        {
            List<Status> response = new List<Status>();
            using (var db = new KANBANEntities())
            {
                response = db.status.Select(x => new Status() { idStatus = x.id, descricao = x.descricao}).ToList();
            }
            return response;
        }

        public static Result CriarStatus(Status request)
        {
            Result response = new Result() { success = true, Message = "Status salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.status.Add(new Kanban.status()
                {
                    descricao = request.descricao
                });
                db.SaveChanges();
            }

            return response;
        }

        public static StatusRequest EditarStatus(int statusId)
        {
            StatusRequest response = new StatusRequest();
            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.status.Select(x => new StatusRequest() { idStatus = x.id, descricao = x.descricao, newRegister = false }).FirstOrDefault(x => x.idStatus == statusId);
            }

            return response;
        }

        public static Result EditarStatus(Status request)
        {
            Result response = new Result() { success = true, Message = "Status Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.status editStatus = db.status.FirstOrDefault(x => x.id == request.idStatus);
                    editStatus.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Status, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result ExcluirStatus(int statusId)
        {
            Result response = new Result() { success = true, Message = "Status Excluída com sucesso." };
            
            using (KANBANEntities db = new KANBANEntities())
            {
                status StatusExcluir = db.status.FirstOrDefault(x => x.id == statusId);

                if (StatusExcluir != null)
                {
                    db.status.Remove(StatusExcluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da Status. Contate o suporte técnico.";
                }
            }

            return response;
        }
    }
}