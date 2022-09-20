
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
   public class Teacher
    {
        public static List<vListTeacher> GetTeacherList()
        {
            DB_RTLEntities db = new DAL.DB_RTLEntities();
            {
                return db.vListTeachers.ToList();
            }
        }

        public static bool AddTeacher(tblTeacher Teacher)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                db.tblTeachers.Add(Teacher);
                return db.SaveChanges() > 0;
            }
        }
        public static bool UpdateTeacher(tblTeacher Teacher)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tblTeacher old = db.tblTeachers.Where(i => i.ID == Teacher.ID).FirstOrDefault();
                if (old != null)
                {
                    old.Salary = Teacher.Salary;
                    old.UserID = Teacher.UserID;

                }
                return db.SaveChanges() > 0;
            }
        }
    }
}
