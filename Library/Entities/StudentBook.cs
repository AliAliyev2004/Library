﻿namespace Library.Entities;

public class StudentBook
{
    public int StudentBookId { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
