namespace Library.Entities;

public class Student:BaseEntity
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SchoolNumber { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDay { get; set; }
    public ICollection<StudentBook> StudentBooks { get; set; }
}
