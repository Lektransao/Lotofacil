using Lotofacil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.Controller
{
    public class CriaApresentacao
    {
        public static String returnString (Bilhete bilhete)
        {
            String resultado = String.Empty;

            foreach (var item in bilhete.Numeros)
            {
                resultado += String.Format(" {0} ", item);
            }

            return resultado;
        }
    }
}
