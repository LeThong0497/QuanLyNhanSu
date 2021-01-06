using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BUS
{
  public  class DiaChiBUS
    {
      DiaChiDAL dcDAL;
      public DiaChiBUS()
      {
          dcDAL = new DiaChiDAL();
      }

      public eDiaChi getDiaChiTheoMa(string ma){
          return dcDAL.getDiaChiTheoMa(ma);
      }
      public bool themDiaChi(eDiaChi dc)
      {
          return dcDAL.themDiaChi(dc);
      }
      public bool xoaDiaChi(string madc)
      {
          return dcDAL.xoaDiaChi(madc);
      }
      public bool suaDiaChi(eDiaChi dc)
      {
          return dcDAL.suaDiaChi(dc);
      }
    }
}
