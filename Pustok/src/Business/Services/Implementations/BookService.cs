using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pustok.Business.DTOs.BookDtos;
using Pustok.Business.Services.Interfaces;
using Pustok.Core.Entities;
using Pustok.DataAccess.Repositories.Interfaces;

namespace Pustok.Business.Services.Implementations;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public BookService(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<List<BookGetDto>> GetAllBooksAsync(string? search)
    {
        var books = await _bookRepository.GetFiltered(b => search != null ? b.Name.Contains(search) : true, "BookAuthors.Author").ToListAsync();
        List<BookGetDto> bookDtos = null;
        try
        {
            bookDtos = _mapper.Map<List<BookGetDto>>(books);
        }
        catch (Exception ex)
        {

            throw;
        }

        return bookDtos;
    }

    public Task<BookGetDto> GetBookByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task CreateBookAsync(BookPostDto bookPostDto)
    {
        Book book = _mapper.Map<Book>(bookPostDto);

        await _bookRepository.CreateAsync(book);
        await _bookRepository.SaveAsync();
    }
}