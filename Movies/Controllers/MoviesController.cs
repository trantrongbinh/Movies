using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ViewResult DanhSachTheLoai()
        {
            return View();
        }

        public ViewResult DanhSachQuocGia()
        {
            return View();
        }

        public ViewResult ChiTiet()
        {
            return View();
        }
    }
}