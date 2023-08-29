using System.Net;

namespace Pustok.Business.Exceptions.AuthorExceptions;

public sealed class AuthorNotFoundByIdException : Exception, IBaseException
{
    public AuthorNotFoundByIdException(string message) : base(message)
    {
        ErrorMessage = message;
    }

    public HttpStatusCode StatusCode => HttpStatusCode.NotFound;
    public string ErrorMessage { get; }
}