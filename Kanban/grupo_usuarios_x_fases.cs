//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kanban
{
    using System;
    using System.Collections.Generic;
    
    public partial class grupo_usuarios_x_fases
    {
        public grupo_usuarios_x_fases()
        {
            this.tarefas = new HashSet<tarefas>();
            this.tarefas1 = new HashSet<tarefas>();
        }
    
        public int id { get; set; }
        public int id_grupo_usuarios { get; set; }
        public int id_fases { get; set; }
    
        public virtual fases fases { get; set; }
        public virtual grupo_usuarios grupo_usuarios { get; set; }
        public virtual ICollection<tarefas> tarefas { get; set; }
        public virtual ICollection<tarefas> tarefas1 { get; set; }
    }
}
