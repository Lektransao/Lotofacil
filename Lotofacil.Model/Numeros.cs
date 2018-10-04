using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.Model
{
    public class Numeros
    {
        public static IList<int> Primos = new List<int>()
        {
            2, 3, 5, 7, 11, 13, 17, 19, 23
        };

        public static IList<int> Primeiros = new List<int>()
        {
            1, 2, 3, 4
        };

        public static IList<int> Ultimos = new List<int>()
        {
            22, 23, 24, 25
        };

        public static IList<int> Pares = new List<int>()
        {
            2, 4, 6, 8, 10,
            12, 14, 16, 18, 20,
            22, 24 
        };

        public static IList<int> Impares = new List<int>()
        {
            1, 3, 5, 7, 9,
            11, 13, 15, 17, 19,
            21, 23, 25
        };

        public static IList<int> Todos = new List<int>()
        {
            1, 2, 3, 4, 5,
            6, 7, 8, 9, 10,
            11, 12, 13, 14, 15,
            16, 17, 18, 19, 20,
            21, 22, 23, 24, 25
        };
    }
}
