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
    
    public partial class permissao
    {
        public permissao()
        {
            this.grupo_usuario_x_permissao = new HashSet<grupo_usuario_x_permissao>();
            this.grupo_usuario_x_permissao1 = new HashSet<grupo_usuario_x_permissao>();
        }
    
        public int id { get; set; }
        public string titulo { get; set; }
    
        public virtual ICollection<grupo_usuario_x_permissao> grupo_usuario_x_permissao { get; set; }
        public virtual ICollection<grupo_usuario_x_permissao> grupo_usuario_x_permissao1 { get; set; }
    }
}
