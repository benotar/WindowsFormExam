
using Microsoft.EntityFrameworkCore;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Data;

public class DataContext : DbContext
{
    public DbSet<Todo> ToDoes {  get; set; }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>().HasData(
            new Todo
            {
                Id = 1,
                Title = "Win Forms Exam",
                Description = "Pass an exam",
                EndingDate = new DateTime(2024, 4, 13, 9, 0, 0)
            },
            new Todo
            {
                Id = 2,
                Title = "Test Todo",
                Description = "Just testing todo)",
                EndingDate = new DateTime(2024, 4, 6, 22, 30, 0)
            });
    }
}
