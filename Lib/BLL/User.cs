using Lib.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.BLL
{
   public class User
    {
        public static List<tblUser> GetUserList()
        {
            DB_RTLEntities db = new DAL.DB_RTLEntities();
            {
                return db.tblUsers.ToList();
            }
        }
        
        public static bool AddUser(tblUser user)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                db.tblUsers.Add(user);
                return db.SaveChanges() > 0;
            }
        }
        public static bool UpdateUser(tblUser user)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tblUser old = db.tblUsers.Where(i => i.ID == user.ID).FirstOrDefault();
                if (old != null)
                {
                    old.Username = user.Username;
                    old.FirstName = user.FirstName;
                    old.IsActive = user.IsActive;
                    old.LastName = user.LastName;
                    old.Password = user.Password;
                    old.Phone = user.Phone;
                    old.dteModified = user.dteModified;
                    old.dteBirthday = user.dteBirthday;
                    old.Desciption = user.Desciption;
                    old.Email = user.Email;
                    
                }
                return db.SaveChanges() > 0;
            }
        }
        public static bool CheckDuplicateEmail(tblUser user)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                if (user.ID > 0)
                {
                    return db.tblUsers.Any(i => i.ID != user.ID && i.Username.ToLower() == user.Username.ToLower());
                }
                else
                {
                    return db.tblUsers.Any(i => i.Username.ToLower() == user.Username.ToLower());
                }
            }
        }

        public static bool isuserexist(string email, string password)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                return db.tblUsers.Any(dt => dt.Username.Equals(email) & dt.Password.Equals(password));
            }
        }
        public static bool updatepass(string usrid, string oldp, string newp)
        {
            DB_RTLEntities context = new DB_RTLEntities();
            tblUser studid = context.tblUsers.Where(i => i.Username == usrid).FirstOrDefault();
            if (studid != null)
            {
                studid.Password = newp;
            }
            Int32 result = context.SaveChanges();
            return result > 0;
        }

        public static bool DeleteUser(int UserID)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tblUser old = db.tblUsers.Where(i => i.ID == UserID).FirstOrDefault();
                if (old != null)
                {
                    db.tblUsers.Remove(old);
                }
                return db.SaveChanges() > 0;
            }
        }
        public static tblUser login(string username, string password)
        {
            DAL.DB_RTLEntities db = new DAL.DB_RTLEntities();
            return db.tblUsers.Where(i => i.Username == username && i.Password == password).FirstOrDefault();
        }

        
        public static bool ResetPassword(tblUser user)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                tblUser old = db.tblUsers.Where(i => i.ID == user.ID).FirstOrDefault();
                if (old != null)
                {
                    old.Password = user.Password;
                }
                return db.SaveChanges() > 0;
            }
        }

        public static tblUser GetEmailById(int id)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                return db.tblUsers.Where(i => i.ID == id).FirstOrDefault();


            }
        }

        public static tblUser GetUserByID(int id)
        {
            using (DAL.DB_RTLEntities db = new DAL.DB_RTLEntities())
            {
                return db.tblUsers.Where(i => i.ID == id).FirstOrDefault();


            }
        }
        public static void UpdateStaus(int iD, bool isActive)
        {
            using (DB_RTLEntities db = new DB_RTLEntities())
            {
                var row = db.tblUsers.Find(iD);
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
                var list = db.tblUsers.Find(ID);
                if (list != null)
                    return true;
                else

                    return false;
            }
        }

    }
}
