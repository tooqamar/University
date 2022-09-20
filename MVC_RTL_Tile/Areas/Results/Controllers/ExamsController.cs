using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Results.Controllers
{
    public class ExamsController : Controller
    {
        // GET: Results/Exams
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Index()
        {
            var lst = Lib.BLL.Results.GetSubjectList();

            return PartialView("_Index", lst);
        }

        [HttpPost]
        public JsonResult Create(tbl_Student_Subject_Grade model)
        {

           
            Lib.BLL.Results.AddSubject(model);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult Update(tbl_Student_Subject_Grade model)
        {
          
            Lib.BLL.Results.UpdateSubject(model);

            return Json(new { msg = "success" });
        }


    }
}