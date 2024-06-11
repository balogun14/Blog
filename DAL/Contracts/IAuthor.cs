using BlogApp.Dto.Author;

namespace BlogApp.DAL.Contracts;
public interface IAuthor : IBase<AuthorDto, CreateAuthorDto, EditAuthorDto>
{

}
