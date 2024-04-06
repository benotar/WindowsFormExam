
using Microsoft.EntityFrameworkCore;
using WindowsFormExam.Entities;

namespace WindowsFormExam.Data;

public class DataContext : DbContext
{
    public DbSet<Todo> ToDoes {  get; set; }

    public DataContext(DbContextOptions<DataContext> options)
        :base(options) { }
}
