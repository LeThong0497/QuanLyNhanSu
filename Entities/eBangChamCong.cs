using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class eBangChamCong
    {
        string maNhanVien, maDuAn;

        public string MaDuAn
        {
            get { return maDuAn; }
            set { maDuAn = value; }
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
        DateTime thangChamCong;

        public DateTime ThangChamCong
        {
            get { return thangChamCong; }
            set { thangChamCong = value; }
        }
        public eBangChamCong(string maNhanVien, string maDuAn)
        {
            this.maDuAn = maDuAn;
            this.maNhanVien = maNhanVien;
            this.soNgayCong = 0;
        }
        public eBangChamCong()
        {

        }
    }
}
