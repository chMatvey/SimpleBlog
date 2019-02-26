using DBRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Threading.Tasks;

namespace SimpleBlog.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        readonly IBlogRepository blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        [Route("page")]
        [HttpGet]
        public async Task<Page<Post>> GetPosts(int pageIndex, string tag)
        {
            return await blogRepository.GetPosts(pageIndex, 10, tag);
        }
    }
}
