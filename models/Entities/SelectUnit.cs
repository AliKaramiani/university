
using System.ComponentModel.DataAnnotations;

public class SelectUnit
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }

    [Required]
    public string CourseName { get; set; }


    [Required]
    [MaxLength(6), MinLength(6)]
    public int StudentCode { get; set; }


}