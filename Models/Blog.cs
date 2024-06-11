using BlogApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models;

public class Blog
{
    [Key]
    public Guid ID { get; set; }
    [Required]
    [StringLength(100)]
    public required string Name { get; set; }
    [Required]
    public required string Body { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
    public Status Status { get; set; }
    public Guid AuthorId { get; set; }

    public Author Author { get; set; }
}
