using Blazor.Skeleton.Server.Data;

namespace Blazor.Skeleton.Server.Services.PokemonService
{
    public class PokemonServiceProd : IPokemonService
    {
        private readonly DataContext _dataContext;

        public PokemonServiceProd(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Pokemon>> GetAll()
        {
            var pokemons = await _dataContext.Pokemons.ToListAsync();

            return pokemons;
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
            var pokemon = await _dataContext.Pokemons.SingleOrDefaultAsync(p => p.Id == id);

            return pokemon;
        }
    }
}
