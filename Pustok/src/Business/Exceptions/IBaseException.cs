using System.Net;

namespace Pustok.Business.Exceptions;

public interface IBaseException
{
    HttpStatusCode StatusCode { get; }
    string ErrorMessage { get; }
}