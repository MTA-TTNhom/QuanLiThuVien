using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class NhaXuatBanController
    {
        QuanLiThuVienHVKTQSDataContext db = null;
        public NhaXuatBanController()
        {
            db = new QuanLiThuVienHVKTQSDataContext();
        }
        public List<nhaxuatban> Detail()
        {
            var lstnhaxb = db.nhaxuatbans.ToList();
            return lstnxb;
        }
        public int Add(nhaxuatban entity)
        {
            try
            {
                var nsx = db.db.nhaxuatbans.Where(m => m.manxb == entity.manxb);
                if (nsx != null)
                {
                    db.nhaxuatbans.InsertOnSubmit(entity);
                    db.SubmitChanges();
                    return entity.manxb;
                }
                return 0;
                
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var nsx = db.db.nhaxuatbans.Where(m => m.manxb == id);
                if (nsx != null)
                {
                    var obj = db.nhaxuatbans.First(m => m.manxb == id);
                    db.nhaxuatbans.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                    return true;
                }
                return false;
                
            }
            catch(Exception)
            {
                return false;
                throw;
            }
            
        }

        public bool Edit(nhaxuatban nxb)
        {
            var obj = db.nhaxuatbans.Where(m => m.manxb == nxb.manxb);
            if (obj != null)
            {
                try
                {
                    obj.tennxb = nxb.tennxb;
                    obj.diachi = nxb.diachi;
                    obj.sdt = nxb.sdt;
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            return true;
        }
    }
}
