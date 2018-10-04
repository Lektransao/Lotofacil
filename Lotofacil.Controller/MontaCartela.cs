using Lotofacil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.Controller
{
    public class MontaCartela
    {
        public static Bilhete MontaBilhete()
        {
            int cartela = 16;
            Random r = new Random();
            IList<int> listaPrimos = EscolheNumeros.NumerosPrimos(r);
            IList<int> listaPrimeiros = EscolheNumeros.NumeroPrimeiro(r);
            IList<int> listaUltimos = EscolheNumeros.NumeroUltimo(r);
            IList<int> listaPares = EscolheNumeros.NumeroPares(r);
            IList<int> listaImpares = EscolheNumeros.NumeroImpares(r);
            IList<int> listaTodos = EscolheNumeros.NumeroTodos(r);
            List<int> listaBilhete = new List<int>();

            foreach (var item in listaPrimos)
            {
                if (!listaBilhete.Contains(item) && listaBilhete.Count < cartela)
                {
                    listaBilhete.Add(item);
                }
            }

            foreach (var item in listaPrimeiros )
            {
                if (!listaBilhete.Contains(item) && listaBilhete.Count < cartela)
                {
                    listaBilhete.Add(item);
                }
            }

            foreach (var item in listaUltimos)
            {
                if (!listaBilhete.Contains(item) && listaBilhete.Count < cartela)
                {
                    listaBilhete.Add(item);
                }
            }

            foreach (var item in listaPares)
            {
                if (!listaBilhete.Contains(item) && listaBilhete.Count < cartela)
                {
                    listaBilhete.Add(item);
                }
            }

            foreach (var item in listaImpares)
            {
                if (!listaBilhete.Contains(item) && listaBilhete.Count < cartela)
                {
                    listaBilhete.Add(item);
                }
            }

            foreach (var item in listaTodos)
            {
                if (!listaBilhete.Contains(item) && listaBilhete.Count < cartela)
                {
                    listaBilhete.Add(item);
                }
            }

            listaBilhete.Sort();
            Bilhete bilhete = new Bilhete();
            bilhete.Numeros = listaBilhete;

            return bilhete;
        }
    }
}
