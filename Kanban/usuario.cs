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
    
    public partial class usuario
    {
        public usuario()
        {
            this.grupo_usuarios = new HashSet<grupo_usuarios>();
            this.grupo_usuarios1 = new HashSet<grupo_usuarios>();
            this.projeto_x_usuario = new HashSet<projeto_x_usuario>();
            this.projeto_x_usuario1 = new HashSet<projeto_x_usuario>();
            this.tarefa_x_usuario = new HashSet<tarefa_x_usuario>();
            this.tarefa_x_usuario1 = new HashSet<tarefa_x_usuario>();
            this.tarefas = new HashSet<tarefas>();
            this.tarefas1 = new HashSet<tarefas>();
            this.usuario_x_grupos_usuario = new HashSet<usuario_x_grupos_usuario>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_avatar { get; set; }
        public string nome_usuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
    
        public virtual avatar avatar { get; set; }
        public virtual avatar avatar1 { get; set; }
        public virtual ICollection<grupo_usuarios> grupo_usuarios { get; set; }
        public virtual ICollection<grupo_usuarios> grupo_usuarios1 { get; set; }
        public virtual ICollection<projeto_x_usuario> projeto_x_usuario { get; set; }
        public virtual ICollection<projeto_x_usuario> projeto_x_usuario1 { get; set; }
        public virtual ICollection<tarefa_x_usuario> tarefa_x_usuario { get; set; }
        public virtual ICollection<tarefa_x_usuario> tarefa_x_usuario1 { get; set; }
        public virtual ICollection<tarefas> tarefas { get; set; }
        public virtual ICollection<tarefas> tarefas1 { get; set; }
        public virtual ICollection<usuario_x_grupos_usuario> usuario_x_grupos_usuario { get; set; }
    }
}
