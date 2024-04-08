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
    public DateTime EndingDate { get; set; }

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

    public string CreatedDateString()
    {
        string result = $"{CreatedDate.Year}.";

        if (CreatedDate.Month < 10)
        {
            result += $"0";
        }
        result += $"{CreatedDate.Month}.";

        if (CreatedDate.Day < 10)
        {
            result += $"0";
        }
        result += $"{CreatedDate.Day}";

        if (CreatedDate.Hour < 10)
        {
            result += $" 0{CreatedDate.Hour}:";
        }
        else
        {
            result += $" {CreatedDate.Hour}:";
        }

        if (CreatedDate.Minute < 10)
        {
            result += $"0";
        }
        result += $"{CreatedDate.Minute}:";


        if (CreatedDate.Second < 10)
        {
            result += $"0";
        }
        result += $"{CreatedDate.Second}";

        return result;
    }

    public string EndingDateString()
    {
        string result = $"{EndingDate.Year}.";

        if (EndingDate.Month < 10)
        {
            result += $"0";
        }
        result += $"{EndingDate.Month}.";

        if (EndingDate.Day < 10)
        {
            result += $"0";
        }
        result += $"{EndingDate.Day}";

        if (EndingDate.Hour < 10)
        {
            result += $" 0{EndingDate.Hour}:";
        }
        else
        {
            result += $" {EndingDate.Hour}:";
        }

        if (EndingDate.Minute < 10)
        {
            result += $"0";
        }
        result += $"{EndingDate.Minute}:";


        if (EndingDate.Second < 10)
        {
            result += $"0";
        }
        result += $"{EndingDate.Second}";

        return result;
    }
}