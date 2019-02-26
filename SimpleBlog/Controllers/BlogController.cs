using DBRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
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
    }
}
