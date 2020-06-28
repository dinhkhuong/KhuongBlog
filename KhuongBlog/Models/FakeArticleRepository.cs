using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhuongBlog.Models
{
    public class FakeArticleRepository : IArticleRepository
    {
        public IQueryable<Article> Articles => new List<Article> {
        new Article { ArticleID = 1, Title = "Football", Content = "fafs", Tag ="Java" },
        new Article { ArticleID = 2, Title = "Surf board", Content = "fsdgsh", Tag = "C++" },
        new Article { ArticleID = 3, Title = "Running shoes", Content = "jjhthgcg", Tag = "Linux" }
        }.AsQueryable<Article>();
    }
}
