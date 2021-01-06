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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            //this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            txtUser.Clear();
            txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            //this.pictureBox1.Image = global::QUANLYNHANSU.Properties.Resources.delete_sign_26px;
            ptbUser.Image = global::QUANLYNHANSU.Properties.Resources.user_filled;


        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPassword.PasswordChar = '*';
            ptbPassword.Image = global::QUANLYNHANSU.Properties.Resources.key_2_filled;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == null|| txtUser.Text=="") ptbUser.Image = global::QUANLYNHANSU.Properties.Resources.user;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == null || txtPassword.Text=="") ptbPassword.Image = global::QUANLYNHANSU.Properties.Resources.key_2;
        }

        

        
        
        

        

      

       
    }
}
