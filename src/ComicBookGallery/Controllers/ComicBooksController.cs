using ComicBookGallery.Models;
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

            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue! Witness the final hour</p>",
                Artists = new Artists[]
                {
                    new Artists () {Name = "Dan Slott", Role = "Script" },
                    new Artists () {Name = "Huberto Ramos", Role = "Pencils" },
                    new Artists () {Name = "Abebe Kebede", Role = "Inks" },
                    new Artists () {Name = "Ayele Mulatu", Role = "Colors" },
                    new Artists () {Name = "Almaz Mulatu", Role = "Letters" },

                }



            };
                
                


     

            return View(comicBook);
           

        }

        
    }
}