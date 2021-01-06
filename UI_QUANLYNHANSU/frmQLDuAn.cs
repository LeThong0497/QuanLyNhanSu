using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BUS;
using KimtToo.VisualReactive;
using System.Globalization;

namespace QUANLYNHANSU
{
    public partial class frmQLDuAn : Form
    {
        public frmQLDuAn()
        {
            InitializeComponent();
        }
        clsDiaChi diaChi = new clsDiaChi();
        DuAnBUS duAnBUS;
        DiaChiBUS dcBUS;
        CongViecBUS cvBUS;
        ChamCongDuAnNhanVienBUS ccdanvBUS;
        ThaoLuanBUS tlBUS;
        clsKiemTra ktDuLieu;
        BindingSource bindingCongViec;
        //var info = CultureInfo.GetCultureInfo("vi-VN");
        string maPhatSinh = null;
        int ViTriDaChon = 0;
        string MaDiaChi = null;
        private void frmQLDuAn_Load(object sender, EventArgs e)
        {
            duAnBUS = new DuAnBUS();
            dcBUS = new DiaChiBUS();
            cvBUS = new CongViecBUS();
            tlBUS = new ThaoLuanBUS();
            ccdanvBUS = new ChamCongDuAnNhanVienBUS();
            ktDuLieu = new clsKiemTra();
            bindingCongViec = new BindingSource();
            List<eDuAn> ls = new List<eDuAn>();
            ls = duAnBUS.getAllDuAn();           
            LoadeDuAnToListView(lvwDuaAn_QLDuAn, ls);
            ChonViTri(ViTriDaChon, lvwDuaAn_QLDuAn);
          
        }
        // Sau khi frm load dòng thứ viTri của listview sẽ được chọn
        //public void ChonViTri(int viTri)
        //{
         
        //    if (lvwDuaAn_QLDuAn.SelectedItems.Count > 0)
        //    {
        //        int viTriChonTruoc = lvwDuaAn_QLDuAn.SelectedIndices[0];
        //        lvwDuaAn_QLDuAn.Items[viTriChonTruoc].Selected = false;
        //    }
        //    lvwDuaAn_QLDuAn.Items[viTri].Selected = true;
        //    lvwDuaAn_QLDuAn.Focus();
        //}
        public void ChonViTri(int viTri ,ListView lvw)
        {

           if(lvw.Items.Count>0)
           {
                if (lvw.SelectedItems.Count > 0)
                {
                    int viTriChonTruoc = lvw.SelectedIndices[0];
                    lvw.Items[viTriChonTruoc].Selected = false;
                }
                lvw.Items[viTri].Selected = true;
                lvw.Focus();
           }
        }
       
        private void cboPhuong_QLDuAn_Click(object sender, EventArgs e)
        {
            cboPhuong_QLDuAn.DataSource = diaChi.QuanThuocPhuong(cboQuan_QLDuaAn.Text);
        }


        private void cboQuan_QLDuaAn_SelectedValueChanged(object sender, EventArgs e)
        {
            cboPhuong_QLDuAn.DataSource = diaChi.QuanThuocPhuong(cboQuan_QLDuaAn.Text);
        }
         //TẠO RA MỘT ITEM
        ListViewItem GreateItem(eDuAn da)
        {
           
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(da.MaDuAn);
            lvwItem.SubItems.Add(da.TenDuAn);          
            lvwItem.Tag = da;
            return lvwItem;
        }
        void LoadeDuAnToListView(ListView lvw, List<eDuAn> dseDuAn)
        {
            lvw.Items.Clear();
            ListViewItem ItemeDuAn;
            foreach (eDuAn sp in dseDuAn)
            {
                ItemeDuAn = GreateItem(sp);
                lvw.Items.Add(ItemeDuAn);
            }
        }
        //Hiển thị thông tin của dự an lên textbox
        public void ListViewToThongTinDuAn(eDuAn da, eDiaChi dc)
        {
            lblMaDuAn_QLDuAn.Text = da.MaDuAn;
            MaDiaChi = dc.MaDiaChi;
            txtTenDuAn.Text = da.TenDuAn;
            dtmNgayHoangThanh_QLDuAn.Value = da.NgayHoanThanh;
            dtmNgayKhoiCong_QLDuAn.Value = da.NgayKhoiCong;
            dtmNgayHoanThanhDuKien.Value = da.NgayHoanThanhDuKien;
            txtChuDauTu.Text = da.ChuDauTu;
            txtKinhPhiDauTu.Text = da.KinhPhiDauTu.ToString();//String.Format(info, "{0:c}", da.KinhPhiDauTu);
            List<string> lTrangThai = new List<string>();
            List<string> lLoaiCongTrinh = new List<string>();
            List<string> lThanhPho = new List<string>();
            List<string> lQuan = new List<string>();
            List<string> lPhuong = new List<string>();
            lTrangThai.Clear();
            lThanhPho.Clear();
            lQuan.Clear();
            lPhuong.Clear();
            lLoaiCongTrinh.Clear();
            lLoaiCongTrinh.Add(da.LoaiCongTrinh);
            lTrangThai.Add(da.TrangThai);
            if (da.TrangThai.Equals("Đang Thi Công"))
            {
                picNgayHT.Visible = false;
                lblNgayHT.Visible = false;
                dtmNgayHoangThanh_QLDuAn.Visible = false;
            }
            else
            {
                picNgayHT.Visible = true;
                lblNgayHT.Visible = true;
                dtmNgayHoangThanh_QLDuAn.Visible = true;
            }
            lThanhPho.Add(dc.DiaChiThanhPho);
            lQuan.Add(dc.DiaChiQuan);
            lPhuong.Add(dc.DiaChiPhuong);
            txtSoNha_QLDuAn.Text = dc.DiaChiNha;
            cboLoaiCongTrinh.DataSource = lLoaiCongTrinh;
            cboTrangThai_QLDuAn.DataSource = lTrangThai;
            cboThanhPho_QLDuAn.DataSource = lThanhPho;
            cboPhuong_QLDuAn.DataSource = lPhuong;
            cboQuan_QLDuaAn.DataSource = lQuan;

        }

        void FormatDgvCongViec(DataGridView dgv)
        {
            
            dgv.Columns["TenCongViec"].HeaderText = "Tên Công Việc";        
            dgv.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";         
            dgv.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";         
            dgv.Columns["DoUuTien"].HeaderText = "Độ Ưu Tiên";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.BackColor = Color.SeaGreen;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Columns["MaCongViec"].Visible = false;
            dgv.Columns["MaDuAn"].Visible = false;
            dgv.Columns["TenCongViec"].DisplayIndex = 0;
            dgv.Columns["NgayBatDau"].DisplayIndex = 1;
            dgv.Columns["NgayKetThuc"].DisplayIndex = 2;
            dgv.Columns["DoUuTien"].DisplayIndex = 3;
        }
        void FormatDgvNhanVien(DataGridView dgv)
        {

            dgv.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgv.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgv.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgv.Columns["MaPhongBan"].Visible = false;
            dgv.Columns["MaChucVu"].Visible = false;
            dgv.Columns["MaDiaChi"].Visible = false;
            dgv.Columns["GioiTinh"].Visible = false;
            dgv.Columns["NgaySinh"].Visible = false;
            dgv.Columns["TaiKhoan"].Visible = false;
            dgv.Columns["NguoiMoi"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackColor = Color.SeaGreen;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Columns["MaNhanVien"].DisplayIndex = 0;
            dgv.Columns["TenNhanVien"].DisplayIndex = 1;
            dgv.Columns["SoDienThoai"].DisplayIndex = 2;

        }
        void FormatDgvThaoLuan(DataGridView dgv)
        {

            dgv.Columns["MaThaoLuan"].Visible = false;
            dgv.Columns["ChuDeThaoLuan"].HeaderText = "Chủ Đề Thảo Luận";
            dgv.Columns["NoiDungThaoLuan"].HeaderText = "Nội Dung Thảo Luận";
            dgv.Columns["NgayThaoLuan"].HeaderText = "Ngày Thảo Luận";
            
            dgv.Columns["MaDuAn"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.BackColor = Color.SeaGreen;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Columns["ChuDeThaoLuan"].DisplayIndex = 0;
            dgv.Columns["NoiDungThaoLuan"].DisplayIndex = 2;
            dgv.Columns["NgayThaoLuan"].DisplayIndex = 1;
           

        }
         public void EnabledDuAn(bool a)  
         {
             lblMaDuAn_QLDuAn.Enabled = a;
             txtTenDuAn.Enabled = a;
             dtmNgayHoangThanh_QLDuAn.Enabled = a;
             dtmNgayKhoiCong_QLDuAn.Enabled = a;
             dtmNgayHoanThanhDuKien.Enabled = a;
             txtSoNha_QLDuAn.Enabled = a;
             cboTrangThai_QLDuAn.Enabled = a;
             cboThanhPho_QLDuAn.Enabled = a;
             cboPhuong_QLDuAn.Enabled = a;
             cboQuan_QLDuaAn.Enabled = a;
             cboLoaiCongTrinh.Enabled = a;
             txtKinhPhiDauTu.Enabled = a;
             txtChuDauTu.Enabled = a;

         }
         public void EnableButton(string s)
         {

             if (btnThem_QLDuAn.Text.Equals(s))
             {
                 btnPhanCong_QLDuAn.Enabled = false;
                 btnSua_QLDuAn.Enabled = false;
                 btnXoa_QLDuAn.Enabled = false;
             }
         }
         public void XoaTextDuAn()
         {
             clsPhatSinhMa psm = new clsPhatSinhMa();
             List<string> lTrangThai = new List<string>() { "Đang Thi Công", "Đã Hoàng thành"};
             List<string> lLoaiCongTrinh = new List<string>() {"Công Trình Dân Dụng","Công Trình Công Nghiệp", "Công Trinh Giao Thông", "Công Trình Hạ Tầng Kỹ Thuật"};
             maPhatSinh = psm.TaoMa();
             lblMaDuAn_QLDuAn.Text = "DA" + maPhatSinh;
             txtTenDuAn.Clear();
             dtmNgayKhoiCong_QLDuAn.Value = DateTime.Now;
             dtmNgayHoanThanhDuKien.Value = DateTime.Now;
             dtmNgayHoangThanh_QLDuAn.Value = dtmNgayHoanThanhDuKien.Value;
             txtSoNha_QLDuAn.Clear();
             txtChuDauTu.Clear();
             txtKinhPhiDauTu.Clear();
             cboTrangThai_QLDuAn.DataSource = lTrangThai;
             cboLoaiCongTrinh.DataSource = lLoaiCongTrinh;
             cboPhuong_QLDuAn.DataSource = null;           
             cboThanhPho_QLDuAn.DataSource = diaChi.LThanhPho;
             cboQuan_QLDuaAn.DataSource = diaChi.LQuanOfHoChiMinh;
             txtTenDuAn.Focus();
         
         }

        private void lvwDuaAn_QLDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDuaAn_QLDuAn.SelectedItems.Count > 0)
            {
                ViTriDaChon = lvwDuaAn_QLDuAn.SelectedIndices[0];
                eDuAn duan = (eDuAn)lvwDuaAn_QLDuAn.SelectedItems[0].Tag;
                eDiaChi dc = dcBUS.getDiaChiTheoMa(duan.MaDiaChi);
                ListViewToThongTinDuAn(duan, dc);
               
                List<eCongViec> lCongViec = cvBUS.getCongViecTheoMaDuAn(duan.MaDuAn);
                bindingCongViec.DataSource = lCongViec;
                dgvCongViec_QLDuAn.DataSource = bindingCongViec;
                bindingNavigatorCongViec.BindingSource = bindingCongViec;
                FormatDgvCongViec(dgvCongViec_QLDuAn);
                
                List<eNhanVien> lNVDA = ccdanvBUS.getNhanVienTheoMaDuAn(duan.MaDuAn);
                dgvNhanVienDuAn.DataSource = lNVDA;
                FormatDgvNhanVien(dgvNhanVienDuAn);
               
                List<eThaoLuan> lTL = tlBUS.getThaoLuanThaoMaDuAn(duan.MaDuAn);
                dgvThaoLuan_QLDuAn.DataSource = lTL;
                FormatDgvThaoLuan(dgvThaoLuan_QLDuAn);

                

            }
        }

        private void btnHuyLuu_Click(object sender, EventArgs e)
        {
            if(btnThem_QLDuAn.Text.Equals("Lưu   "))
            {
                btnThem_QLDuAn.Text = "Thêm";
                btnHuyLuu.Visible = false;
                EnabledDuAn(false);
                btnPhanCong_QLDuAn.Enabled = true;
                btnSua_QLDuAn.Enabled = true;
                btnXoa_QLDuAn.Enabled = true;
                ChonViTri(ViTriDaChon, lvwDuaAn_QLDuAn);
            }
            if(btnSua_QLDuAn.Text.Equals("Lưu   ") )
            {
                btnSua_QLDuAn.Text = "Sửa  ";
                btnHuyLuu.Visible = false;
                EnabledDuAn(false);
                btnPhanCong_QLDuAn.Enabled = true;
                btnThem_QLDuAn.Enabled = true;
                btnXoa_QLDuAn.Enabled = true;
                ChonViTri(ViTriDaChon, lvwDuaAn_QLDuAn);
            }
            
        }

        private void btnXoa_QLDuAn_Click(object sender, EventArgs e)
        {
            btnSua_QLDuAn.Enabled = false;
            btnPhanCong_QLDuAn.Enabled = false;
            btnThem_QLDuAn.Enabled = false;
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn chắc xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                eDuAn duan = (eDuAn)lvwDuaAn_QLDuAn.SelectedItems[0].Tag;
                string ma = duan.MaDiaChi;
                if (dcBUS.xoaDiaChi(duan.MaDiaChi))
                {
                    MessageBox.Show("Xóa thành công");
                    List<eDuAn> ls = new List<eDuAn>();
                    ls = duAnBUS.getAllDuAn();
                    LoadeDuAnToListView(lvwDuaAn_QLDuAn, ls);
                    ChonViTri(0, lvwDuaAn_QLDuAn);

                }
                else MessageBox.Show("Xóa thất bại");
                btnSua_QLDuAn.Enabled = true;
                btnPhanCong_QLDuAn.Enabled = true;
                btnThem_QLDuAn.Enabled = true;
            }
            else
            {
                btnSua_QLDuAn.Enabled = true;
                btnPhanCong_QLDuAn.Enabled = true;
                btnThem_QLDuAn.Enabled = true;
            }
            
        }

        private void btnSua_QLDuAn_Click(object sender, EventArgs e)
        {
            Label btnTemp = (Label)sender;
            EnableButton(btnTemp.Text);
            if (btnSua_QLDuAn.Text.Equals("Sửa  "))
            {
                EnabledDuAn(true);
                List<string> lTrangThai = new List<string>() { "Đang Thi Công", "Đã Hoàng thành" };
                cboTrangThai_QLDuAn.DataSource = lTrangThai;
                cboThanhPho_QLDuAn.DataSource = diaChi.LThanhPho;
                cboQuan_QLDuaAn.DataSource = diaChi.LQuanOfHoChiMinh;
                btnHuyLuu.Visible = true;
                btnSua_QLDuAn.Text = "Lưu   ";
                btnPhanCong_QLDuAn.Enabled = false;
                btnThem_QLDuAn.Enabled = false;
                btnXoa_QLDuAn.Enabled = false;                
            }
            else
            {
                if (txtTenDuAn.Text.Length != 0 && txtChuDauTu.Text.Length != 0 && txtKinhPhiDauTu.Text.Length != 0 && txtSoNha_QLDuAn.Text.Length != 0 && ktDuLieu.CheckMoney(txtKinhPhiDauTu.Text))
                {
                    eDiaChi dc = new eDiaChi(MaDiaChi, cboThanhPho_QLDuAn.Text,
                    cboQuan_QLDuaAn.Text, cboPhuong_QLDuAn.Text, txtSoNha_QLDuAn.Text);
                    dcBUS.suaDiaChi(dc);
                    eDuAn da = new eDuAn(lblMaDuAn_QLDuAn.Text, txtTenDuAn.Text, MaDiaChi, cboTrangThai_QLDuAn.Text, cboLoaiCongTrinh.Text,
                    txtChuDauTu.Text, Convert.ToDecimal(txtKinhPhiDauTu.Text), dtmNgayHoangThanh_QLDuAn.Value, dtmNgayKhoiCong_QLDuAn.Value, dtmNgayHoanThanhDuKien.Value);
                    if (duAnBUS.suaDuAn(da)) MessageBox.Show("Sửa thành công dự án");
                    else MessageBox.Show("Sửa dự án thất bại");
                    EnabledDuAn(false);
                    List<eDuAn> ls = new List<eDuAn>();
                    ls = duAnBUS.getAllDuAn();
                    LoadeDuAnToListView(lvwDuaAn_QLDuAn, ls);
                    ChonViTri(ViTriDaChon, lvwDuaAn_QLDuAn);
                    btnHuyLuu.Visible = false;
                    btnPhanCong_QLDuAn.Enabled = true;
                    btnThem_QLDuAn.Enabled = true;
                    btnXoa_QLDuAn.Enabled = true;
                    btnSua_QLDuAn.Text = "Sửa  ";
                }
                else
                {
                    errorProvider.Clear();
                    if (txtSoNha_QLDuAn.Text.Length == 0)
                    {
                        txtTenDuAn.Focus();
                        MessageBox.Show("Không được để trống Tên dự án");
                        errorProvider.SetError(txtTenDuAn, "Không để trống dự án");
                    }
                    else if (txtTenDuAn.Text.Length == 0)
                    {
                        txtChuDauTu.Focus();
                        MessageBox.Show("Không được để trống chủ đầu tư");
                        errorProvider.SetError(txtChuDauTu, "Không để trống");
                    }
                    else if (txtKinhPhiDauTu.Text.Length == 0)
                    {
                        MessageBox.Show("Không được để trống Kinh phí đầu từ");
                        txtKinhPhiDauTu.Focus();
                        errorProvider.SetError(txtKinhPhiDauTu, "Không để trống");
                    }
                    else if (txtChuDauTu.Text.Length == 0)
                    {
                        txtSoNha_QLDuAn.Focus();
                        MessageBox.Show("Không được để trống số nhà");
                        errorProvider.SetError(txtSoNha_QLDuAn, "Không để trống");
                    }
                    else if (!ktDuLieu.CheckMoney(txtKinhPhiDauTu.Text))
                    {
                        txtKinhPhiDauTu.Focus();
                        errorProvider.SetError(txtKinhPhiDauTu, "Nhập số và Số tiền cần đạt đến hàng triệu");
                    }
          
                }
                
            }
        }

        private void btnThem_QLDuAn_Click(object sender, EventArgs e)
        {
            Label btnTemp = (Label)sender;
            btnPhanCong_QLDuAn.Enabled = false;
            btnSua_QLDuAn.Enabled = false;
            btnXoa_QLDuAn.Enabled = false;
            txtTenDuAn.Focus();
            if (btnThem_QLDuAn.Text.Equals("Lưu   "))
            {

                if (txtTenDuAn.Text.Length != 0 && txtChuDauTu.Text.Length != 0 && txtKinhPhiDauTu.Text.Length != 0 && txtSoNha_QLDuAn.Text.Length != 0 && ktDuLieu.CheckMoney(txtKinhPhiDauTu.Text))
               {
                string maDC = "DC" + maPhatSinh;
                string a = txtSoNha_QLDuAn.Text;
                eDiaChi dc = new eDiaChi(maDC, cboThanhPho_QLDuAn.Text, cboQuan_QLDuaAn.Text, cboPhuong_QLDuAn.Text, txtSoNha_QLDuAn.Text);
                dcBUS.themDiaChi(dc);
           
                eDuAn da = new eDuAn(lblMaDuAn_QLDuAn.Text, txtTenDuAn.Text, maDC, cboTrangThai_QLDuAn.Text,
                    cboLoaiCongTrinh.Text, txtChuDauTu.Text, Convert.ToDecimal(txtKinhPhiDauTu.Text), 
                    dtmNgayHoangThanh_QLDuAn.Value, dtmNgayKhoiCong_QLDuAn.Value, dtmNgayHoanThanhDuKien.Value);
                if (duAnBUS.themDuAn(da))
                {
                    MessageBox.Show("Tạo thành công dự án");
                } 
                else
                {
                    MessageBox.Show("Tạo dự án thất bại");
                }
                btnThem_QLDuAn.Text = "Thêm";
                EnabledDuAn(false);
                List<eDuAn> ls = new List<eDuAn>();
                ls = duAnBUS.getAllDuAn();
                LoadeDuAnToListView(lvwDuaAn_QLDuAn, ls);
                ChonViTri(lvwDuaAn_QLDuAn.Items.Count - 1, lvwDuaAn_QLDuAn);
                btnHuyLuu.Visible = false;
                btnPhanCong_QLDuAn.Enabled = true;
                btnSua_QLDuAn.Enabled = true;
                btnXoa_QLDuAn.Enabled = true;
               }
               else
               {
                   errorProvider.Clear();                   
                   if (txtSoNha_QLDuAn.Text.Length == 0)
                   {
                       txtTenDuAn.Focus();
                       MessageBox.Show("Không được để trống Tên dự án");
                       errorProvider.SetError(txtTenDuAn, "Không để trống dự án");
                   }
                   else if (txtTenDuAn.Text.Length == 0)
                   {
                       txtChuDauTu.Focus();
                       MessageBox.Show("Không được để trống chủ đầu tư");
                       errorProvider.SetError(txtChuDauTu, "Không để trống");
                   }
                   else if (txtKinhPhiDauTu.Text.Length == 0)
                   {
                       MessageBox.Show("Không được để trống Kinh phí đầu từ");
                       txtKinhPhiDauTu.Focus();
                       errorProvider.SetError(txtKinhPhiDauTu, "Không để trống");
                   }
                   else if (txtChuDauTu.Text.Length == 0)
                   {
                       txtSoNha_QLDuAn.Focus();
                       MessageBox.Show("Không được để trống số nhà");
                       errorProvider.SetError(txtSoNha_QLDuAn, "Không để trống");
                   }
                   else if (!ktDuLieu.CheckMoney(txtKinhPhiDauTu.Text))
                   {
                       txtKinhPhiDauTu.Focus();
                       errorProvider.SetError(txtKinhPhiDauTu, "Nhập số và Số tiền cần đạt đến hàng triệu");
                   }
             
               }

            }
            else
            {
                EnabledDuAn(true);
                XoaTextDuAn();
                btnThem_QLDuAn.Text = "Lưu   ";
                btnHuyLuu.Visible = true;
            }


        }

        private void btnPhanCong_QLDuAn_Click(object sender, EventArgs e)
        {

            VSReactive<string>.SetState("MaDuAnFormFrmQLDA", lblMaDuAn_QLDuAn.Text);
            VSReactive<string>.SetState("TenDuAnFormFrmQLDA", txtTenDuAn.Text);
            VSReactive<string>.SetState("NgayKhoiCongFormFrmQLDA", dtmNgayKhoiCong_QLDuAn.Value.ToString("dd/MM/yyyy"));
            VSReactive<string>.SetState("TrangThaiFormFrmQLDA", cboTrangThai_QLDuAn.Text);
            VSReactive<string>.SetState("DiaDiemFormFrmQLDA", cboThanhPho_QLDuAn.Text +", "+ cboQuan_QLDuaAn.Text+", "+ cboPhuong_QLDuAn.Text +", "+ txtSoNha_QLDuAn.Text);
            frmThemNhanVienDuAn frm = new frmThemNhanVienDuAn();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                List<eNhanVien> lNVDA = ccdanvBUS.getNhanVienTheoMaDuAn(lblMaDuAn_QLDuAn.Text);
                dgvNhanVienDuAn.DataSource = lNVDA;
                FormatDgvNhanVien(dgvNhanVienDuAn);
            }
                   
        }

        private void txtTenDuAn_Leave(object sender, EventArgs e)
        {
            errorProvider.Clear();           
            if (txtTenDuAn.Text.Length == 0)
            {
                txtTenDuAn.Focus();
                errorProvider.SetError(txtTenDuAn, "Không để trống");
                

            }
        }

        private void txtKinhPhiDauTu_Leave(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txtKinhPhiDauTu.Text.Length == 0)
            {
                txtKinhPhiDauTu.Focus();
                errorProvider.SetError(txtKinhPhiDauTu, "Không để trống");

            }
            if(!ktDuLieu.CheckMoney(txtKinhPhiDauTu.Text))
            {
                txtKinhPhiDauTu.Focus();
                errorProvider.SetError(txtKinhPhiDauTu, "Nhập số và Số tiền cần đạt đến hàng triệu");
            }
           
        }

        private void txtChuDauTu_Leave(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txtChuDauTu.Text.Length == 0)
            {
                txtChuDauTu.Focus();
                errorProvider.SetError(txtChuDauTu, "Không để trống");


            }
        }

        private void txtSoNha_QLDuAn_Leave(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txtSoNha_QLDuAn.Text.Length == 0)
            {
                txtSoNha_QLDuAn.Focus();
                errorProvider.SetError(txtSoNha_QLDuAn, "Không để trống");
            }
        }

        private void cboTrangThai_QLDuAn_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboTrangThai_QLDuAn.Text.Equals("Đã Hoàng thành"))
            {
                picNgayHT.Visible = true;
                lblNgayHT.Visible = true;
                dtmNgayHoangThanh_QLDuAn.Visible = true;
            }
            else
            {
                picNgayHT.Visible = false;
                lblNgayHT.Visible = false;
                dtmNgayHoangThanh_QLDuAn.Visible = false;
            }
        }

       
       
       
    }
}
