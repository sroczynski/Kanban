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
    
    public partial class grupo_usuarios
    {
        public grupo_usuarios()
        {
            this.grupo_usuario_x_permissao = new HashSet<grupo_usuario_x_permissao>();
            this.grupo_usuario_x_permissao1 = new HashSet<grupo_usuario_x_permissao>();
            this.grupo_usuarios_x_fases = new HashSet<grupo_usuarios_x_fases>();
            this.tarefa_x_usuario = new HashSet<tarefa_x_usuario>();
            this.usuario_x_grupos_usuario = new HashSet<usuario_x_grupos_usuario>();
        }
    
        public int id { get; set; }
        public string descricao { get; set; }
        public string cor_grupo { get; set; }
        public int id_usuario_lider { get; set; }
        public bool ativo { get; set; }
    
        public virtual ICollection<grupo_usuario_x_permissao> grupo_usuario_x_permissao { get; set; }
        public virtual ICollection<grupo_usuario_x_permissao> grupo_usuario_x_permissao1 { get; set; }
        public virtual ICollection<grupo_usuarios_x_fases> grupo_usuarios_x_fases { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
        public virtual ICollection<tarefa_x_usuario> tarefa_x_usuario { get; set; }
        public virtual ICollection<usuario_x_grupos_usuario> usuario_x_grupos_usuario { get; set; }
    }
}
