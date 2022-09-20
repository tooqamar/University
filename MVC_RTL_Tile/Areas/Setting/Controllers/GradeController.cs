using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class GradeController : Controller
    {
        // GET: Setting/Grade
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Index()
        {
            var lst = Grades.List();

            return PartialView("_Index", lst);
        }

        [HttpPost]
        public JsonResult Create(tblGrade model)
        {


            Grades.CreateNew(model);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult Update(int ID, string name)
        {
            Grades.Update(ID, name);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult Delete(int ID)
        {
            Grades.Delete(ID);
            return Json(new { msg = "success" });
        }
    }
}