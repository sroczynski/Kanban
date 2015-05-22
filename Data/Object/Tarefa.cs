using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Tarefa
    {
        public int id { get; set; }

        [Required]
        public int idSprint { get; set; }

        [Required]
        public int idProjeto { get; set; }
        
        [StringLength(500, ErrorMessage="Limite de 500 caractéres.")]
        [Required]
        public string descricao { get; set; }

        [Required]
        public int idStatus { get; set; }

        public int idGrupoUsuariosFases { get; set; }

        public int indice { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan tempoEstimado { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan tempoTrabalhado { get; set; }

        [Required]
        public int idTipo { get; set; }

        public int idClassificacao { get; set; }
        
        public int tarefaPlanejada { get; set; }

        public int idTarefaDependencia { get; set; }

        public DateTime dtCriacao { get; set; }

        public int idTarefaAgrupador { get; set; }
    }

    public class TarefaRequest : Tarefa
    {
        public bool newRegister { get; set; }
    }

    public class TarefaIndexView
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime dtCriacao  { get; set; }
        public string projeto { get; set; }
    }
}
