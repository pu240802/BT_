using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class CustomerController : Controller
    {
        private dynamic listcustomer;

        // GET: Customer
        public ActionResult CustomerDetail()
        {
            Customer cus = new Customer()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Tp.HCM",
                Email = "dung.ta.uit@gmail.com",
                Phone = "0363419330",
                Balance = 15200000
            };
            return View(cus);
        }
        public ActionResult CustomerList()
        {
            List<Customer> listcustomer = new List<Customer>()
            {
                new Customer() {CustomerId = "KH001",FullName ="Trịnh Văn Chung",Address="Tp.Hcm",Email="dungta.uit@gmail.com",Phone="0363419330",Balance=15200000},
                new Customer() {CustomerId = "KH002",FullName ="Nhật Phương",Address="Tp.Quảng Ngãi",Email="nhatphuong02@gmail.com",Phone="0363419330",Balance=17200000},
                new Customer() {CustomerId = "KH003",FullName ="Tấn Phú",Address="Tp.Hà Nội",Email="tanphu@gmail.com",Phone="0334429182",Balance=1700000},
                new Customer() {CustomerId = "KH004",FullName ="Hàn Phong",Address="Tp.Phú Yên",Email="hanphong@gmail.com",Phone="0909609397",Balance=18200000}


            };
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}