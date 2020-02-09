using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QLbanhangEntities db = new QLbanhangEntities();
        public ActionResult Index()
        {
            // Cách 1:
            //var lstKH = from KH in db.KhachHangs select KH;
            // Cách 2:
            var lstKH = db.KhachHangs;
            return View(lstKH);
        }
        public ActionResult Index1()
        {
            var lstKH = db.KhachHangs;
            return View(lstKH);
        }
        public ActionResult TruyVan1DoiTuong()
        {
            //Cach1: Cau truy van
            //var lstKH = from KH in db.KhachHangs where KH.MaKH == 2  select KH;
            //KhachHang khang = new KhachHang();
            //khang = lstKH.FirstOrDefault();
            //Cach 2: Phuong thuc ho tro
            //KhachHang khang1 = db.KhachHangs.Single(n => n.MaKH == 1);
            KhachHang khang = db.KhachHangs.SingleOrDefault(n => n.MaKH == 2);
            return View(khang);
        }
        public ActionResult SortDuLieu()
        {
            //Phương thức sắp xếp dữ liệu
            List<KhachHang> lstKh = db.KhachHangs.OrderByDescending(n => n.TenKH).ToList();
            return View(lstKh);
        }
        public ActionResult GroupDuLieu()
        {
            //Phân loại dữ liệu
            List<ThanhVien> lstTV = new List<ThanhVien>();
            lstTV = db.ThanhViens.OrderByDescending(n => n.TaiKhoan).ToList();
            return View(lstTV);
        }
    }
}