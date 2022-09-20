
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
   public class Student
    {
        public static List<vListStudent> GetStudentList()
        {
            DB_RTLEntities db = new DAL.DB_RTLEntities();
            {
                return db.vListStudents.ToList();
            }
        }

        public static bool AddStudent(tbl_Student Student)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                db.tbl_Student.Add(Student);
                return db.SaveChanges() > 0;
            }
        }
        public static bool UpdateStudent(tbl_Student Student)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tbl_Student old = db.tbl_Student.Where(i => i.ID == Student.ID).FirstOrDefault();
                if (old != null)
                {
                    old.RegistrationNumber = Student.RegistrationNumber;
                    old.UserID = Student.UserID;
                    old.CourseID = Student.CourseID;

                }
                return db.SaveChanges() > 0;
            }
        }
    }
}
