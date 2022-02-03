using Blazor.Skeleton.Models;

namespace Blazor.Skeleton.Client.Services.PokemonService
{
    public interface IPokemonService
    {
        List<Pokemon> Pokemons { get; set; }

        Pokemon Pokemon { get; set; }

        Task GetPokemon(int id);

        Task GetAllPokemons();

    }
}
