using System.Text.Json.Serialization;
using Arquetipo.Api.Models.Header;
using Arquetipo.Api.Models.Response.Random;

namespace Arquetipo.Api.Models.Response;

// es el objeto return del controller
public class ResponseDataExample : HeaderBase
{
    // data encapsula del response, permite retornar
    // objetos incluyendo listas de objetos.
    [JsonPropertyOrder(10)]
    public ResponseRandom Data { get; set; }
}