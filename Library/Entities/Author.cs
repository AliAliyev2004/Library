namespace Library.Entities;

public class Author:BaseEntity
{
    public int AuthorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Book> Books { get; set; }

}
