using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author/Random
        public ActionResult Random()
        {
            var author = new Author() { Id = 1, Name = "Frank Arteaga" };
            //return View(author);
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = "1", orderBy = "size" });
            return File("E:\\java.png", "application/png", "p.png");
        }

        // GET: Author/List
        public ActionResult List()
        {
            var authors = new List<Author>();
            for (int i = 0 ; i < 10 ; i++)
                authors.Add(new Author(i, "Frank" + i));
//            ViewBag.Authors = authors;
            return View(authors);
        }

        public ActionResult Index(int? page, string orderBy)
        {
            if (!page.HasValue)
                page = 1;
            if (orderBy.IsNullOrWhiteSpace())
                orderBy = "Name";

            return Content($"page={page}, orderBy={orderBy}");
        }

        public string ByContryAndFName(string country, char? fName)
        {
            return (country + " " + fName);
        }
    }
}