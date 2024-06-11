using BlogApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.ViewModels.BlogViewModel;

public class EditBlogViewModel
{
    public Guid ID { get; set; }
    [Required(ErrorMessage = "Name must not exceed 100 characters")]
    [StringLength(100)]
    public required string Name { get; set; }
    [Required(ErrorMessage = "you did not provide a body")]
    public required string Body { get; set; }
    public Status Status { get; set; }
}
