using Pustok.Business.DTOs.AuthorDtos;

namespace Pustok.Business.Services.Interfaces;

public interface IAuthorService
{
    Task<List<AuthorGetDto>> GetAllAuthorsAsync(string? search);
    Task<AuthorGetDto> GetAuthorByIdAsync(Guid id);
    Task CreateAuthorAsync(AuthorPostDto authorPostDto);
}