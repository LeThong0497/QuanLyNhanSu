using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BUS
{
   public class ThaoLuanBUS
    {
       ThaoLuanDAL tlDAL;
       public ThaoLuanBUS()
       {
           tlDAL = new ThaoLuanDAL();
       }
       public List<eThaoLuan> getThaoLuanThaoMaDuAn(string ma){
           return tlDAL.getThaoLuanTheoMaDuAn(ma);
       }
    }
}
