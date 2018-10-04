using Lotofacil.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lotofacil.Controller
{
    public class ResultadoLotofacil
    {
        public static Bilhete Resultado()
        {
            Bilhete bil = new Bilhete();
            var URI = new Uri("https://confiraloterias.com.br/api/json/?loteria=lotofacil&token=Bq4lqw1m9odXiJ9");

            using (HttpClient request = new HttpClient())
            {
                using (Task<HttpResponseMessage> response = request.GetAsync(URI))
                {
                    if (response.Result.IsSuccessStatusCode)
                    {
                        String jsonString = response.Result.Content.ReadAsStringAsync().Result;
                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(jsonString);
                        IList<int> list = new List<int>();
                        if (obj.concurso != null)
                        {
                            foreach (string dezenas in obj.concurso.dezenas)
                            {
                                list.Add(int.Parse(dezenas));
                            }
                        }
                        bil.Numeros = list;
                        return bil;
                    }
                }
            }

            return bil;
        }
    }
}
