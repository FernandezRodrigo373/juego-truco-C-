using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class Validadora
    {

        public static bool ValidarCadena(string cadena)
        {
            Regex validadoAux = new Regex("^[a-zA-Z0-9]*$");

            if (validadoAux.IsMatch(cadena))
            {
                return true;
            }

            return false;
        }
    }
}
