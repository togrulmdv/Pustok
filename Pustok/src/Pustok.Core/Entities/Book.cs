using Pustok.Core.Entities.Common;

namespace Pustok.Core.Entities;

public class Book : BaseSectionEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int? DiscountPercent { get; set; }
    public int Rating { get; set; }
    public int PageCount { get; set; }
    public int StockCount { get; set; }
    public ICollection<BookAuthor>? BookAuthors { get; set; }
}