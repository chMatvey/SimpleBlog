using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBRepository.Repositories
{
    public interface IBlogRepository
    {
        Task AddComment(Comment comment);
        Task AddPost(Post post);
        Task DeletePost(int id);
        Task DeleteComment(int id);
        Task<List<string>> GetAllTagNames();
        Task<Post> GetPost(int id);
        Task<Page<Post>> GetPosts(int index, int pageSize, string tag = null);
    }
}
