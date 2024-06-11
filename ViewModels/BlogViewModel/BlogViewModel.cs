using System.ComponentModel;

namespace BlogApp.ViewModels.BlogViewModel;

public class BlogViewModel
{
    public required string Name { get; set; }
    public required string Body { get; set; }
    [DisplayName("Date Published")]
    public DateTime dateTime { get; set; }
    [DisplayName("Written By")]
    public required string AuthorName { get; set; }
}
