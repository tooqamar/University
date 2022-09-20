
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
   public class Course
    {
    

        public static List<tblCours> GetCoursList()
        {
            DB_RTLEntities db = new DAL.DB_RTLEntities();
            {
                return db.tblCourses.ToList();
            }
        }

        public static bool AddCours(tblCours Cours)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                db.tblCourses.Add(Cours);
                return db.SaveChanges() > 0;
            }
        }
        public static bool UpdateCours(tblCours Cours)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tblCours old = db.tblCourses.Where(i => i.ID == Cours.ID).FirstOrDefault();
                if (old != null)
                {
                    old.CourseName = Cours.CourseName;
                    old.Desciption = Cours.Desciption;
                    old.IsActive = Cours.IsActive;
                    old.Length = Cours.Length;
                    old.Price = Cours.Price;
                    
                }
                return db.SaveChanges() > 0;
            }
        }
        public static void UpdateStaus(int iD, bool isActive)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                var row = db.tblCourses.Find(iD);
                if (row != null)
                {
                    row.IsActive = isActive;

                    db.SaveChanges();
                }
            }
        }
        public static bool isUSER_Exist(long ID)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                var list = db.tblCourses.Find(ID);
                if (list != null)
                    return true;
                else

                    return false;
            }
        }

        public static tblCours GetUserByID(int id)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                return db.tblCourses.Where(i => i.ID == id).FirstOrDefault();


            }
        }
    }
}
