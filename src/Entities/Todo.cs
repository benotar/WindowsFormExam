using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormExam.Entities;

public class Todo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("created_date")]
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    [Column("ending_date")]
    public DateTime EndingDate { get; set;}

    public override string ToString()
    {
        return $"{Id}. {Title} - {Description}.";
    }

    public static bool operator ==(Todo a, Todo b)
    {
        return (a.Title == b.Title) && (a.Description == b.Description) &&
            (a.EndingDate.Year == b.EndingDate.Year
            && a.EndingDate.Month == b.EndingDate.Month
            && a.EndingDate.Day == b.EndingDate.Day
            && a.EndingDate.Hour == b.EndingDate.Hour
            && a.EndingDate.Minute == b.EndingDate.Minute
            && a.EndingDate.Second == b.EndingDate.Second);
    }

    public static bool operator !=(Todo a, Todo b)
    {
        return (a.Title != b.Title) || (a.Description != b.Description) || (a.EndingDate.Year != b.EndingDate.Year
            || a.EndingDate.Month != b.EndingDate.Month
            || a.EndingDate.Day != b.EndingDate.Day
            || a.EndingDate.Hour != b.EndingDate.Hour
            || a.EndingDate.Minute != b.EndingDate.Minute
            || a.EndingDate.Second != b.EndingDate.Second);
    }

    public Todo Clone()
    {
        return new Todo { Title = this.Title, Description = this.Description, CreatedDate = this.CreatedDate, EndingDate = this.EndingDate };
    }
}
