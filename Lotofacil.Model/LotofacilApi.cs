using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.Model
{
    public class Acertos15
    {
        public string ganhadores { get; set; }
        public string valor_pago { get; set; }
    }

    public class Acertos14
    {
        public string ganhadores { get; set; }
        public string valor_pago { get; set; }
    }

    public class Acertos13
    {
        public string ganhadores { get; set; }
        public string valor_pago { get; set; }
    }

    public class Acertos12
    {
        public string ganhadores { get; set; }
        public string valor_pago { get; set; }
    }

    public class Acertos11
    {
        public string ganhadores { get; set; }
        public string valor_pago { get; set; }
    }

    public class Premiacao
    {
        public Acertos15 acertos_15 { get; set; }
        public Acertos14 acertos_14 { get; set; }
        public Acertos13 acertos_13 { get; set; }
        public Acertos12 acertos_12 { get; set; }
        public Acertos11 acertos_11 { get; set; }
    }

    public class Concurso
    {
        public string numero { get; set; }
        public string data { get; set; }
        public string cidade { get; set; }
        public string local { get; set; }
        public string valor_acumulado { get; set; }
        public List<string> dezenas { get; set; }
        public Premiacao premiacao { get; set; }
        public string arrecadacao_total { get; set; }
    }

    public class ProximoConcurso
    {
        public string data { get; set; }
        public string valor_estimado { get; set; }
    }

    public class RootObject
    {
        public Concurso concurso { get; set; }
        public ProximoConcurso proximo_concurso { get; set; }
        public string especial_independencia_valor_acumulado { get; set; }
        public string resultado_completo { get; set; }
    }

}
