using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class eDiaChi
    {
        string maDiaChi, diaChiThanhPho, diaChiQuan, diaChiPhuong, diaChiNha;

        public string DiaChiNha
        {
            get { return diaChiNha; }
            set { diaChiNha = value; }
        }

        public string DiaChiPhuong
        {
            get { return diaChiPhuong; }
            set { diaChiPhuong = value; }
        }

        public string DiaChiQuan
        {
            get { return diaChiQuan; }
            set { diaChiQuan = value; }
        }

        public string DiaChiThanhPho
        {
            get { return diaChiThanhPho; }
            set { diaChiThanhPho = value; }
        }

        public string MaDiaChi
        {
            get { return maDiaChi; }
            set { maDiaChi = value; }
        }
        public eDiaChi()
        {

        }
        public eDiaChi(string maDiaChi, string diaChiThanhPho, string diaChiQuan, string diaChiPhuong, string diaChiNha)
        {              
            this.maDiaChi = maDiaChi;
            this.diaChiThanhPho = diaChiThanhPho ;
            this.diaChiQuan = diaChiQuan;
            this.diaChiPhuong = diaChiPhuong;
            this.diaChiNha = diaChiNha;
        }
        public eDiaChi(string diaChiThanhPho, string diaChiQuan, string diaChiPhuong, string diaChiNha)
        {
         
            this.diaChiThanhPho = diaChiThanhPho;
            this.diaChiQuan = diaChiQuan;
            this.diaChiPhuong = diaChiPhuong;
            this.diaChiNha = diaChiNha;
        }
    }
}
