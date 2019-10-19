using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class UserController
    {
        QuanLiThuVienHVKTQSDataContext db = null;
        db1 = new QuanLiThuVienHVKTQSDataContext();
        public UserController()
        {
            db = new QuanLiThuVienHVKTQSDataContext();
            db1 = new QuanLiThuVienHVKTQSDataContext();
        }

        public List<User> Detail()
        {
            var list = db.Users.ToList();
            return list;
        }

        public int Add(User dg)
        {
            try
            {
                var da = db.Users.Where(m => m.ID == dg.ID);
                if (da == null)
                {
                    db.Users.InsertOnSubmit(dg);
                    db.SubmitChanges();
                    return dg.ID;
                }
                else return 0;

            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public bool Edit(User dg)
        {
            var obj = db.Users.First(m => m.ID == dg.ID);
            if (obj != null)
            {
                try
                {
                    obj.ID = dg.ID;
                    obj.UserName = dg.UserName;
                    obj.Password = dg.Password;
                    obj.IsAdmin = dg.IsAdmin;
                   
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            return true;
        }


        public bool delete(int id)
        {
            try
            {
                var obj = db.Users.First(m => m.ID == id);
                List<User> lmm = db.Users.where(m => m.ID == id);
                //db.Users.DeleteOnSubmit(lmm);
                db.Users.DeleteOnSubmit(obj);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
    }
}
