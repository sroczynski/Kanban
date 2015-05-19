using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object {
	
	public clas Comentario {
		
		public int idComentario{ get; set; }
		
		[Required(ErrorMessage="Informe uma descrição para o Comentário",AllowEmptyStrings=false)]
		[StringLength(100, ErrorMessage="Limite de 100 caractéres.")]
		public string descricao{ get; set; }
		
		
        [DataType(DataType.Time)]
        public TimeSpan dtComentario { get; set; }
		
		[StringLength(200, ErrorMessage="Limite de 200 caractéres.")]
		public string anexo{ get; set; }
	}
}