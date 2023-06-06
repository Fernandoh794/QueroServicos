using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Type
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Description { get; set; }
}