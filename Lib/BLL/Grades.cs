using Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
   public class Grades
    {
        public static List<tblGrade> List()
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                return db.tblGrades.OrderBy(x => x.ID).ToList();
            }
        }
        public static void CreateNew(tblGrade model)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                if (db.tblGrades.Any(x => x.Name == model.Name))
                    return;

                db.tblGrades.Add(new tblGrade()
                {
                    Name = model.Name
                   

                });
                db.SaveChanges();


            }
        }
        public static void Update(int ID, string Desc)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                if (db.tblGrades.Any(x => x.Name == Desc))
                    return;
                var row = db.tblGrades.Find(ID);



                if (row != null)
                {
                    row.Name = Desc;
                   

                    db.SaveChanges();
                }
            }
        }

        public static void Delete(int ID)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                var row = db.tblGrades.Find(ID);
                db.tblGrades.Remove(row);
                db.SaveChanges();

            }
        }

      
    }
}
