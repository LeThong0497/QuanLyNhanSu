namespace QUANLYNHANSU
{
    partial class frmMainQLNhanSu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainQLNhanSu));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnChamCong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCaiDat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLNhanVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTienLuong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLDuAn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransitionmenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelFormMain = new System.Windows.Forms.Panel();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(139)))));
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.bunifuTransitionmenu.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1124, 39);
            this.panelHeader.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbMinimize);
            this.bunifuTransitionmenu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1072, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 39);
            this.panel2.TabIndex = 2;
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.ptbMinimize, BunifuAnimatorNS.DecorationType.None);
            this.ptbMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMinimize.Image = global::QUANLYNHANSU.Properties.Resources.minimize__30px;
            this.ptbMinimize.Location = new System.Drawing.Point(0, 0);
            this.ptbMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(26, 39);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimize.TabIndex = 0;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbClose);
            this.bunifuTransitionmenu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1098, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 39);
            this.panel1.TabIndex = 1;
            // 
            // ptbClose
            // 
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.ptbClose, BunifuAnimatorNS.DecorationType.None);
            this.ptbClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbClose.Image = global::QUANLYNHANSU.Properties.Resources.delete_sign_26px_w1;
            this.ptbClose.Location = new System.Drawing.Point(0, 0);
            this.ptbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(26, 39);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // pictureBox2
            // 
            this.bunifuTransitionmenu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::QUANLYNHANSU.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btnChamCong);
            this.panelMenu.Controls.Add(this.btnCaiDat);
            this.panelMenu.Controls.Add(this.btnQLNhanVien);
            this.panelMenu.Controls.Add(this.bntThongKe);
            this.panelMenu.Controls.Add(this.btnTimKiem);
            this.panelMenu.Controls.Add(this.btnTienLuong);
            this.panelMenu.Controls.Add(this.btnQLDuAn);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.bunifuTransitionmenu.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(50, 611);
            this.panelMenu.TabIndex = 2;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChamCong.BorderRadius = 0;
            this.btnChamCong.ButtonText = "   Chấm Công";
            this.btnChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnChamCong, BunifuAnimatorNS.DecorationType.None);
            this.btnChamCong.DisabledColor = System.Drawing.Color.Gray;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChamCong.Iconimage = global::QUANLYNHANSU.Properties.Resources.pen_32px;
            this.btnChamCong.Iconimage_right = null;
            this.btnChamCong.Iconimage_right_Selected = null;
            this.btnChamCong.Iconimage_Selected = null;
            this.btnChamCong.IconMarginLeft = 0;
            this.btnChamCong.IconMarginRight = 0;
            this.btnChamCong.IconRightVisible = true;
            this.btnChamCong.IconRightZoom = 0D;
            this.btnChamCong.IconVisible = true;
            this.btnChamCong.IconZoom = 50D;
            this.btnChamCong.IsTab = true;
            this.btnChamCong.Location = new System.Drawing.Point(0, 288);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(8);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChamCong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnChamCong.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnChamCong.selected = false;
            this.btnChamCong.Size = new System.Drawing.Size(222, 48);
            this.btnChamCong.TabIndex = 2;
            this.btnChamCong.Tag = "6";
            this.btnChamCong.Text = "   Chấm Công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Textcolor = System.Drawing.Color.White;
            this.btnChamCong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnCaiDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCaiDat.BackColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaiDat.BorderRadius = 0;
            this.btnCaiDat.ButtonText = "   Cài Đặt";
            this.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnCaiDat, BunifuAnimatorNS.DecorationType.None);
            this.btnCaiDat.DisabledColor = System.Drawing.Color.Gray;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCaiDat.Iconimage = global::QUANLYNHANSU.Properties.Resources.settings_24px;
            this.btnCaiDat.Iconimage_right = null;
            this.btnCaiDat.Iconimage_right_Selected = null;
            this.btnCaiDat.Iconimage_Selected = null;
            this.btnCaiDat.IconMarginLeft = 0;
            this.btnCaiDat.IconMarginRight = 0;
            this.btnCaiDat.IconRightVisible = true;
            this.btnCaiDat.IconRightZoom = 0D;
            this.btnCaiDat.IconVisible = true;
            this.btnCaiDat.IconZoom = 45D;
            this.btnCaiDat.IsTab = true;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 563);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(8);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCaiDat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnCaiDat.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCaiDat.selected = false;
            this.btnCaiDat.Size = new System.Drawing.Size(222, 48);
            this.btnCaiDat.TabIndex = 0;
            this.btnCaiDat.Tag = "0";
            this.btnCaiDat.Text = "   Cài Đặt";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Textcolor = System.Drawing.Color.White;
            this.btnCaiDat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnQLNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnQLNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLNhanVien.BorderRadius = 0;
            this.btnQLNhanVien.ButtonText = "   Quản Lý Nhân Viên";
            this.btnQLNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnQLNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.btnQLNhanVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLNhanVien.Iconimage = global::QUANLYNHANSU.Properties.Resources.group_filled_50px;
            this.btnQLNhanVien.Iconimage_right = null;
            this.btnQLNhanVien.Iconimage_right_Selected = null;
            this.btnQLNhanVien.Iconimage_Selected = null;
            this.btnQLNhanVien.IconMarginLeft = 0;
            this.btnQLNhanVien.IconMarginRight = 0;
            this.btnQLNhanVien.IconRightVisible = true;
            this.btnQLNhanVien.IconRightZoom = 0D;
            this.btnQLNhanVien.IconVisible = true;
            this.btnQLNhanVien.IconZoom = 45D;
            this.btnQLNhanVien.IsTab = true;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 96);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(8);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnQLNhanVien.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnQLNhanVien.selected = false;
            this.btnQLNhanVien.Size = new System.Drawing.Size(222, 48);
            this.btnQLNhanVien.TabIndex = 0;
            this.btnQLNhanVien.Tag = "2";
            this.btnQLNhanVien.Text = "   Quản Lý Nhân Viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Textcolor = System.Drawing.Color.White;
            this.btnQLNhanVien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // bntThongKe
            // 
            this.bntThongKe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.bntThongKe.BackColor = System.Drawing.Color.Transparent;
            this.bntThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntThongKe.BorderRadius = 0;
            this.bntThongKe.ButtonText = "   Thống Kê";
            this.bntThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.bntThongKe, BunifuAnimatorNS.DecorationType.None);
            this.bntThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.bntThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.bntThongKe.Iconimage = global::QUANLYNHANSU.Properties.Resources.combo_chart_filled_50px;
            this.bntThongKe.Iconimage_right = null;
            this.bntThongKe.Iconimage_right_Selected = null;
            this.bntThongKe.Iconimage_Selected = null;
            this.bntThongKe.IconMarginLeft = 0;
            this.bntThongKe.IconMarginRight = 0;
            this.bntThongKe.IconRightVisible = true;
            this.bntThongKe.IconRightZoom = 0D;
            this.bntThongKe.IconVisible = true;
            this.bntThongKe.IconZoom = 45D;
            this.bntThongKe.IsTab = true;
            this.bntThongKe.Location = new System.Drawing.Point(0, 192);
            this.bntThongKe.Margin = new System.Windows.Forms.Padding(8);
            this.bntThongKe.Name = "bntThongKe";
            this.bntThongKe.Normalcolor = System.Drawing.Color.Transparent;
            this.bntThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.bntThongKe.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.bntThongKe.selected = false;
            this.bntThongKe.Size = new System.Drawing.Size(222, 48);
            this.bntThongKe.TabIndex = 0;
            this.bntThongKe.Tag = "4";
            this.bntThongKe.Text = "   Thống Kê";
            this.bntThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThongKe.Textcolor = System.Drawing.Color.White;
            this.bntThongKe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThongKe.Click += new System.EventHandler(this.bntThongKe_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "   Tìm Kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnTimKiem, BunifuAnimatorNS.DecorationType.None);
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = global::QUANLYNHANSU.Properties.Resources.find_user_male_30px;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 50D;
            this.btnTimKiem.IsTab = true;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 144);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(222, 48);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Tag = "3";
            this.btnTimKiem.Text = "   Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTienLuong
            // 
            this.btnTienLuong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnTienLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnTienLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTienLuong.BorderRadius = 0;
            this.btnTienLuong.ButtonText = "   Tính Tiền Lương";
            this.btnTienLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnTienLuong, BunifuAnimatorNS.DecorationType.None);
            this.btnTienLuong.DisabledColor = System.Drawing.Color.Gray;
            this.btnTienLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienLuong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTienLuong.Iconimage = global::QUANLYNHANSU.Properties.Resources.money_bag_30px;
            this.btnTienLuong.Iconimage_right = null;
            this.btnTienLuong.Iconimage_right_Selected = null;
            this.btnTienLuong.Iconimage_Selected = null;
            this.btnTienLuong.IconMarginLeft = 0;
            this.btnTienLuong.IconMarginRight = 0;
            this.btnTienLuong.IconRightVisible = true;
            this.btnTienLuong.IconRightZoom = 0D;
            this.btnTienLuong.IconVisible = true;
            this.btnTienLuong.IconZoom = 50D;
            this.btnTienLuong.IsTab = true;
            this.btnTienLuong.Location = new System.Drawing.Point(0, 240);
            this.btnTienLuong.Margin = new System.Windows.Forms.Padding(8);
            this.btnTienLuong.Name = "btnTienLuong";
            this.btnTienLuong.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTienLuong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnTienLuong.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnTienLuong.selected = false;
            this.btnTienLuong.Size = new System.Drawing.Size(222, 48);
            this.btnTienLuong.TabIndex = 0;
            this.btnTienLuong.Tag = "5";
            this.btnTienLuong.Text = "   Tính Tiền Lương";
            this.btnTienLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienLuong.Textcolor = System.Drawing.Color.White;
            this.btnTienLuong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienLuong.Click += new System.EventHandler(this.btnTienLuong_Click);
            // 
            // btnQLDuAn
            // 
            this.btnQLDuAn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnQLDuAn.BackColor = System.Drawing.Color.Transparent;
            this.btnQLDuAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLDuAn.BorderRadius = 0;
            this.btnQLDuAn.ButtonText = "    Quản Lý Dự Án";
            this.btnQLDuAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnQLDuAn, BunifuAnimatorNS.DecorationType.None);
            this.btnQLDuAn.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDuAn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLDuAn.Iconimage = global::QUANLYNHANSU.Properties.Resources.group_of_projects_filled_50px;
            this.btnQLDuAn.Iconimage_right = null;
            this.btnQLDuAn.Iconimage_right_Selected = null;
            this.btnQLDuAn.Iconimage_Selected = null;
            this.btnQLDuAn.IconMarginLeft = 0;
            this.btnQLDuAn.IconMarginRight = 0;
            this.btnQLDuAn.IconRightVisible = true;
            this.btnQLDuAn.IconRightZoom = 0D;
            this.btnQLDuAn.IconVisible = true;
            this.btnQLDuAn.IconZoom = 45D;
            this.btnQLDuAn.IsTab = true;
            this.btnQLDuAn.Location = new System.Drawing.Point(0, 48);
            this.btnQLDuAn.Margin = new System.Windows.Forms.Padding(8);
            this.btnQLDuAn.Name = "btnQLDuAn";
            this.btnQLDuAn.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLDuAn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnQLDuAn.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnQLDuAn.selected = false;
            this.btnQLDuAn.Size = new System.Drawing.Size(222, 48);
            this.btnQLDuAn.TabIndex = 0;
            this.btnQLDuAn.Tag = "1";
            this.btnQLDuAn.Text = "    Quản Lý Dự Án";
            this.btnQLDuAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDuAn.Textcolor = System.Drawing.Color.White;
            this.btnQLDuAn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDuAn.Click += new System.EventHandler(this.btnQLDuAn_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "    Danh Mục";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionmenu.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconimage = global::QUANLYNHANSU.Properties.Resources.menu_filled_50px;
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 0;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 45D;
            this.btnMenu.IsTab = true;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.btnMenu.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMenu.selected = true;
            this.btnMenu.Size = new System.Drawing.Size(222, 48);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "    Danh Mục";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Textcolor = System.Drawing.Color.White;
            this.btnMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bunifuTransitionmenu
            // 
            this.bunifuTransitionmenu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransitionmenu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransitionmenu.DefaultAnimation = animation1;
            // 
            // panelFormMain
            // 
            this.bunifuTransitionmenu.SetDecoration(this.panelFormMain, BunifuAnimatorNS.DecorationType.None);
            this.panelFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormMain.Location = new System.Drawing.Point(50, 39);
            this.panelFormMain.Name = "panelFormMain";
            this.panelFormMain.Size = new System.Drawing.Size(1074, 611);
            this.panelFormMain.TabIndex = 3;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelHeader;
            this.bunifuDragControl.Vertical = true;
            // 
            // frmMainQLNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.panelFormMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.bunifuTransitionmenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainQLNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainQLNhanSu";
            this.Load += new System.EventHandler(this.frmMainQLNhanSu_Load);
            this.panelHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnChamCong;
        private Bunifu.Framework.UI.BunifuFlatButton btnCaiDat;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton bntThongKe;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnTienLuong;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLDuAn;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition bunifuTransitionmenu;
        private System.Windows.Forms.Panel panelFormMain;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
    }
}