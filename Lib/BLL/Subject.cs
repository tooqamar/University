
using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
   public class Subject
    {
    
        public static List<vListSubject> GetSubjectList()
        {
            DB_RTLEntities db = new DAL.DB_RTLEntities();
            {
                return db.vListSubjects.ToList();
            }
        }

        public static bool AddSubject(tblSubject Subject)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                db.tblSubjects.Add(Subject);
                return db.SaveChanges() > 0;
            }
        }
        public static bool UpdateSubject(tblSubject Subject)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tblSubject old = db.tblSubjects.Where(i => i.ID == Subject.ID).FirstOrDefault();
                if (old != null)
                {
                    old.Modified = Subject.Modified;
                    old.CourseID = Subject.CourseID;
                    old.Name = Subject.Name;
                    old.TeacherID = Subject.TeacherID;
                }
                return db.SaveChanges() > 0;
            }
        }
        public static void UpdateStaus(int iD, bool isActive)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                var row = db.tblSubjects.Find(iD);
                if (row != null)
                {
                    row.IsActive = isActive;

                    db.SaveChanges();
                }
            }
        }
    }
}
