using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class GrupoUsuarios
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public string corGrupo { get; set; }

        public int idUsuarioLider { get; set; }

        public bool ativo { get; set; }
    }
}
