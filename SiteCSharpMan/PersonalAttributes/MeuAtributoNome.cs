using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteCSharpMan.PersonalAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class MeuAtributoNome : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int valor = 0;

            int.TryParse(value.ToString(), out valor);

            if (valor <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format("O campo {0} está errado", name);
        }
    }
}