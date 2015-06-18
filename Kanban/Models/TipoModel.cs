using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class TipoModel
    {
        public static List<Tipo> Index()
        {
            List<Tipo> response = new List<Tipo>();
            using (var db = new KANBANEntities())
            {
                response = db.tipo.Select(x => new Tipo() { idTipo = x.id, descricao = x.descricao}).ToList();
            }
            return response;
        }

        public static Result CriarTipo(Tipo request)
        {
            Result response = new Result() { success = true, Message = "Tipo salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.tipo.Add(new Kanban.tipo()
                {
                    descricao = request.descricao
                });
                db.SaveChanges();
            }

            return response;
        }

        public static TipoRequest EditarTipo(int TipoId)
        {
            TipoRequest response = new TipoRequest();
            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.tipo.Select(x => new TipoRequest() { idTipo = x.id, descricao = x.descricao, newRegister = false }).FirstOrDefault(x => x.idTipo == TipoId);
            }

            return response;
        }

        public static Result EditarTipo(Tipo request)
        {
            Result response = new Result() { success = true, Message = "Tipo Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.tipo editTipo = db.tipo.FirstOrDefault(x => x.id == request.idTipo);
                    editTipo.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Tipo, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result ExcluirTipo(int tipoId)
        {
            Result response = new Result() { success = true, Message = "Tipo Excluída com sucesso." };
            
            using (KANBANEntities db = new KANBANEntities())
            {
                tipo TipoExcluir = db.tipo.FirstOrDefault(x => x.id == tipoId);

                if (TipoExcluir != null)
                {
                    db.tipo.Remove(TipoExcluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da Tipo. Contate o suporte técnico.";
                }
            }

            return response;
        }
    }
}