using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {



        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue! Witness the final hour</p>";
            ViewBag.Artists = new string[]
            {
                 "Script: Dan Slott",
                 "Pencils: Huberto Ramos",
                 "Inks: Abebe Kebede",
                 "Colors: Ayele Mulatu",
                 "Letters: Almaz Mulatu"
            };

            return View();
           

        }
    }
}