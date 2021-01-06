using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHANSU
{
  public  class clsDiaChi
    {
        List<string> lThanhPho = new List<string>() { "Hồ Chí Minh"};

        public List<string> LThanhPho
        {
            get { return lThanhPho; }
            set { lThanhPho = value; }
        }
        List<string> lQuanOfHoChiMinh = new List<string>()
        {
              "Quận 1","Quận 2","Quận 3","Quận 4","Quận 5","Quận 6","Quận 7","Quận 8","Quận 9","Quận 10","Quận 11","Quận 12",
              "Quận Bình Tân","Quận Tân Phú","Quận Phú Nhuận","Quận Gò Vấp","Quận Bình Thạnh","Quận Thủ Đức"
        };

        public List<string> LQuanOfHoChiMinh
        {
            get { return lQuanOfHoChiMinh; }
            set { lQuanOfHoChiMinh = value; }
        }
        List<string> lPhuongOfQ1 = new List<string>()
        {
            "Phường Bến Nghé","Phường Bến Thành","Phường Cầu Kho","Phường Cầu Ông Lãnh","Phường Tân Định",
            "Phường Đa Kao","Phường Nguyễn Cư Trinh","Phường Nguyễn Thái Bình","Phường Phạm Ngũ Lão","Phường Cô Giang"
        };

        public List<string> LPhuongOfQ1
        {
            get { return lPhuongOfQ1; }
            set { lPhuongOfQ1 = value; }
        }
        List<string> lPhuongOfQ2 = new List<string>()
        {
           "Phường An Khánh","Phường An Lợi Đông","Phường An Phú","Phường Bình An","Phường Bình Khánh",
            "Phường Thủ Thiêm","Phường Bình Trưng Tây","Phường Cát Lái","Phường Thạnh Mỹ Lợi","Phường Thảo Điền","Phường Bình Trưng Đông"
        };

        public List<string> LPhuongOfQ2
        {
            get { return lPhuongOfQ2; }
            set { lPhuongOfQ2 = value; }
        }
        List<string> lPhuongOfQ3 = new List<string>()
        {
            "Phường 01","Phường 02","Phường 03","Phường 04","Phường 05",
            "Phường 06","Phường 07","Phường 08","Phường 09","Phường 10","Phường 11"
        };

        public List<string> LPhuongOfQ3
        {
            get { return lPhuongOfQ3; }
            set { lPhuongOfQ3 = value; }
        }
        List<string> lPhuongOfQ45681011 = new List<string>()
        {
            "Phường 01","Phường 02","Phường 03","Phường 04","Phường 05",
            "Phường 06","Phường 07","Phường 08","Phường 09","Phường 10","Phường 11"
        };

        public List<string> LPhuongOfQ45681011
        {
            get { return lPhuongOfQ45681011; }
            set { lPhuongOfQ45681011 = value; }
        }
        public List<string> QuanThuocPhuong(string s)
        {
            List<string> l = new List<string>();
            switch (s)
            {
                case "Quận 1": l = LPhuongOfQ1;   break;
                case "Quận 2": l =  LPhuongOfQ2;   break;
                case "Quận 3": l =  LPhuongOfQ3;     break;
                case "Quận 4": l =  LPhuongOfQ45681011;  break;
                case "Quận 5": l =  LPhuongOfQ45681011;  break;
                case "Quận 6": l =  LPhuongOfQ45681011;   break;
                case "Quận 7": l =  LPhuongOfQ45681011;    break;
                case "Quận 8": l =  LPhuongOfQ45681011;    break;
                case "Quận 9": l =  LPhuongOfQ45681011;     break;
                case "Quận 10": l =  LPhuongOfQ45681011;    break;
                case "Quận 11": l =  LPhuongOfQ45681011;    break;
                case "Quận 12": l =  LPhuongOfQ45681011;     break;
                case "Quận Bình Tân": l =  LPhuongOfQ45681011;  break;
                case "Huyện Hóc Môn": l =  LPhuongOfQ45681011;  break;
                case "Quận Tân Phú": l =  LPhuongOfQ45681011;  break;
                case "Quận Gò Vấp": l =  LPhuongOfQ45681011;   break;
                case "Quận Bình Thạnh": l =  LPhuongOfQ45681011; break;
                case "Quận Thủ Đức": l =  LPhuongOfQ45681011;    break;         
            }
            return l;
        }
    }
}
