using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class TarefaModel
    {
        public static List<TarefaIndexView> Index()
        {
            List<TarefaIndexView> response = new List<TarefaIndexView>();
            using (var db = new KANBANEntities())
            {
                response = db.tarefas.Select(x => new TarefaIndexView() { 
                    id = x.id,
                    projeto = x.projeto.titulo,
                    dtCriacao = x.dt_criacao,
                    titulo = "Adicionar Coluna no Banco" // de fato deve ser add a coluna titulo no banco
                }).ToList();
            }
            return response;
        }

        public static TarefaRequest CriarTarefa()
        {
            var response = new TarefaRequest() { newRegister = true };
            
            //using(var db = new KANBANEntities())
            //{
            //    response.sprints = db.sprints.Select(x => new SelectListItem(){ Value = x.id.ToString(), Text = x.descricao}).ToList();
            //}

            return response;
        }

        public static Result CriarTarefa(Tarefa request)
        {
            Result response = new Result() { success = true, Message = "Tarefa Salva com Sucesso." };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.tarefas.Add(new Kanban.tarefas()
                {
                    descricao = request.descricao,
                    dt_criacao = DateTime.Now,
                    id_projeto = request.idProjeto,
                    id_sprints = request.idSprint,
                    id_status = request.idStatus,
                    id_classificacao = request.idClassificacao,
                    id_tipo = request.idTipo,
                    id_tarefa_agrupador = request.idTarefaAgrupador
                });
                db.SaveChanges();
            }
            return response;
        }

        public static TarefaRequest EditarTarefa(int tarefaId)
        {
            TarefaRequest response = new TarefaRequest();
            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.tarefas.Select(x => new TarefaRequest() { 
                    id = x.id, 
                    idProjeto = x.id_projeto,
                    idSprint = x.id_sprints.Value,
                    status = new Status(){ idStatus =  x.id_status.Value, descricao = x.status.descricao},
                    descricao = x.descricao, 
                    newRegister = false }).FirstOrDefault(x => x.id == tarefaId);
            }
            return response;
        }

        public static Result EditarProjeto(Tarefa request)
        {
            Result response = new Result() { success = true, Message = "Tarefa Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.tarefas tarefaEdit = db.tarefas.FirstOrDefault(x => x.id == request.id);
                    tarefaEdit.id_projeto = request.idProjeto;
                    tarefaEdit.descricao = request.descricao;
                    tarefaEdit.id_status = request.status.idStatus;
                    tarefaEdit.id_tipo = request.tipo.idTipo;
                    tarefaEdit.id_sprints = 

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Tarefa, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }




    }
}