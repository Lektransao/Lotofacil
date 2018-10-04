using Lotofacil.Controller;
using Lotofacil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine(CriaApresentacao.returnString(ResultadoLotofacil.Resultado()));
            Console.WriteLine("========================================================");
            Console.WriteLine(CriaApresentacao.returnString(MontaCartela.MontaBilhete()));
            Console.ReadKey();
        }
    }
}
