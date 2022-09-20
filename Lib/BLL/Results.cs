using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
  public  class Results
    {
        public static List<vListResult> GetSubjectList()
        {
            DB_RTLEntities db = new DAL.DB_RTLEntities();
            {
                return db.vListResults.ToList();
            }
        }

        public static bool AddSubject(tbl_Student_Subject_Grade Subject)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                db.tbl_Student_Subject_Grade.Add(Subject);
                return db.SaveChanges() > 0;
            }
        }
        public static bool UpdateSubject(tbl_Student_Subject_Grade Subject)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tbl_Student_Subject_Grade old = db.tbl_Student_Subject_Grade.Where(i => i.ID == Subject.ID).FirstOrDefault();
                if (old != null)
                {
                    old.StudentID = Subject.StudentID;
                    old.SubjectID = Subject.SubjectID;
                    old.GradeID = Subject.GradeID;
                    
                }
                return db.SaveChanges() > 0;
            }
        }
       
    }
}
