using Lib.BLL;
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class ManageUserController : Controller
    {
        // GET: Setting/ManageUser
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult _Index()
        {
            var lst = Lib.BLL.User.GetUserList();

            return PartialView("_Index", lst);
        }


        public ActionResult Create(int? id)
        {

            if (string.IsNullOrEmpty(id.ToString()))
            {
                var model = new tblUser();
                return View(model);
            }
            else
            {
                var master = Lib.BLL.User.GetUserByID(int.Parse(id.ToString()));
                return View(master);
            }

        }
        [HttpPost]
        public ActionResult SaveRecord(tblUser model)
        {

            bool mode = false;
            mode = Lib.BLL.User.isUSER_Exist(model.ID);
            bool vno = false;
            if (mode)
            {
                model.dteModified = DateTime.Now;
                Lib.BLL.User.UpdateUser(model);
            }
            else
            {
                model.dteCreated = DateTime.Now;

                vno = Lib.BLL.User.AddUser(model);
            }


            return Json(new { msg = "success", vno = vno }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update(int ID, bool IsActive)
        {
            Lib.BLL.User.UpdateStaus(ID, IsActive);

            return Json(new { msg = "success" });
        }

      

    }
}