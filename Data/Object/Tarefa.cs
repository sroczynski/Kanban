using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Tarefa
    {
        public int id { get; set; }
        public int sprint { get; set; }
        public int projeto { get; set; }
        public string descricao { get; set; }
        public int status { get; set; }
        public TimeSpan tempoEstimado { get; set; }
        public TimeSpan tempoTrabalhado { get; set; }
        public int tipo { get; set; }
        public int classificacao { get; set; }
        public int tarefaPlanejada { get; set; }
        public DateTime dataCriacao { get; set; }
    }

    public class TarefaResponse : Tarefa {}


}
