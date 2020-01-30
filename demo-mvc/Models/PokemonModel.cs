using demo_mvc.Helpers;
namespace demo_mvc.Models
{
    public class PokemonModel
    {
        public int Number { get; set; }
        public string Name { get; set; }

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
    }
}
