using Lotofacil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.Controller
{
    public class EscolheNumeros
    {
        public static IList<int> NumerosPrimos(Random r)
        {
            IList<int> l = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                l.Add(Numeros.Primos[r.Next(0, Numeros.Primos.Count - 1)]);
            }

            return l;
        }

        public static IList<int> NumeroPrimeiro(Random r)
        {
            IList<int> l = new List<int>();
            for (int i = 0; i < 1; i++)
            {
                l.Add(Numeros.Primeiros[r.Next(0, Numeros.Primeiros.Count - 1)]);
            }

            return l;
        }

        public static IList<int> NumeroUltimo(Random r)
        {
            IList<int> l = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                l.Add(Numeros.Ultimos[r.Next(0, Numeros.Ultimos.Count - 1)]);
            }

            return l;
        }

        public static IList<int> NumeroPares(Random r)
        {
            IList<int> l = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                l.Add(Numeros.Pares[r.Next(0, Numeros.Pares.Count - 1)]);
            }

            return l;
        }

        public static IList<int> NumeroImpares(Random r)
        {
            IList<int> l = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                l.Add(Numeros.Impares[r.Next(0, Numeros.Impares.Count - 1)]);
            }

            return l;
        }

        public static IList<int> NumeroTodos(Random r)
        {
            IList<int> l = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                l.Add(Numeros.Todos[r.Next(0, Numeros.Todos.Count - 1)]);
            }

            return l;
        }
    }
}
