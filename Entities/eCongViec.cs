using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class eCongViec
    {
        int maCongViec;

        public int MaCongViec
        {
            get { return maCongViec; }
            set { maCongViec = value; }
        }
        string tenCongViec, doUuTien, maDuAn;

        public string MaDuAn
        {
            get { return maDuAn; }
            set { maDuAn = value; }
        }

        public string DoUuTien
        {
            get { return doUuTien; }
            set { doUuTien = value; }
        }

        public string TenCongViec
        {
            get { return tenCongViec; }
            set { tenCongViec = value; }
        }
        DateTime ngayBatDau, ngayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }

        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        public eCongViec()
        {

        }
        public eCongViec(string tenCongViec,string doUuTien,string maDuAn,DateTime ngayBatDau,DateTime ngayKetThuc )
        {
            this.tenCongViec = tenCongViec;
            this.doUuTien = doUuTien;
            this.maDuAn = maDuAn;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;

        }
    }                                                               
}
