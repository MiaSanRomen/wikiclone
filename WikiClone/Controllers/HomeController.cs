using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WikiClone.Models;

namespace WikiClone.Controllers
{
    public class HomeController : Controller
    {
        ArticleContext db;
        public HomeController(ArticleContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Articles.ToList());
        }
    }
}
