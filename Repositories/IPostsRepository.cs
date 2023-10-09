using MyBlog.Models;

namespace MyBlog.Repositories
{
    public interface IPostsRepository
    {
        Post GetPost(Guid id);
        IEnumerable<Post> GetPosts();
    }
}