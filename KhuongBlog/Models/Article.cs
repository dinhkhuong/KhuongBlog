using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhuongBlog.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
    }
}
