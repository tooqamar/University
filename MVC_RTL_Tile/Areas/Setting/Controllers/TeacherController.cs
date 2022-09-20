﻿using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Setting/Teacher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Index()
        {
            var lst = Teacher.GetTeacherList();

            return PartialView("_Index", lst);
        }

        [HttpPost]
        public JsonResult Create(tblTeacher model)
        {


            Teacher.AddTeacher(model);

            return Json(new { msg = "success" });
        }

        [HttpPost]
        public JsonResult Update(tblTeacher model)
        {
            Teacher.UpdateTeacher(model);

            return Json(new { msg = "success" });
        }

        //[HttpPost]
        //public JsonResult Delete(int ID)
        //{
        //    Teacher.(ID);
        //    return Json(new { msg = "success" });
        //}
    }
}