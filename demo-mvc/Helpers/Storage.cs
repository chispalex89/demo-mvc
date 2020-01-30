using demo_mvc.Models;
using System.Collections.Generic;

namespace demo_mvc.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get {
                if (_instance == null) _instance = new Storage();
                return _instance; 
            }
        }

        public List<PokemonModel> pokemonList = new List<PokemonModel>();
        public string Name = "";
    }
}