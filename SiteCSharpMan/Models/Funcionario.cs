using SiteCSharpMan.PersonalAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCSharpMan.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [MeuAtributoNome]
        public int Idade { get; set; }
    }
}