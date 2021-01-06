using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
  public  class CongViecDAL
    {
        dbQuanLyDuAnDataContext db = new dbQuanLyDuAnDataContext();
        public List<eCongViec> getCongViecTheoMaDuAn(string ma)     
        {
            var dscv = db.CongViecDuAns.Where(x => x.maDuAn == ma).ToList();          
            List<eCongViec> ls = new List<eCongViec>();
            foreach (CongViecDuAn temp in dscv)
            {
                eCongViec cv = new eCongViec();
                cv.MaDuAn = temp.maDuAn;
                cv.TenCongViec = temp.tenCongViec;
                cv.NgayBatDau = (DateTime)temp.ngayBatDau;
                cv.NgayKetThuc = (DateTime)temp.ngayKetThuc;
                cv.DoUuTien = temp.doUuTien;               
                ls.Add(cv);
            }
            return ls;

        }
       
    }
}
