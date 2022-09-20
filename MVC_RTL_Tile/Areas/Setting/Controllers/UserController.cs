using Lib.BLL;
using Lib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_RTL_Tile.Areas.Setting.Controllers
{
    public class UserController : Controller
    {
        // GET: Setting/User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string Password)
        {



            string CompanyNAME = System.Web.Configuration.WebConfigurationManager.AppSettings["Company_Name"].ToString();
            string address = System.Web.Configuration.WebConfigurationManager.AppSettings["Company_Address"].ToString();
            string phone = System.Web.Configuration.WebConfigurationManager.AppSettings["Company_phone"].ToString();
            string body, subject, emailsend = "";

            var row = Lib.BLL.User.login(email, Password);

            if (row != null)
              
            {
                body = CompanyNAME + " "+ address;
               
                subject = CompanyNAME;
                emailsend = "data.bilalch@gmail.com";


              // bool status =UserControl.SendEmail(emailsend, body, subject);

                string name = row.Username;
                Session["UserName"] = name;
               


                return RedirectToAction("Dashboard", "User");
            }
       
            else
            {
                TempData["InValid"] = "Invalid username or password";
            }

            return View();
        }



        public ActionResult Logout()
        {

            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index");

        }
            public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            if (Session["UserName"] == null)
                return RedirectToAction("Index", "User");
            LoginModel user = new LoginModel();

            return View(user);
        }
        [HttpPost]
        public ActionResult ChangePassword(FormCollection fc)
        {

            if (Session["UserName"] == null)
                return RedirectToAction("Index", "User");
            string oldp, newp, newpc = "";
            oldp = fc["oldp"];
            newp = fc["newp"];
            newpc = fc["cnewp"];
            string usrid = Session["UserName"].ToString();
            bool exist = Lib.BLL.User.isuserexist(usrid, oldp);
            if (exist)
            {
                Lib.BLL.User.updatepass(usrid, oldp, newp);
                TempData["InValid"] = "Password Change Succesfully...";

            }
            else
                TempData["InValid"] = "Old Password is Invalid......";


            return View();
        }
    }
}