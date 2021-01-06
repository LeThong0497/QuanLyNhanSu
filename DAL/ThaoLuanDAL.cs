using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
   public class ThaoLuanDAL
    {
        dbQuanLyDuAnDataContext db = new dbQuanLyDuAnDataContext();
        public List<eThaoLuan> getThaoLuanTheoMaDuAn(string ma)
        {
            var dstl = db.ThaoLuanDuAns.Where(x => x.maDuAn == ma).ToList();
            List<eThaoLuan> ls = new List<eThaoLuan>();
            foreach (ThaoLuanDuAn temp in dstl)
            {
                eThaoLuan tl = new eThaoLuan();
                tl.MaThaoLuan = temp.maThaoLuan;
                tl.MaDuAn = temp.maDuAn;
                tl.ChuDeThaoLuan = temp.chuDeThaoLuan;
                tl.NoiDungThaoLuan = temp.noiDungThaoLuan;
                tl.NgayThaoLuan = (DateTime)temp.ngayThaoLuan;
                ls.Add(tl);
            }
            return ls;

        }
    }
}
