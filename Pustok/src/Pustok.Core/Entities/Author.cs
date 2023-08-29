using Pustok.Core.Entities.Common;

namespace Pustok.Core.Entities;

public class Author : BaseSectionEntity
{
    public string Fullname { get; set; }
    public ICollection<BookAuthor>? BookAuthors { get; set; }
}