using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class frmMainQLNhanSu : Form
    {
        public frmMainQLNhanSu()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            if (panelMenu.Width == 50)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 208;
                bunifuTransitionmenu.ShowSync(panelMenu);

            }
            else
            {
                panelMenu.Visible = false;
                panelMenu.Width = 50;
                bunifuTransitionmenu.ShowSync(panelMenu);
            }
        }
        clsPhatSinhMa ps = new clsPhatSinhMa();
        private void frmMainQLNhanSu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ps.TaoMa("NV"));
        }

        private void btnQLDuAn_Click(object sender, EventArgs e)
        {
            frmQLDuAn frm = new frmQLDuAn();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelFormMain.Controls.Clear();
            panelFormMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frm = new frmQLNhanVien();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelFormMain.Controls.Clear();
            panelFormMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelFormMain.Controls.Clear();
            panelFormMain.Controls.Add(frm);
            frm.Show();
        }

        private void bntThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelFormMain.Controls.Clear();
            panelFormMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            frmTinhLuong frm = new frmTinhLuong();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelFormMain.Controls.Clear();
            panelFormMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frm = new frmChamCong();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelFormMain.Controls.Clear();
            panelFormMain.Controls.Add(frm);
            frm.Show();
        }

       
    }
}
