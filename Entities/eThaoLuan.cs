using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class eThaoLuan
    {
        string  chuDeThaoLuan, noiDungThaoLuan, maDuAn;
        int maThaoLuan;
        public string MaDuAn
        {
            get { return maDuAn; }
            set { maDuAn = value; }
        }

        public string NoiDungThaoLuan
        {
            get { return noiDungThaoLuan; }
            set { noiDungThaoLuan = value; }
        }

        public string ChuDeThaoLuan
        {
            get { return chuDeThaoLuan; }
            set { chuDeThaoLuan = value; }
        }

        public int MaThaoLuan
        {
            get { return maThaoLuan; }
            set { maThaoLuan = value; }
        }
        DateTime ngayThaoLuan;

        public DateTime NgayThaoLuan
        {
            get { return ngayThaoLuan; }
            set { ngayThaoLuan = value; }
        }

    }
}
