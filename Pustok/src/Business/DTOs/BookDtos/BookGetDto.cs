using Pustok.Business.DTOs.AuthorDtos;

namespace Pustok.Business.DTOs.BookDtos;

public record BookGetDto(string Name, string Description, decimal Price, int? DiscountPercent, int PageCount, int StockCount, int Rating, ICollection<AuthorGetDto> Authors);