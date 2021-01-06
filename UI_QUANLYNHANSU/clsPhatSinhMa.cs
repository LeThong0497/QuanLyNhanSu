using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace QUANLYNHANSU
{
    public class clsPhatSinhMa
    {
        
        public clsPhatSinhMa()
        {
           
        }
        public string TaoMa(string s)
        {
            Thread.Sleep(1000);
            return s + DateTime.Now.ToString("ddMMyyHHmmss");
        }
        public string TaoMa()
        {
            Thread.Sleep(1000);
            return  DateTime.Now.ToString("ddMMyyHHmmss");
        }

    }
}
