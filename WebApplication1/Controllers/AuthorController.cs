using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}