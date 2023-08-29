using Pustok.Core.Entities.Common;

namespace Pustok.Core.Entities;

public class BookAuthor : BaseEntity
{
    public Guid BookId { get; set; }
    public Book Book { get; set; }
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
}