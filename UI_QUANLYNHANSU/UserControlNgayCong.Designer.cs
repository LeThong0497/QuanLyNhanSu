namespace QUANLYNHANSU
{
    partial class UserControlNgayCong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMaNhanVien.Location = new System.Drawing.Point(0, 0);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(185, 30);
            this.lblMaNhanVien.TabIndex = 1;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            this.lblMaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTenNhanVien.Location = new System.Drawing.Point(185, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(300, 30);
            this.lblTenNhanVien.TabIndex = 5;
            this.lblTenNhanVien.Text = "Tên Nhân Viên";
            this.lblTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(684, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 30);
            this.panel1.TabIndex = 6;
            // 
            // numericUpDown
            // 
            this.numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown.Location = new System.Drawing.Point(38, 0);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(44, 26);
            this.numericUpDown.TabIndex = 5;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDown.Click += new System.EventHandler(this.numericUpDown_Click);
            this.numericUpDown.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // lblChucVu
            // 
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChucVu.Location = new System.Drawing.Point(485, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(199, 30);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Tên chức vụ";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlNgayCong";
            this.Size = new System.Drawing.Size(779, 30);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblChucVu;
    }
}
