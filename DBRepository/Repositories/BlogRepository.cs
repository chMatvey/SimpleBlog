using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using DBRepository.Factories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DBRepository.Repositories
{
    public class BlogRepository : BaseRepository, IBlogRepository
    {
        public BlogRepository(string connectionString, IRepositoryContextFactory contextFactory)
            : base(connectionString, contextFactory) { }

        public Task AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllTagNames()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Page<Post>> GetPosts(int index, int pageSize, string tagName = null)
        {
            var result = new Page<Post> { CurrentPage = index, PageSize = pageSize };
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var query = context.Posts.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tagName))
                {
                    query = query.Where(p => p.Tags.Any(t => t.Name == tagName));
                }
                result.TotalPages = await query.CountAsync();
                result.Records = await query.Include(p => p.Tags).Include(p => p.Comments)
                    .OrderByDescending(p => p.CreateDate).Skip(index * pageSize).Take(pageSize).ToListAsync();
            }
            return result;
        }
    }
}
