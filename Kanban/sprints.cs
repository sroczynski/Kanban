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
    
    public partial class sprints
    {
        public sprints()
        {
            this.sprints1 = new HashSet<sprints>();
            this.sprints11 = new HashSet<sprints>();
            this.tarefas = new HashSet<tarefas>();
            this.tarefas1 = new HashSet<tarefas>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_sprints_dependencia { get; set; }
        public string descricao { get; set; }
        public Nullable<System.DateTime> dt_inicio { get; set; }
        public Nullable<System.DateTime> dt_fim { get; set; }
        public Nullable<bool> ativo { get; set; }
        public Nullable<System.DateTime> dt_finalizacao { get; set; }
    
        public virtual ICollection<sprints> sprints1 { get; set; }
        public virtual sprints sprints2 { get; set; }
        public virtual ICollection<sprints> sprints11 { get; set; }
        public virtual sprints sprints3 { get; set; }
        public virtual ICollection<tarefas> tarefas { get; set; }
        public virtual ICollection<tarefas> tarefas1 { get; set; }
    }
}
