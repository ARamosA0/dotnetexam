using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components;


namespace frontend.Pages
{
    public class IndexModel : PageModel
    {
        // private string pokemonName = "";
        private readonly ILogger<IndexModel> _logger;
        public PizzaInfo Pizzas { get; set; }

        public string ErrorMessage {get;set;}
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet([FromServices]PizzaClient client)
        {
            Pizzas = await client.GetPizzasAsync("bulbasaur");
            // var pokemon = await client.GetPizzasAsync(PokemonName);
            // if (pokemon != null) {
            //     Pizzas = pokemon;
            // } else {
            //     Pizzas =  await client.GetPizzasAsync(PokemonName);
            // }
            // if(Pizzas.Count()==0)
            //     ErrorMessage="We must be sold out. Try again tomorrow.";
            // else
            //     ErrorMessage = string.Empty;
        }
        
    }
}
