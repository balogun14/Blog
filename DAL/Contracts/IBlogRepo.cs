using BlogApp.Dto.Author;
using BlogApp.ViewModels.BlogViewModel;

namespace BlogApp.DAL.Contracts;

public interface IBlogRepo
{
Task<IEnumerable<BlogViewModel>>? GetBlog();
// get all blogs
Task<BlogViewModel?> GetBlog(Guid id);
}
