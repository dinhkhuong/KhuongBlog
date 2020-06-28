using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhuongBlog.Models
{
    public interface IArticleRepository
    {
        IQueryable<Article> Articles { get; }
    }
}
