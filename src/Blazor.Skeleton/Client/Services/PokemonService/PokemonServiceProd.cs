using Blazor.Skeleton.Models;
using System.Net.Http.Json;

namespace Blazor.Skeleton.Client.Services.PokemonService
{
    public class PokemonServiceProd : IPokemonService
    {
        private HttpClient _httpClient;

        public PokemonServiceProd(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Pokemon> Pokemons { get; set; }

        public Pokemon Pokemon { get; set; }

        public async Task GetAllPokemons()
        {
            Pokemons = await _httpClient.GetFromJsonAsync<List<Pokemon>>("/api/Pokemons/GetAll");
        }

        public async Task GetPokemon(int id)
        {
            Pokemon =  await _httpClient.GetFromJsonAsync<Pokemon>($"/api/Pokemons/GetById/{id}");
        }
    }
}
