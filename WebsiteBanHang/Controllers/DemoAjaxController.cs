﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang;

namespace WebSiteBanHang.Controllers
{
    public class DemoAjaxController : Controller
    {
        QuanLyBanHangEntities db =  new QuanLyBanHangEntities();
        // GET: DemoAjax
        public ActionResult DemoAjax()
        {
            return View();
        }
        //Xu ly Action Link
        public  ActionResult LoadAjaxActionLink()
        {
            System.Threading.Thread.Sleep(2000);
            return Content("Hello AJAX");
        }

        public ActionResult LoadAjaxBeginForm(FormCollection f)
        {
            System.Threading.Thread.Sleep(2000);
            string KQ = f["txt1"].ToString();
            return Content(KQ);
        }

        public ActionResult LoadAjaxJQuery(int a, int b)
        {
            System.Threading.Thread.Sleep(2000);
            return Content((a + b).ToString());
        }

        public ActionResult LoadSanPham()
        {
            System.Threading.Thread.Sleep(7000);
            //var listSanPhamLTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);
            //return PartialView(listSanPhamLTM);
            var listSanPham = db.SanPhams;
            return PartialView(listSanPham);
        }
    }
}