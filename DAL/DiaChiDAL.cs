using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL
{
   public class DiaChiDAL
    {
        dbQuanLyDuAnDataContext db = new dbQuanLyDuAnDataContext();
        public eDiaChi getDiaChiTheoMa( string ma)
        {
            eDiaChi dc = new eDiaChi();
            DiaChi dchi= new DiaChi();
            var diaChi = db.DiaChis.Where(x => x.maDiaChi == ma).First();
            dchi = (DiaChi)diaChi;
            dc.MaDiaChi = dchi.maDiaChi;
            dc.DiaChiThanhPho = dchi.diaChiThanhPho;
            dc.DiaChiQuan = dchi.diaChiQuan;
            dc.DiaChiPhuong = dchi.diaChiPhuong;
            dc.DiaChiNha = dchi.diaChiNha;
            return dc;
        }
        public bool CheckIfExist(string maDC)
        {
            DuAn dc = db.DuAns.Where(x => x.maDiaChi == maDC).FirstOrDefault();
            if (dc != null)
                return true;
            return false;
        }

        public bool themDiaChi(eDiaChi diaChiMoi)
        {
            if (CheckIfExist(diaChiMoi.MaDiaChi))
                return false;

            DiaChi dc = new DiaChi();
            dc.maDiaChi = diaChiMoi.MaDiaChi;
            dc.diaChiThanhPho = diaChiMoi.DiaChiThanhPho;
            dc.diaChiQuan = diaChiMoi.DiaChiQuan;
            dc.diaChiPhuong = diaChiMoi.DiaChiPhuong;
            dc.diaChiNha = diaChiMoi.DiaChiNha;
            db.DiaChis.InsertOnSubmit(dc);
            db.SubmitChanges();
            return true;
        }

       public bool xoaDiaChi(string maDC)
        {

            var dsXoa =
                from x in db.DiaChis
                where x.maDiaChi == maDC
                select x;

            foreach (DiaChi dc in dsXoa)
            {
                db.DiaChis.DeleteOnSubmit(dc);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không xóa được " + e.Message);
            }
            return true;         
        }

       public bool suaDiaChi(eDiaChi dc)
       {          
           DiaChi dchi = new DiaChi();
           var diaChi = db.DiaChis.Where(x => x.maDiaChi == dc.MaDiaChi).First();
           dchi = (DiaChi)diaChi;        
           dchi.diaChiThanhPho = dc.DiaChiThanhPho;
           dchi.diaChiQuan = dc.DiaChiQuan;
           dchi.diaChiPhuong = dc.DiaChiPhuong;
           dchi.diaChiNha = dc.DiaChiNha;
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
