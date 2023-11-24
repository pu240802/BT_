using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationLab2_ex3.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult ShowMusic()
        {
            return View();
        }
        public ActionResult DetailsMusic()
        {
            return View();
        }
    }
}