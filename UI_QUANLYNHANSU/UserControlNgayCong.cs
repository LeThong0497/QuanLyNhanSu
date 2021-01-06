using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class UserControlNgayCong : UserControl
    {
        public UserControlNgayCong()
        {
            InitializeComponent();
        }
        string tenNhanVien, maNhanVien;

        [Category("Custom Props")]
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; lblMaNhanVien.Text = value; }
        }
          [Category("Custom Props")]  
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; lblTenNhanVien.Text = value; }
        }
        int soNgayCong;

        [Category("Custom Props")]  
        public int SoNgayCong
        {
            get { return soNgayCong; }
            set { soNgayCong = value; numericUpDown.Value = value; }
        }

        string tenChucVu;
        [Category("Custom Props")] 
        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; lblChucVu.Text = value; }
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            if (SoNgayCong > Convert.ToInt32(numericUpDown.Value.ToString()))
            {
                this.BackColor = Color.Tomato;
                MessageBox.Show("Số ngày công thấp hơn so với ban đầu\nSố ngày công ban đầu là:" + SoNgayCong, "Cảnh báo");
                this.Tag = DateTime.Now;
            }
            else if (SoNgayCong < Convert.ToInt32(numericUpDown.Value.ToString()))
            {
                this.BackColor = Color.FromArgb(185, 209, 234);
                this.Tag = DateTime.Now;
            }
        }

        private void numericUpDown_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(185, 209, 234);
            //this.Tag = DateTime.Now;
        }

        private void numericUpDown_Leave(object sender, EventArgs e)
        {
            //if (SoNgayCong > Convert.ToInt32(numericUpDown.Value.ToString()))
            //{
            //    this.BackColor = Color.Tomato;
            //    MessageBox.Show("Số ngày công thấp hơn so với ban đầu\nSố ngày công ban đầu là:" + SoNgayCong, "Cảnh báo");
            //}
        }     
    }
}
