using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object {
	
	public clas Sprint {
		
		public int idSprint{ get; set; }
		
		[Required(ErrorMessage="Informe uma descrição para o Sprint",AllowEmptyStrings=false)]
		[StringLength(50, ErrorMessage="Limite de 50 caractéres.")]
		public string descricao{ get; set; }
		
		public Sprint idSprintDependencia;
		
		[DataType(DataType.Time)]
        public TimeSpan dtInicio { get; set; }
		
		[DataType(DataType.Time)]
        public TimeSpan dtFim { get; set; }
		
		
		public List<Tarefa> tarefa { get; set; }
	}
}