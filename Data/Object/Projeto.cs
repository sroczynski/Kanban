using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Projeto
    {
        public int id { get; set; }

        [Required(ErrorMessage="Informe o Nome do Projeto.",AllowEmptyStrings=false)]
        [StringLength(50,ErrorMessage="Nome do Projeto deve ter menos de 50 Letras.")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "Descreva brevemente o Projeto, para que todos tenham conhecimento de sua finalidade.", AllowEmptyStrings = false)]
        [StringLength(500, ErrorMessage = "Limite 250 caracteres... Não reclame o Twitter tem só 140.")]
        public string descricao { get; set; }

        public List<Usuario> listUsuario { get; set; }
        public List<Tarefa> listTarefa { get; set; }
    }

    public class ProjetoView : Projeto {
        public bool newRegister { get; set; }    
    }

    public class ProjetoRequest : Projeto { }

    public class ProjetoIndex
    {
        public List<Projeto> Projetos { get; set; }
    }

}
