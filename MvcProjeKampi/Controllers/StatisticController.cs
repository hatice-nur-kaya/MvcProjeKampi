using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var CategoryCount = c.Categories.Count().ToString();
            ViewBag.q1 = CategoryCount;
            var SoftwareTitleCount = c.Headings.Count(x => x.HeadingName == "Yazılım").ToString();
            ViewBag.q2 = SoftwareTitleCount;
            var Writera = (from x in c.Writers select x.WriterName.IndexOf("a")).Distinct().Count().ToString();
            ViewBag.q3 = Writera;
            var category = c.Categories.Where(u => u.CategoryID == c.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.q4 = category;
            var numericaldifference = c.Categories.Count(x => x.CategoryStatus == true) - c.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.q5 = numericaldifference;
            return View();
        }
    }
}