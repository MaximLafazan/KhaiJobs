using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhaiJobs.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JobSearch()
        {
            return View();
        }
        public ActionResult ResumeSearch()
        {
            return View();
        }
        public ActionResult ViewJobPosting()
        {
            return View();
        }
        public ActionResult ViewResume()
        {
            return View();
        }
        public ActionResult ViewProfile()
        {
            return View();
        }
    }
}