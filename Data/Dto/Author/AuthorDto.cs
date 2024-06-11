using BlogApp.Models;

namespace BlogApp.Dto.Author;
public record class AuthorDto(
         string Name,
         string Bio,
         IEnumerable<Blog>? Blogs
);
