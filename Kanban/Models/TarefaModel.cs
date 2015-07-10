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
                response = db.tarefas.Select(x => new TarefaIndexView()
                {
                    id = x.id,
                    projeto = x.projeto.titulo,
                    dtCriacao = x.dt_criacao,
                    titulo = "Adicionar Coluna no Banco" // de fato deve ser add a coluna titulo no banco
                }).ToList();
            }
            return response;
        }

        public static TarefaRequest CriarTarefaView()
        {
            TarefaRequest response = new TarefaRequest();

            using (KANBANEntities db = new KANBANEntities())
            {
                response = new TarefaRequest()
                {
                    Projeto = db.projeto.Select(p => new SelectListItem() { Text = p.titulo, Value = p.id.ToString() }).ToList(),
                    Sprint = db.sprints.Select(sp => new SelectListItem() { Text = sp.descricao, Value = sp.id.ToString() }).ToList(),
                    Status = db.status.Select(st => new SelectListItem() { Text = st.descricao, Value = st.id.ToString() }).ToList(),
                    Classificacao = db.classificacao.Select(cl => new SelectListItem() { Text = cl.descricao, Value = cl.id.ToString() }).ToList(),
                    newRegister = true
                };
            }
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
                response = db.tarefas.Select(x => new TarefaRequest()
                {
                    TarefaId = x.id,
                    Projeto = db.projeto.Select(p => new SelectListItem() { Text = p.titulo, Value = p.id.ToString(), Selected = (p.id == x.id_projeto ? true : false) }).ToList(),
                    Sprint = db.sprints.Select(sp => new SelectListItem() { Text = sp.descricao, Value = sp.id.ToString(), Selected = (sp.id == x.id_sprints ? true : false) }).ToList(),
                    Status = db.status.Select(st => new SelectListItem() { Text = st.descricao, Value = st.id.ToString(), Selected = (st.id == x.id_status ? true : false) }).ToList(),
                    indice = x.indice,
                    Classificacao = db.classificacao.Select(cl => new SelectListItem() { Text = cl.descricao, Value = cl.id.ToString(), Selected = (cl.id == x.id_classificacao ? true : false) }).ToList(),
                    Descricao = x.descricao,
                    TempoEstimado = x.tempo_estimado.Value,
                    TempoTrabalhado = x.tempo_trabalhado.Value,
                    DataCriacao = x.dt_criacao
                }).FirstOrDefault(x => x.TarefaId == tarefaId);
            }
            return response;
        }

        public static Result EditarTarefa(Tarefa request)
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