using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DuAnDAL
    {
          dbQuanLyDuAnDataContext db = new dbQuanLyDuAnDataContext();
          public List<eDuAn> getAllDuAn()
          {
              IEnumerable<DuAn> duan = db.DuAns;
              List<eDuAn> ls = new List<eDuAn>();
              foreach (DuAn item in duan)
              {
                  eDuAn da = new eDuAn();
                  da.MaDuAn = item.maDuAn;
                  da.MaDiaChi = item.maDiaChi;
                  da.TenDuAn = item.tenDuAn;
                  da.NgayHoanThanh =(DateTime)item.ngayHoanThanh;
                  da.NgayKhoiCong = (DateTime)item.ngayKhoiCong;
                  da.NgayHoanThanhDuKien = (DateTime)item.ngayHoanThanhDuKien;
                  da.LoaiCongTrinh = item.loaiCongTrinh;
                  da.ChuDauTu = item.chuDauTu;
                  da.KinhPhiDauTu =(decimal)item.kinhPhiDauTu;
                  da.TrangThai = item.trangThai;
                  ls.Add(da);
              }
              return ls;
          }
          public bool CheckIfExist(string maDA)
          {
              DuAn da = db.DuAns.Where(x => x.maDuAn == maDA).FirstOrDefault();
              if (da != null)
                  return true;
              return false;
          }

          public bool themDuAn(eDuAn duAnMoi)
          {
              if (CheckIfExist(duAnMoi.MaDuAn))
                  return false;
              DuAn da = new DuAn();
              da.maDuAn = duAnMoi.MaDuAn;
              da.maDiaChi = duAnMoi.MaDiaChi;
              da.ngayHoanThanh =(DateTime)duAnMoi.NgayHoanThanh;
              da.ngayKhoiCong = duAnMoi.NgayKhoiCong;
              da.trangThai = duAnMoi.TrangThai;
              da.tenDuAn = duAnMoi.TenDuAn;
              da.kinhPhiDauTu = duAnMoi.KinhPhiDauTu;
              da.loaiCongTrinh = duAnMoi.LoaiCongTrinh;
              da.chuDauTu = duAnMoi.ChuDauTu;
              da.kinhPhiDauTu = duAnMoi.KinhPhiDauTu;
              da.ngayHoanThanhDuKien = duAnMoi.NgayHoanThanhDuKien;
              db.DuAns.InsertOnSubmit(da);
              db.SubmitChanges();
              return true;
          }
        public bool suaDuAn(eDuAn daSua)
        {
           DuAn da = new DuAn();
           var temp = db.DuAns.Where(x => x.maDuAn == daSua.MaDuAn).First();
           da = (DuAn)temp;
           da.tenDuAn = daSua.TenDuAn;
           da.ngayKhoiCong = daSua.NgayKhoiCong;
           da.ngayHoanThanh = daSua.NgayHoanThanh;
           da.trangThai = daSua.TrangThai;
           da.kinhPhiDauTu = daSua.KinhPhiDauTu;
           da.loaiCongTrinh = daSua.LoaiCongTrinh;
           da.ngayHoanThanhDuKien = daSua.NgayHoanThanhDuKien;
           da.chuDauTu = daSua.ChuDauTu;

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
