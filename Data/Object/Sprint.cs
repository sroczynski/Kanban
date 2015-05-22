using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Sprint
    {
        public int id { get; set; }

        public int idDependencia { get; set; }

        public string descricao { get; set; }

        public DateTime dt_inicio { get; set; }

        public DateTime dt_fim { get; set; }
    }
}
