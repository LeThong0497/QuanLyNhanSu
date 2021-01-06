using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class eChamCongNhanVienDuAn
    {
        string maNhanVien, tenNhanVien, tenChucVu;

        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        int soNgayCong;

        public int SoNgayCong
        {
            get { return soNgayCong; }
            set { soNgayCong = value; }
        }
        DateTime ngayChamCong;

        public DateTime NgayChamCong
        {
            get { return ngayChamCong; }
            set { ngayChamCong = value; }
        }
        public eChamCongNhanVienDuAn()
        {

        }
        public eChamCongNhanVienDuAn(string maNhanVien, string tenNhanVien, string tenChucVu, int soNgayCong, DateTime ngayChamCong)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.tenChucVu = tenChucVu;
            this.soNgayCong = soNgayCong;
            this.ngayChamCong = ngayChamCong;
        }
    }
}
