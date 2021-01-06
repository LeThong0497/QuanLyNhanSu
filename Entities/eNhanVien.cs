using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eNhanVien
    {
        string maNhanVien, tenNhanVien, maDiaChi, soDienThoai, gioiTinh, maPhongBan, maChucVu, taiKhoan;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }

        public string MaPhongBan
        {
            get { return maPhongBan; }
            set { maPhongBan = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string MaDiaChi
        {
            get { return maDiaChi; }
            set { maDiaChi = value; }
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
        DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public eNhanVien(string maNhanVien, string tenNhanVien, string maDiaChi, string maPhongBan, string maChucVu, string soDienThoai, string gioiTinh, string taiKhoan, DateTime ngaySinh)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.maDiaChi= maDiaChi; 
            this.soDienThoai = soDienThoai;
            this.gioiTinh = gioiTinh;
            this.maPhongBan= maPhongBan;
            this.maChucVu = maChucVu;
            this.taiKhoan= taiKhoan;
            this.ngaySinh = ngaySinh;
        }
        public eNhanVien()
        {

        }
        bool nguoiMoi;

        public bool NguoiMoi
        {
            get { return nguoiMoi; }
            set { nguoiMoi = value; }
        }


        public eNhanVien(string maNhanVien, string tenNhanVien, string maDiaChi, string maPhongBan, string maChucVu, string soDienThoai, string gioiTinh, string taiKhoan, DateTime ngaySinh, bool nguoiMoi)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.maDiaChi = maDiaChi;
            this.soDienThoai = soDienThoai;
            this.gioiTinh = gioiTinh;
            this.maPhongBan = maPhongBan;
            this.maChucVu = maChucVu;
            this.taiKhoan = taiKhoan;
            this.ngaySinh = ngaySinh;
            this.nguoiMoi = nguoiMoi;
        }
    }
}
