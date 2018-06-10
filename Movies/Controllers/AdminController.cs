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

        //Them theloai
        [HttpGet]
        public PartialViewResult TheLoaiPartial()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult TheLoaiPartial(theloai tl)
        {
            //Thêm vào cơ sở dữ liệu
            if (ModelState.IsValid)
            {
                db.theloais.Add(tl);
                db.SaveChanges();
            }

            return PartialView();
        }

        //GET ThemTL
        public ViewResult ThemTL()
        {
            return View();
        }

    }
}