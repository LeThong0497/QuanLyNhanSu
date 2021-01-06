namespace QUANLYNHANSU
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbPassword = new System.Windows.Forms.PictureBox();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ckbNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuDragControlfrmLogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(61, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(61, 395);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 1);
            this.panel2.TabIndex = 0;
            // 
            // ptbPassword
            // 
            this.ptbPassword.BackColor = System.Drawing.Color.White;
            this.ptbPassword.Image = global::QUANLYNHANSU.Properties.Resources.key_2;
            this.ptbPassword.Location = new System.Drawing.Point(61, 357);
            this.ptbPassword.Name = "ptbPassword";
            this.ptbPassword.Size = new System.Drawing.Size(35, 35);
            this.ptbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPassword.TabIndex = 0;
            this.ptbPassword.TabStop = false;
            // 
            // ptbUser
            // 
            this.ptbUser.BackColor = System.Drawing.Color.White;
            this.ptbUser.Image = global::QUANLYNHANSU.Properties.Resources.user;
            this.ptbUser.Location = new System.Drawing.Point(61, 264);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(35, 35);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUser.TabIndex = 1;
            this.ptbUser.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtUser.Location = new System.Drawing.Point(107, 277);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(199, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Tài Khoản";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtPassword.Location = new System.Drawing.Point(109, 368);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mật khẩu";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // ckbNhoMatKhau
            // 
            this.ckbNhoMatKhau.AutoSize = true;
            this.ckbNhoMatKhau.BackColor = System.Drawing.Color.White;
            this.ckbNhoMatKhau.Location = new System.Drawing.Point(128, 423);
            this.ckbNhoMatKhau.Name = "ckbNhoMatKhau";
            this.ckbNhoMatKhau.Size = new System.Drawing.Size(93, 17);
            this.ckbNhoMatKhau.TabIndex = 3;
            this.ckbNhoMatKhau.Text = "Nhớ mật khẩu";
            this.ckbNhoMatKhau.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(61, 476);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(240, 36);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.White;
            this.ptbClose.Image = global::QUANLYNHANSU.Properties.Resources.delete_sign_26px;
            this.ptbClose.Location = new System.Drawing.Point(325, 3);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(28, 31);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 4;
            this.ptbClose.TabStop = false;
            this.toolTipClose.SetToolTip(this.ptbClose, "Thoát");
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // toolTipClose
            // 
            this.toolTipClose.ShowAlways = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuDragControlfrmLogin
            // 
            this.bunifuDragControlfrmLogin.Fixed = true;
            this.bunifuDragControlfrmLogin.Horizontal = true;
            this.bunifuDragControlfrmLogin.TargetControl = this;
            this.bunifuDragControlfrmLogin.Vertical = true;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::QUANLYNHANSU.Properties.Resources.login_theme1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 598);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.ckbNhoMatKhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.ptbPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATL QUAN LY NHAN SU";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbPassword;
        private System.Windows.Forms.PictureBox ptbUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox ckbNhoMatKhau;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.ToolTip toolTipClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlfrmLogin;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse;

    }
}

