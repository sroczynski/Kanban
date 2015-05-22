using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Status
    {
        public int id { get; set; }

        [Required(ErrorMessage="Descreva o status.")]
        public string descricao { get; set; }
    }
}
