using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies.Models;

namespace Movies.Controllers
{
    public class AdminController : Controller
    {
        QuanLyMovieEntities db = new QuanLyMovieEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TrangChuAdminPartial()
        {
            return PartialView();
        }

        //GET theloai
        public ViewResult TheLoai()
        {
            return View(db.theloais.ToList());
        }

        //GET ThemTL
        public ViewResult ThemTL()
        {
            return View();
        }
    }
}