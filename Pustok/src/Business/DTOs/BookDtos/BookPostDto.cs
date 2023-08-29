namespace Pustok.Business.DTOs.BookDtos;

public record BookPostDto(string Name, string Description, decimal Price, int? DiscountPercent, int PageCount, int StockCount, int Rating, ICollection<Guid> AuthorIds);