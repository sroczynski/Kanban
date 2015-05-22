using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Permissao
    {
        public int id { get; set; }

        [Required(ErrorMessage="Informe a Permissão.")]
        public string titulo { get; set; }
    }
}
