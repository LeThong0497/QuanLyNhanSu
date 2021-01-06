using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
   public class ChamCongDuAnNhanVienDAL
    {
        dbQuanLyDuAnDataContext db = new dbQuanLyDuAnDataContext();

        public List<eNhanVien> getNhanVienTheoMaDuAn(string ma)
        {

            var dsnv = from da in db.DuAns
                       join cc in db.BangChamCongs on da.maDuAn equals cc.maDuAn
                       join nv in db.NhanViens on cc.maNhanVien equals nv.maNhanVien
                       where da.maDuAn == ma
                       orderby nv.tenNhanVien descending
                       select nv;

            List<eNhanVien> ls = new List<eNhanVien>();
            foreach (NhanVien item in dsnv)
            {
                eNhanVien nv = new eNhanVien();
                nv.MaNhanVien = item.maNhanVien;
                nv.MaChucVu = item.maChucVu;
                nv.MaDiaChi = item.maDiaChi;
                nv.MaPhongBan = item.maPhongBan;
                nv.NgaySinh = item.ngaySinh;
                nv.TenNhanVien = item.tenNhanVien;
                nv.TaiKhoan = item.taiKhoan;
                nv.SoDienThoai = item.soDienThoai;
                nv.GioiTinh = item.gioiTinh;
                nv.NguoiMoi = false;
                ls.Add(nv);
            }
            return ls;
        }

        public List<eNhanVien> getNhanVienKhongThuocMaDuAn(string ma)
        {
            var dsnv = from nv in db.NhanViens  join bcc in db.BangChamCongs
                                                on nv.maNhanVien equals bcc.maNhanVien
                                                into NhanVienChanCong 
                                                from nvcc in NhanVienChanCong.DefaultIfEmpty()
                                                where  (nvcc.maDuAn != ma || nvcc.maNhanVien==null)
                                                orderby nv.tenNhanVien descending
                                                select nv;
                                              

            List<eNhanVien> ls = new List<eNhanVien>();
            foreach (NhanVien item in dsnv)
            {
                eNhanVien nv = new eNhanVien();
                nv.MaNhanVien = item.maNhanVien;
                nv.MaChucVu = item.maChucVu;
                nv.MaDiaChi = item.maDiaChi;
                nv.MaPhongBan = item.maPhongBan;
                nv.NgaySinh = item.ngaySinh;
                nv.TenNhanVien = item.tenNhanVien;
                nv.TaiKhoan = item.taiKhoan;
                nv.SoDienThoai = item.soDienThoai;
                nv.GioiTinh = item.gioiTinh;
                nv.NguoiMoi = true;
                ls.Add(nv);
            }
            return ls;
        }
        public List<eChamCongNhanVienDuAn> getNgayCongNhanVienTheoMaDuAn(string ma)
        {
            var dsnv = from da in db.DuAns
                        join cc in db.BangChamCongs on da.maDuAn equals cc.maDuAn
                        join nv in db.NhanViens on cc.maNhanVien equals nv.maNhanVien
                        join cv in db.ChucVus on nv.maChucVu equals cv.maChucVu
                        where da.maDuAn == ma
                        orderby nv.tenNhanVien descending
                        select new { MaNhanVien = nv.maNhanVien, TenNhanVien = nv.tenNhanVien, TenChucVu = cv.tenChucVu, SoNgayCong = cc.soNgayCong, NgayChamCong = cc.thangChamCong };

            List<eChamCongNhanVienDuAn> ls = new List<eChamCongNhanVienDuAn>();
            foreach (var item in dsnv)
            {
                eChamCongNhanVienDuAn temp = new eChamCongNhanVienDuAn();
                temp.MaNhanVien = item.MaNhanVien;
                temp.TenNhanVien = item.TenNhanVien;
                temp.TenChucVu = item.TenChucVu;
                temp.SoNgayCong = item.SoNgayCong;
                if (item.NgayChamCong!=null)
                    temp.NgayChamCong = (DateTime)item.NgayChamCong;
                ls.Add(temp);
            }
            return ls;
          
        }

        public bool suaNgayCong(eBangChamCong bcc)
        {
            BangChamCong bccMoi = new BangChamCong();
            var temp = db.BangChamCongs.Where(x => x.maDuAn == bcc.MaDuAn && x.maNhanVien == bcc.MaNhanVien).First();
            bccMoi = (BangChamCong)temp;
            bccMoi.soNgayCong = bcc.SoNgayCong;
            bccMoi.thangChamCong = bcc.ThangChamCong;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không sửa được " + e.Message);
            }
            return true;
        }

    }
}
