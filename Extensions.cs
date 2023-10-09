using MyBlog.Dtos;
using MyBlog.Models;

namespace MyBlog
{
    public static class Extensions
    {
        public static PostDto AsDto(this Post post)
        {
            return new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                DateCreated = post.DateCreated,
                DateModified = post.DateModified
            };
        }
    }
}