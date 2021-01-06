using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BUS
{
   public class CongViecBUS
    {
       CongViecDAL cvDAL;
       public CongViecBUS()
       {
           cvDAL = new CongViecDAL();
       }
        public List<eCongViec> getCongViecTheoMaDuAn(string ma)
        {
            return cvDAL.getCongViecTheoMaDuAn(ma);  //
        }
       
        
    }
}
