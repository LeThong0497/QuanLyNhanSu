using BUS;
using Entities;
using KimtToo.VisualReactive;
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
    public partial class frmThemNhanVienDuAn : Form
    {
        public frmThemNhanVienDuAn()
        {
            InitializeComponent();
        }
        int ViTriDaChonL = 0;
        int ViTriDaChonR = 0;
        ChamCongDuAnNhanVienBUS ccdanvBUS;
        List<eNhanVien> lNhanVienKhongThamGiaDuAn;
        List<eNhanVien> lNhanVienThamGiaDuAn;
        eNhanVien nv, nvtempL, nvtempR;
        List<eNhanVien> lXoa;
        List<eNhanVien> lThem;
        BangChamCongBUS bccBUS;
        bool checkLuu = true;
        private void txtTiKiDuAnOfChamCong_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            string str ="";
            if(!checkLuu)
            {
                str = "Chưa lưu thay đổi vẫn thoát";
            }
            else
            {
                 str = "Thoát khỏi màn hình hiện tại";
            }
            DialogResult dialogResult = MessageBox.Show(str, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.Close();
            
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ListViewItem GreateItem(eNhanVien nv)
        {

            ListViewItem lvwItem;
            lvwItem = new ListViewItem(nv.MaNhanVien);
            lvwItem.SubItems.Add(nv.TenNhanVien);
            lvwItem.Tag = nv;
            return lvwItem;
        }
        void LoadeNhanVienToListView(ListView lvw, List<eNhanVien> dsNhaVien)
        {
            lvw.Items.Clear();
            ListViewItem ItemeDuAn;
            foreach (eNhanVien nv in dsNhaVien)
            {
                ItemeDuAn = GreateItem(nv);
                lvw.Items.Add(ItemeDuAn);
            }
        }

        private void frmThemNhanVienDuAn_Load(object sender, EventArgs e)
        {
            lXoa = new List<eNhanVien>();
            lThem = new List<eNhanVien>();
            nv = new eNhanVien();
            nvtempL = new eNhanVien();
            nvtempR = new eNhanVien();
            ccdanvBUS = new ChamCongDuAnNhanVienBUS();
            lNhanVienKhongThamGiaDuAn = new List<eNhanVien>();
            lNhanVienThamGiaDuAn = new List<eNhanVien>();
            bccBUS = new BangChamCongBUS();
            lblTenDuAn.Text = VSReactive<string>.GetState("TenDuAnFormFrmQLDA");
            lblTrangThai.Text = VSReactive<string>.GetState("TrangThaiFormFrmQLDA");
            lblNgayKhoiCong.Text = VSReactive<string>.GetState("NgayKhoiCongFormFrmQLDA");
            lblDiaChi.Text = VSReactive<string>.GetState("DiaDiemFormFrmQLDA");
            lNhanVienThamGiaDuAn = ccdanvBUS.getNhanVienTheoMaDuAn(VSReactive<string>.GetState("MaDuAnFormFrmQLDA"));
            LoadeNhanVienToListView(lvwNhanVienThamGiaDuAn, lNhanVienThamGiaDuAn);
            lNhanVienKhongThamGiaDuAn = ccdanvBUS.getNhanVienKhongThuocMaDuAn(VSReactive<string>.GetState("MaDuAnFormFrmQLDA"));
            LoadeNhanVienToListView(lvwNhanVienChuaThamGiaDuAn, lNhanVienKhongThamGiaDuAn);
            lvwNhanVienThamGiaDuAn.Focus();
            btnThemNhanVien.Enabled = false;
            btnXoaNhanVien.Enabled = false;
            btnLuu.Enabled = false;
            
        }
       
        private void lvwNVTrongDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {           
                if(lvwNhanVienThamGiaDuAn.SelectedItems.Count>0)
                {
                    ViTriDaChonL = lvwNhanVienThamGiaDuAn.SelectedIndices[0];
                    nv = (eNhanVien)lvwNhanVienThamGiaDuAn.SelectedItems[0].Tag;
                } 
        }

        private void lvwNhanVienChuaThamGiaDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNhanVienChuaThamGiaDuAn.SelectedItems.Count > 0)
            {
                ViTriDaChonR = lvwNhanVienChuaThamGiaDuAn.SelectedIndices[0];
                nv = (eNhanVien)lvwNhanVienChuaThamGiaDuAn.SelectedItems[0].Tag;
            }
        }

        public void ChonViTri(int viTri, ListView lvw)
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
       
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            int index = 0; checkLuu = false;
              index = lNhanVienKhongThamGiaDuAn.Count-1;    
              if(lNhanVienKhongThamGiaDuAn[index]==nv)
              {
                  MessageBox.Show("Vui lòng chọn nhân viên để thực hiện thao tác");
              }
              else
              {
              
                  lNhanVienKhongThamGiaDuAn.Add(nv);
                  lNhanVienThamGiaDuAn.Remove(nv);
                  LoadeNhanVienToListView(lvwNhanVienChuaThamGiaDuAn, lNhanVienKhongThamGiaDuAn);
                  LoadeNhanVienToListView(lvwNhanVienThamGiaDuAn, lNhanVienThamGiaDuAn);
              }
            
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
       {
            int index = 0; checkLuu = false;
            index = lNhanVienThamGiaDuAn.Count - 1;        
            if (index>=0)
            {
                if(lNhanVienThamGiaDuAn[index] == nv )
                    MessageBox.Show("Vui lòng chọn nhân viên để thực hiện thao tác");
            }            
                lNhanVienKhongThamGiaDuAn.Remove(nv);
                lNhanVienThamGiaDuAn.Add(nv);
                LoadeNhanVienToListView(lvwNhanVienChuaThamGiaDuAn, lNhanVienKhongThamGiaDuAn);
                LoadeNhanVienToListView(lvwNhanVienThamGiaDuAn, lNhanVienThamGiaDuAn);
        
        }

       

        private void lvwNVTrongDuAn_Click(object sender, EventArgs e)
        {
            btnThemNhanVien.Enabled = false; 
            btnXoaNhanVien.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void lvwNVChuaTGDuAn_Click(object sender, EventArgs e)
        {
            btnXoaNhanVien.Enabled = false;
            btnThemNhanVien.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check1= true, check2 = true;
            foreach (eNhanVien nv in lNhanVienThamGiaDuAn)
            {
                    if(nv.NguoiMoi)
                    {
                       check1 = bccBUS.themNhanVienVaoDuAn(nv.MaNhanVien, VSReactive<string>.GetState("MaDuAnFormFrmQLDA"));
                    }
            }
            foreach (eNhanVien nv in lNhanVienKhongThamGiaDuAn)
            {
                if (!nv.NguoiMoi)
                {
                   check2 = bccBUS.xoaNhanVienKhoiDuAn(nv.MaNhanVien, VSReactive<string>.GetState("MaDuAnFormFrmQLDA"));
                }
            }
            checkLuu = true;
            if (check2 && check1) MessageBox.Show("Thay đổi thành công");
            else MessageBox.Show("Thay đổi thất bại");
        }

        private void frmThemNhanVienDuAn_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            this.DialogResult = DialogResult.OK;
        }
     
    }
}
