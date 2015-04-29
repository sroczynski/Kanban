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
        public int sprint { get; set; }

        [Required]
        public int projeto { get; set; }
        
        [StringLength(500, ErrorMessage="Limite de 500 caractéres.")]
        [Required]
        public string descricao { get; set; }

        [Required]
        public int status { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan tempoEstimado { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan tempoTrabalhado { get; set; }

        [Required]
        public int tipo { get; set; }

        
        public int classificacao { get; set; }
        
        public int tarefaPlanejada { get; set; }

        public DateTime dataCriacao { get; set; }
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
