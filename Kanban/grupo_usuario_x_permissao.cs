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
    
    public partial class grupo_usuario_x_permissao
    {
        public int id { get; set; }
        public Nullable<int> id_permissao { get; set; }
        public Nullable<int> id_grupo_usuario { get; set; }
    
        public virtual grupo_usuarios grupo_usuarios { get; set; }
        public virtual grupo_usuarios grupo_usuarios1 { get; set; }
        public virtual permissao permissao { get; set; }
        public virtual permissao permissao1 { get; set; }
    }
}