using BlogApp.ViewModels.BlogViewModel;

namespace BlogApp.DAL.Contracts;

public interface IAdmin : IBase<BlogViewModel, CreateBlogViewModel, EditBlogViewModel>
{

}
