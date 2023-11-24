using Lab03_TL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_TL.Controllers
{
    public class HTMLController : Controller
    {
        // GET: HTML
        public ActionResult FormRegister()
        {
            ViewBag.listWork = new List<Work>() {
                new Work() {ID = "0" ,Name="--Chọn Công Việc--"},
                new Work() {ID = "1" ,Name="Đơn vị Nhà nước"},
                new Work() {ID = "2" ,Name="Dơn vị tư nhân"},
                new Work() {ID = "3" ,Name="Làm việc tại gia"},
                new Work() {ID = "4" ,Name="Thất nghiệp"},
            };
            return View();
            
        }
        public ActionResult Register() {

            string fvr = "";
            TempData["TDVT"] = Request["txtTDVT"];
            TempData["Work"] = Request["Work"];
            TempData["SLNV"] = Request["txtSLNV"];
            TempData["DiaChi"] = Request["txtDiaChi"];
            TempData["NgLH"] = Request["txtNgLH"];
            TempData["SDT"] = Request["txtSDT"];
            TempData["SFax"] = Request["txtSFax"];
            TempData["Email"] = Request["txtEmail"];
            TempData["DCWebSite"] = Request["txtWebSite"];
            TempData["TDN"] = Request["txtTDN"];
            TempData["MK"] = Request["txtMK"];
            TempData["XNMK"] = Request["txtXNMK"];
           
            return View(); 

        }
    }
}