using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDuAn
    {
        string maDuAn, tenDuAn, maDiaChi, trangThai;

        public string MaDiaChi
        {
            get { return maDiaChi; }
            set { maDiaChi = value; }
        }

        public string TenDuAn
        {
            get { return tenDuAn; }
            set { tenDuAn = value; }
        }

        public string MaDuAn
        {
            get { return maDuAn; }
            set { maDuAn = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        DateTime ngayHoanThanh, ngayKhoiCong;

        public DateTime NgayKhoiCong
        {
            get { return ngayKhoiCong; }
            set { ngayKhoiCong = value; }
        }

        public DateTime NgayHoanThanh
        {
            get { return ngayHoanThanh; }
            set { ngayHoanThanh = value; }
        }
        DateTime ngayHoanThanhDuKien;

        public DateTime NgayHoanThanhDuKien
        {
            get { return ngayHoanThanhDuKien; }
            set { ngayHoanThanhDuKien = value; }
        }
        string chuDauTu, loaiCongTrinh;

        public string LoaiCongTrinh
        {
            get { return loaiCongTrinh; }
            set { loaiCongTrinh = value; }
        }

        public string ChuDauTu
        {
            get { return chuDauTu; }
            set { chuDauTu = value; }
        }
        decimal kinhPhiDauTu;

        public decimal KinhPhiDauTu
        {
            get { return kinhPhiDauTu; }
            set { kinhPhiDauTu = value; }
        }

        public eDuAn(string maDuAn, string tenDuAn, string maDiaChi, string trangThai, string loaiCongTrinh,
            string chuDauTu, decimal kinhPhiDauTu, DateTime ngayHoanThanh, DateTime ngayKhoiCong, DateTime ngayHoanThanhDuKien)
        {
            this.maDuAn = maDuAn;
            this.tenDuAn = tenDuAn;
            this.maDiaChi = maDiaChi;
            this.trangThai = trangThai;
            this.ngayHoanThanh = ngayHoanThanh;
            this.ngayKhoiCong = ngayKhoiCong;
            this.ngayHoanThanhDuKien = ngayHoanThanhDuKien;
            this.chuDauTu = chuDauTu;
            this.loaiCongTrinh = loaiCongTrinh;
            this.kinhPhiDauTu = kinhPhiDauTu;
        }
       
        public eDuAn()
        {

        }
    }
}
