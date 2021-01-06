using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainQLNhanSu());
            //Application.Run(new frmMain());
            //Application.Run(new frmLogin());
            //Application.Run(new frmTest());
            //Application.Run(new frmThemNhanVienDuAn());
            //Application.Run(new frmThongKe());
        }
       
    }
}
