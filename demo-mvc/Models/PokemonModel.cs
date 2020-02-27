using System.Linq;
using demo_mvc.Helpers;
using System.Collections.Generic;
namespace demo_mvc.Models
{
    public class PokemonModel
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public static List<PokemonModel> Filter(string name)
        {
            return Storage.Instance.pokemonList.Where(x => x.Name == name).ToList();
        }

        public bool Save()
        {
            try
            {
                Storage.Instance.pokemonList.Add(this);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update()
        {
            return false;
        }

        public bool Delete()
        {
            return false;
        }
    }
}
