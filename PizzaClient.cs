using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace frontend
{
   public class PizzaClient
   {
      private readonly JsonSerializerOptions options = new JsonSerializerOptions()
      {
         PropertyNameCaseInsensitive = true,
         PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      };

      private readonly HttpClient client;
      // private readonly ILogger<PizzaClient> _logger;

      public PizzaClient(HttpClient client, ILogger<PizzaClient> logger)
      {
         this.client = client;
         // this._logger = logger;
      }

      public async Task<PizzaInfo> GetPizzasAsync(string nombre)
      {

            // var responseMessage = await this.client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nombre}");
            // return await this.cliente.GetF
         try {
            var responseMessage = await this.client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nombre}");
            
            if(responseMessage!=null)
            {
               var stream = await responseMessage.Content.ReadAsStreamAsync();
               var result = await JsonSerializer.DeserializeAsync<PizzaInfo>(stream, options);
               // return await JsonSerializer.DeserializeAsync<PizzaInfo[]>(stream, options);
               return result;
            }
         }
         catch(HttpRequestException ex)
         {
            // _logger.LogError(ex.Message);
            throw;
         }
         // return new PizzaInfo[] {};
         return null;

      }
   }
}