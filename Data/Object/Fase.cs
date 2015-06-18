using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Object
{
    public class Fase {

		public int idFase{ get; set; }
		
		[Required(ErrorMessage="Informe uma descrição para a Fase",AllowEmptyStrings=false)]
		[StringLength(20, ErrorMessage="Limite de 20 caractéres.")]
		public string descricao{ get; set; }
		
		public bool ativo { get; set; }
	}
}