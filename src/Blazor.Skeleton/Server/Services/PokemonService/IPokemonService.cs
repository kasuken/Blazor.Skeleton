namespace Blazor.Skeleton.Server.Services.PokemonService
{
    public interface IPokemonService
    {
        Task<Pokemon> GetPokemon(int id);

        Task<List<Pokemon>> GetAll();
    }
}
