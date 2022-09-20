using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class StudentController : Controller
    {
        // GET: Setting/Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Index()
        {
            var lst = Student.GetStudentList();

            return PartialView("_Index", lst);
        }

        [HttpPost]
        public JsonResult Create(tbl_Student model)
        {


            Student.AddStudent(model);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult Update(tbl_Student model)
        {
            Student.UpdateStudent(model);

            return Json(new { msg = "success" });
        }

        //[HttpPost]
        //public JsonResult Delete(int ID)
        //{
        //    Student.(ID);
        //    return Json(new { msg = "success" });
        //}
    }
}