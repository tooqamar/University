using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Setting/Subject
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Index()
        {
            var lst = Subject.GetSubjectList();

            return PartialView("_Index", lst);
        }

        [HttpPost]
        public JsonResult Create(tblSubject model)
        {

            model.Created = DateTime.Now;
            Subject.AddSubject(model);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult Update(tblSubject model)
        {
            model.Modified = DateTime.Now;
            Subject.UpdateSubject(model);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult UpdateActive(int ID, bool IsActive)
        {
            Subject.UpdateStaus(ID, IsActive);

            return Json(new { msg = "success" });
        }


    }
}