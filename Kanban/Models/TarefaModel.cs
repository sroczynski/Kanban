﻿using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
                    dtCriacao = x.dt_criacao.Value,
                    titulo = "Adicionar Coluna no Banco" // de fato deve ser add a coluna titulo no banco
                }).ToList();
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
                    id_projeto = request.projeto,
                    id_sprints = request.sprint,
                    id_status = request.status
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
                    projeto = x.id_projeto.Value,
                    sprint = x.id_sprints.Value,
                    status = x.id_status.Value,
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
                    tarefaEdit.id_projeto = request.projeto;
                    tarefaEdit.descricao = request.descricao;
                    tarefaEdit.id_status = request.status;
                    tarefaEdit.id_tipo = request.tipo;
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