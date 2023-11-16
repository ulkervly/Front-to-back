using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       

      
        public IActionResult Index()
        {
            List<Feature> features = GetFeatures();
            List<Blog> blogs = GetBlogs();
            HomeViewModel homevm = new HomeViewModel()
            {
                Features = features,
                Blogs = blogs
            }
            return View(homevm);
        }
        public List<Feature>GetFeatures()
        {
            return new List<Feature>
            {
                new Feature{Id=1,Name="F1",Description="D1"},
                new Feature{Id=2,Name="F2",Description="D2"},
                new Feature{Id=3,Name="F3",Description="D3"}

            };
        }
        public List<Blog> GetBlogs()
        {
            return new List<Blog>
            { 
                new Blog{Id=1,AuthorName="A1",Description="D1",Title="T1"},
                new Blog{Id=2,AuthorName="A2",Description="D2",Title = "T2"},
                new Blog{Id=3,AuthorName="A3",Description="D3", Title = "T3"}

            };
        }
    }
}
