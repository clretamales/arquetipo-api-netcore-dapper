using Arquetipo.Api.Models.Response;
using Arquetipo.Api.Models.Response.Random;

namespace Arquetipo.Api.Handlers;

public class HandlerRandom : IHandlerRandom
{
    private readonly ILogger<HandlerRandom> _logger;
    public HandlerRandom(ILogger<HandlerRandom> logger)
    {
        _logger = logger;
    }

    public async Task<ResponseDataExample> GeDataRandomDammy()
    {
        _logger.LogInformation("Ejecucion Handler Random GeDataRandomDammy");

        var response = new ResponseDataExample{ Data = new ResponseRandom() };
        var dataRandom = new ResponseRandom{
                                DatosPersonales = new PersonaRandom(),
                                SegurosAsociados = new List<SeguroRandom>()
                            };

        dataRandom.DatosPersonales = MapperHandlerRandom.GetPersonaRandom();
        dataRandom.SegurosAsociados = MapperHandlerRandom.GetSegurosRandomList();
        response.Data = dataRandom;

        await Task.Delay(1000);

        return response;
    }

}