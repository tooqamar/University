using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class ReportController : Controller
    {
        // GET: Setting/Report
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReportOfStudent()
        {
           var lst= Lib.BLL.Student.GetStudentList();
            return View(lst);
        }
    }
}