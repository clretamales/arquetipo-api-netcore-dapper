using Arquetipo.Api.Models.Response;

namespace Arquetipo.Api.Handlers;

public interface IHandlerRandom
{
    Task<ResponseDataExample> GeDataRandomDammy();
}