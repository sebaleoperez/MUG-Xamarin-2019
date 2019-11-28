using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HolaMundo.Services
{
    public class PlanetaService
    {
        public async Task<List<Planeta>> GetPlanetas()
        {
            HttpClient client = new HttpClient();
            string resultado = await client.GetStringAsync("https://swapi.co/api/planets");
            Resultado resultadoFinal = JsonConvert.DeserializeObject<Resultado>(resultado);

            return resultadoFinal.Results;
        }
    }

    public class Resultado
    {
        public List<Planeta> Results { get; set; }
    }

    public class Planeta
    {
        public string Name { get; set; }
        public string Diameter { get; set; }
    }
}
