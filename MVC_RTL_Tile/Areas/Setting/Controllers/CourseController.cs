using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class CourseController : Controller
    {
        // GET: Setting/Course
        public ActionResult Index()
        {


            return View();
        }

        public ActionResult _Index()
        {
            var lst = Course.GetCoursList();

            return PartialView("_Index", lst);
        }


        public ActionResult Create(int? id)
        {

            if (string.IsNullOrEmpty(id.ToString()))
            {
                var model = new tblCours();
                return View(model);
            }
            else
            {
                var master = Course.GetUserByID(int.Parse(id.ToString()));
                return View(master);
            }

        }
        [HttpPost]
        public ActionResult SaveRecord(tblCours model)
        {

            bool mode = false;
            mode = Course.isUSER_Exist(model.ID);
            bool vno = false;
            if (mode)
            {
               
                Course.UpdateCours(model);
            }
            else
            {
               

                vno = Course.AddCours(model);
            }


            return Json(new { msg = "success", vno = vno }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update(int ID, bool IsActive)
        {
            Course.UpdateStaus(ID, IsActive);

            return Json(new { msg = "success" });
        }



    }
}