using System;

namespace frontend
{
    public class PizzaInfo
    {
        public string Name {get; set; }
        public string Imagen => $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/{Id}.png";
        public int Id {get; set;}
        // public string PizzaName { get; set; }

        // public int Cost { get; set; }

        // public string Ingredients { get; set; }

        // public string InStock { get; set; }
    }
}