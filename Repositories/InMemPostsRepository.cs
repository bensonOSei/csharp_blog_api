using MyBlog.Models;

namespace MyBlog.Repositories
{
    public class InMemPostsRepository : IPostsRepository
    {
        private readonly List<Post> posts = new()
        {
            new Post { Id = Guid.NewGuid(), Title = "First Post", Content = "Content of the first post", DateCreated = DateTimeOffset.UtcNow },
            new Post { Id = Guid.NewGuid(), Title = "Second Post", Content = "Content of the second post", DateCreated = DateTimeOffset.UtcNow },
            new Post { Id = Guid.NewGuid(), Title = "Third Post", Content = "Content of the third post", DateCreated = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Post> GetPosts()
        {
            return posts;
        }

        public Post GetPost(Guid id)
        {
            return posts.Where(post => post.Id == id).SingleOrDefault();
        }
    }
}