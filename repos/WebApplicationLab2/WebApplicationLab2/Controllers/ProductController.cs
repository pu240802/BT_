using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Encodings.Web;
using System.Xml.Linq;
using WebApplicationLab2.Models;

namespace WebApplicationLab2.Controllers
{
    public class ProductController : Controller
    {
        public object JsonRequestBehavior { get; private set; }
        public object Server { get; private set; }

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult TestViewResult()
        {
            return View();
        }
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        public EmptyResult TestEmptyReslt()
        {
            return new EmptyResult();
        }
        public RedirectResult TestRedirecResult()
        {
            return Redirect("Index");
        }
        public IActionResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Nguyễn Quang Huy",
                ClassName = "C1311L"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Nguyễn Quang Huy",
                ClassName = "C1311J"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Nguyễn Quang Hiển",
                ClassName = "C1311H"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Nguyễn Duy Huân",
                ClassName = "C1311T"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Vũ Quang Huy",
                ClassName = "C1311C"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Trần Quang Huy",
                ClassName = "C1311L"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Phạm Quang Huy",
                ClassName = "C1311L"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Trịnh Quang Huy",
                ClassName = "C1311B"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Vũ Quang Huy",
                ClassName = "C1311L"
            });

            listStudent.Add(new Student()
            {
                ID = 001,

                Name = "Vũ Minh Trịnh",
                ClassName = "C1311M"
            });
            return new JsonResult(listStudent);
        }

        public IActionResult TestJavaScriptResult()
        {
            string js = @"function checkEmail() {
                        var btloc = /^([w-]+(?:.[w-]+)*)@((?:[w-]+.)*w[w-]{0,66}).([a-z]{2,6}(?:.[a-z]{2})?)$/i;
                        if (btloc.test(mail)) {
                            kq = true;
                        } else {
                            alert('Email address invalid');
                            kq = false;
                        }
                        return kq;
                        }";
            return Content(js, "application/javascript");
        }

        public ContentResult TestContentResult()
        {
            XElement contentXML = new XElement("Student",
                new XElement("Student",
                new XElement("ID", "001"),
                new XElement("FullName", "Nguyễn Viết Nam"),
                new XElement("ClassName", "C1308H")),
                new XElement("Student",
                new XElement("ID", "002"),
                new XElement("FullName", "Nguyễn Hoàng Anh"),
                new XElement("ClassName", "C1411P")),
                new XElement("Student",
                new XElement("ID", "003"),
                new XElement("FullName", "Phạm Ngọc Anh"),
                new XElement("ClassName", "C1411L")),
                new XElement("Student",
                new XElement("ID", "004"),
                new XElement("FullName", "Trần Ngọc Linh"),
                new XElement("ClassName", "C1411H")),
                new XElement("Student",
                new XElement("ID", "005"),
                new XElement("FullName", "Nguyễn Hồng Anh"),
                new XElement("ClassName", "C1411L")));
            return Content(contentXML.ToString(), "text/xml", Encoding.UTF8);
        }

       /* public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes = File.ReadAllBytes(Server.MapPath("~/Content/bell.mp3"));
            string fileName = "bell.mp3";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(fileBytes, "video/mp3", fileName);
        }
        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(new FileStream(pathFile, FileMode.Open), "text/doc", fileName);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(pathFile, "text/doc", fileName);
        }*/
    }
 }
