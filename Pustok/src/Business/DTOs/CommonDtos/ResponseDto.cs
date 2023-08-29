using System.Net;

namespace Pustok.Business.DTOs.CommonDtos;

public record ResponseDto(HttpStatusCode StatusCode, string Message);