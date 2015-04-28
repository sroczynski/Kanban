using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Projeto
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
    }

    public class ProjetoRequest : Projeto
    {
        public bool newRegister { get; set; }
    }


    public class ProjetoIndexResponse
    {
        public List<Projeto> projetos { get; set; }
    }

}
