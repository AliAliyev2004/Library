// See https://aka.ms/new-console-template for more information
using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

Console.WriteLine("Hello, World!");

public class LibrfaryContext : DbContext
{
    public DbSet<StudentBook> StudentBooks { get; set; }
    public DbSet<Student>Students  { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Operation> Operations { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Libdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }

    
}








