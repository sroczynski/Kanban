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
        public static List<TarefaIndex> Index()
        {
            List<TarefaIndex> response = new List<TarefaIndex>();
            using (var db = new KANBANEntities())
            {
                response = db.tarefas.Select(x => new TarefaIndex()
                {
                    id = x.id,
                    projeto = x.projeto.titulo,
                    dtCriacao = x.dt_criacao,
                    titulo = "Adicionar Coluna no Banco" // de fato deve ser add a coluna titulo no banco
                }).ToList();
            }
            return response;
        }

        /// <summary>
        /// Retorno os dados dos objetos de tela da Tarefa
        /// </summary>
        /// <returns></returns>
        public static TarefaView CriarView()
        {
            TarefaView response = new TarefaView();

            using (KANBANEntities db = new KANBANEntities())
            {
                response = new TarefaView()
                {
                    Sprint = SprintModel.GetSprints(),                    
                    Projeto = ProjetoModel.GetProjetoListItem(),
                    Status = StatusModel.GetStatusListItem(),
                    Classificacao = ClassificacaoModel.GetClassificacaoListItem(),
                    Usuarios = UsuarioModel.GetListItem(),

                    newRegister = true
                };
            }
            return response;
        }

        public static Result Criar(Tarefa request)
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

        public static TarefaView EditarView(int tarefaId)
        {
            TarefaView response = new TarefaView();
            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.tarefas.Select(x => new TarefaView()
                {
                    TarefaId = x.id,
                    Descricao = x.descricao,
                    indice = x.indice,
                    DataCriacao = x.dt_criacao,
                    TempoEstimado = x.tempo_estimado.Value,
                    TempoTrabalhado = x.tempo_trabalhado.Value,

                    Projeto = ProjetoModel.GetProjetoListItem(x.id_projeto),
                    Sprint = SprintModel.GetSprints(x.id_projeto, x.id_sprints),
                    Status = StatusModel.GetStatusListItem(x.id_status),
                    Classificacao = ClassificacaoModel.GetClassificacaoListItem(x.id_classificacao),
                    Tipo = TipoModel.GetListItem(x.id_tipo),
                    Fases = FasesModel.GetListItem(1)
                }).FirstOrDefault(x => x.TarefaId == tarefaId);
            }
            return response;
        }

        public static Result Editar(Tarefa request)
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