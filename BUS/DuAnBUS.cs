using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BUS
{
    public class DuAnBUS
    {
        DuAnDAL daDAL;
        public DuAnBUS()
        {
            daDAL = new DuAnDAL();
        }
        
        public List<eDuAn> getAllDuAn()
        {
            return daDAL.getAllDuAn();          
        }
        public bool themDuAn(eDuAn duanmoi)
        {
            return daDAL.themDuAn(duanmoi);
        }
        public bool suaDuAn(eDuAn da)
        {
            return daDAL.suaDuAn(da);
        }
    }
}
