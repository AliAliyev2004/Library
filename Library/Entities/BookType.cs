namespace Library.Entities;

public class BookType:BaseEntity
{
    public int BookTypeID { get; set; }
    public string BookTypeName { get; set; }
    public ICollection<Book> Books { get; set; }

}