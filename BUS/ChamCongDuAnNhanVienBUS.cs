using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BUS
{
    public class ChamCongDuAnNhanVienBUS
    {
        ChamCongDuAnNhanVienDAL ccdanvBUS;
        public ChamCongDuAnNhanVienBUS()
        {
            ccdanvBUS = new ChamCongDuAnNhanVienDAL();
        }
        public List<eNhanVien> getNhanVienTheoMaDuAn(string ma)
        {
            return ccdanvBUS.getNhanVienTheoMaDuAn(ma);
        }
        public List<eNhanVien> getNhanVienKhongThuocMaDuAn(string ma)
        {
            return ccdanvBUS.getNhanVienKhongThuocMaDuAn(ma);
        }
        public List<eChamCongNhanVienDuAn> getNgayCongNhanVienTheoMaDuAn(string maDuAn)
        {
            return ccdanvBUS.getNgayCongNhanVienTheoMaDuAn(maDuAn);
        } 
        public bool suaNgayCong(eBangChamCong bcc)
        {
            return ccdanvBUS.suaNgayCong(bcc);
        }
       
    }
}
