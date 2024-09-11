namespace Library.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}

public enum DataStatus
{
    Inserted,
    Updated,
    Deleted
}