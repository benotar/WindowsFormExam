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

}
