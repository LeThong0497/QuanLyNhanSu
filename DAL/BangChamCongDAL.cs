using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
  public  class BangChamCongDAL
    {
        dbQuanLyDuAnDataContext db = new dbQuanLyDuAnDataContext();

        public bool CheckIfExist(string maNV, string maDuAn)
        {
            BangChamCong da = db.BangChamCongs.Where(x => x.maDuAn == maDuAn && x.maNhanVien == maNV).FirstOrDefault();
            if (da != null)
                return true;
            return false;
        }
        public bool themNhanVienVaoDuAn(string maNV, string maDuAn)
        {
            if (CheckIfExist(maNV,maDuAn))
                return false;
            BangChamCong item = new BangChamCong();
            item.maDuAn = maDuAn;
            item.maNhanVien = maNV;
            item.soNgayCong = 0;
            db.BangChamCongs.InsertOnSubmit(item);
            db.SubmitChanges();
            return true;
        }

        public bool xoaNhanVienKhoiDuAn(string maNhanVien, string maDuAn)
        {

     
            var dsXoa = from x in db.BangChamCongs
                        where (x.maNhanVien == maNhanVien && x.maDuAn == maDuAn)
                        select x;

            foreach (BangChamCong dc in dsXoa)
            {
                db.BangChamCongs.DeleteOnSubmit(dc);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không xóa được " + e.Message);
            }
            return true;
        }
    }
}
