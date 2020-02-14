using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult SanPham1()
        {
            //Lấy dữ liệu nạp vào model (dữ liệu là những sản phẩm laptop mới)
            var lstSanPhamTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);
            ViewBag.ListSP = lstSanPhamTM;

            //Lấy dữ liệu nạp vào model (dữ liệu là những sản phẩm điện thoại)
            var lstSanPhamDT = db.SanPhams.Where(n => n.MaLoaiSP == 1);
            ViewBag.ListDT = lstSanPhamDT;
            return View();
        }
        public ActionResult SanPham2()
        {
            //Lấy dữ liệu nạp vào model (dữ liệu là những sản phẩm laptop mới)
            var lstSanPhamTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);
            ViewBag.ListSP = lstSanPhamTM;
            return View();
        }
        [ChildActionOnly]
        public ActionResult SanPhamPartial()
        {
            //Lấy dữ liệu nạp vào model (dữ liệu là những sản phẩm laptop mới)
            //var lstSanPhamTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);
            //return PartialView(lstSanPhamTM);
            return PartialView();
        }
    }
}