using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KhuongBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KhuongBlog.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleRepository repository;

        public ArticleController(IArticleRepository repo)
        {
            repository = repo;
        }
        // GET: /<controller>/
        public IActionResult Index() => View(repository.Articles);
        public ViewResult post(int ArticleID) => View(repository.Articles);
    }
}
