using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QUANLYNHANSU
{
    class clsKiemTra
    {
        public bool CheckEmail(string str)
        {
            return Regex.Match(str, @"^(\w+@\w+[.][a-zA-z]+){1,4}$").Success;
        }
        public bool CheckPhone(string str)
        {
            return Regex.Match(str, @"^([0][1-9]{2}-)?([1-9]\d{7})$").Success;
        }
        public bool CheckFName(string str)
        {
            return Regex.Match(str, @"^[A-Z][a-z]+$").Success;
        }
        public bool CheckLName(string str)
        {
            return Regex.Match(str, @"^([A-Z][a-z]{9}\s)*").Success;
        }
        public bool CheckID(string str)
        {
            return Regex.Match(str, @"^[A-E][1-9]{4}").Success;
        }
        public bool CheckMoney(string str)
        {
            return Regex.Match(str, @"^[1-9]+[0-9]{5,}$").Success;
        }
    }
}
