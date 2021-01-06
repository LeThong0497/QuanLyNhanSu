using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BUS
{
 public   class BangChamCongBUS
    {
        BangChamCongDAL bccDAL;
        public BangChamCongBUS()
        {
            bccDAL = new BangChamCongDAL();
        }
        public bool themNhanVienVaoDuAn(string maNV, string maDuAn)
        {
            return bccDAL.themNhanVienVaoDuAn(maNV, maDuAn);
        }
        public bool xoaNhanVienKhoiDuAn(string maNV, string maDuAn)
        {
            return bccDAL.xoaNhanVienKhoiDuAn(maNV, maDuAn);
        }
    }
}
