//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kanban
{
    using System;
    using System.Collections.Generic;
    
    public partial class tarefas
    {
        public tarefas()
        {
            this.tarefa_x_comentario = new HashSet<tarefa_x_comentario>();
            this.tarefa_x_comentario1 = new HashSet<tarefa_x_comentario>();
            this.tarefa_x_usuario = new HashSet<tarefa_x_usuario>();
            this.tarefas1 = new HashSet<tarefas>();
            this.tarefas11 = new HashSet<tarefas>();
            this.tarefas12 = new HashSet<tarefas>();
            this.tarefas13 = new HashSet<tarefas>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_sprints { get; set; }
        public Nullable<int> id_projeto { get; set; }
        public string descricao { get; set; }
        public Nullable<int> id_status { get; set; }
        public Nullable<int> id_grupo_usuarios_x_fases { get; set; }
        public Nullable<int> indice { get; set; }
        public Nullable<int> id_usuario_creator { get; set; }
        public Nullable<System.TimeSpan> tempo_estimado { get; set; }
        public Nullable<System.TimeSpan> tempo_trabalhado { get; set; }
        public Nullable<int> id_tipo { get; set; }
        public Nullable<int> id_classificacao { get; set; }
        public Nullable<bool> tarefa_planejada { get; set; }
        public Nullable<int> id_tarefa_dependencia { get; set; }
        public Nullable<System.DateTime> dt_criacao { get; set; }
        public Nullable<int> id_tarefa_agrupador { get; set; }
    
        public virtual classificacao classificacao { get; set; }
        public virtual classificacao classificacao1 { get; set; }
        public virtual grupo_usuarios_x_fases grupo_usuarios_x_fases { get; set; }
        public virtual grupo_usuarios_x_fases grupo_usuarios_x_fases1 { get; set; }
        public virtual projeto projeto { get; set; }
        public virtual projeto projeto1 { get; set; }
        public virtual sprints sprints { get; set; }
        public virtual sprints sprints1 { get; set; }
        public virtual status status { get; set; }
        public virtual status status1 { get; set; }
        public virtual ICollection<tarefa_x_comentario> tarefa_x_comentario { get; set; }
        public virtual ICollection<tarefa_x_comentario> tarefa_x_comentario1 { get; set; }
        public virtual ICollection<tarefa_x_usuario> tarefa_x_usuario { get; set; }
        public virtual ICollection<tarefas> tarefas1 { get; set; }
        public virtual tarefas tarefas2 { get; set; }
        public virtual ICollection<tarefas> tarefas11 { get; set; }
        public virtual tarefas tarefas3 { get; set; }
        public virtual ICollection<tarefas> tarefas12 { get; set; }
        public virtual tarefas tarefas4 { get; set; }
        public virtual ICollection<tarefas> tarefas13 { get; set; }
        public virtual tarefas tarefas5 { get; set; }
        public virtual tipo tipo { get; set; }
        public virtual tipo tipo1 { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}
