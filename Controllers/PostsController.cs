using Microsoft.AspNetCore.Mvc;
using MyBlog.Repositories;
using MyBlog.Models;
using MyBlog.Dtos;

namespace MyBlog.Controllers
{

    

    [ApiController]
    [Route("[controller]")]
    public class PostsController: ControllerBase
    {
        private readonly IPostsRepository repository;

        public PostsController(IPostsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPosts()
        {
            var posts = repository.GetPosts().Select(post => post.AsDto());
            return posts;
        }

        [HttpGet("{id}")]
        public ActionResult<PostDto> GetPost(Guid id)
        {
            var post = repository.GetPost(id);
            if (post is null)
            {
                return NotFound();
            }
            return Ok(post.AsDto());
        }
    }

}
