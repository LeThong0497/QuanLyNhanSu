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


namespace QUANLYNHANSU
{
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }
        
        DuAnBUS duanBUS;
        DiaChiBUS dcBUS;
        ChamCongDuAnNhanVienBUS ccdanvBUS;
        int ViTriDaChon = 0;
        string MaDuAn = "";
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            duanBUS = new DuAnBUS();
            dcBUS = new DiaChiBUS();
            ccdanvBUS = new ChamCongDuAnNhanVienBUS();
            List<eDuAn> ls = new List<eDuAn>();
            ls = duanBUS.getAllDuAn();
            LoadeDuAnToListView(lvwDuAn_ChamCong, ls);
            ChonViTri(ViTriDaChon, lvwDuAn_ChamCong);
            
        }
        public void ChonViTri(int viTri, ListView lvw)
        {

            if (lvw.Items.Count > 0)
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
        public void ListViewToThongTinDuAn(eDuAn da, eDiaChi dc)
        {
            lblTenDuAn.Text = da.TenDuAn;
            lblNgayKhoiCong_ChamCong.Text = da.NgayKhoiCong.ToString("dd/MM/yyyy");
            lblTrangThai_ChamCong.Text = da.TrangThai;
            lblDiaChi_ChamCong.Text = dc.DiaChiThanhPho + ", " + dc.DiaChiQuan + ", " + dc.DiaChiPhuong + ", " + dc.DiaChiNha;
        }
        void LoadChamCong(List<eChamCongNhanVienDuAn> ls)
        {
            flowLayoutPanel_ChamCong.Controls.Clear();
            foreach (var item in ls)
            {             
                   UserControlNgayCong us = new UserControlNgayCong();
                   us.SoNgayCong = item.SoNgayCong;
                   us.TenNhanVien = item.TenNhanVien;
                   us.TenChucVu = item.TenChucVu;
                   us.MaNhanVien = item.MaNhanVien;
                   us.Tag = item.NgayChamCong;
                   us.Padding = new System.Windows.Forms.Padding(-1, 0, 0, 0);
                   if(item.NgayChamCong.Day == DateTime.Now.Day)
                   {
                       us.BackColor = Color.SeaGreen;
                   }
                
                   flowLayoutPanel_ChamCong.Controls.Add(us);             
            }
        }

        private void lvwDuAn_ChamCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDuAn_ChamCong.SelectedItems.Count > 0)
            {
                ViTriDaChon = lvwDuAn_ChamCong.SelectedIndices[0];
                eDuAn duan = (eDuAn)lvwDuAn_ChamCong.SelectedItems[0].Tag;
                eDiaChi dc = dcBUS.getDiaChiTheoMa(duan.MaDiaChi);
                List<eChamCongNhanVienDuAn> lChamCongNhanVienDuAn = ccdanvBUS.getNgayCongNhanVienTheoMaDuAn(duan.MaDuAn);
                MaDuAn = duan.MaDuAn;
                LoadChamCong(lChamCongNhanVienDuAn);
                ListViewToThongTinDuAn(duan, dc);
            }
        }

        private void btnLuuOfChamCong_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (Control item in flowLayoutPanel_ChamCong.Controls)
            {
                DateTime dt = (DateTime)item.Tag;
                if(dt.Day == DateTime.Now.Day)
                {
                    UserControlNgayCong us = (UserControlNgayCong)item;
                    eBangChamCong bcc = new eBangChamCong();
                    bcc.MaNhanVien = us.MaNhanVien;
                    bcc.MaDuAn = MaDuAn;
                    bcc.SoNgayCong = us.SoNgayCong;
                    bcc.ThangChamCong = DateTime.Now;
                    check = ccdanvBUS.suaNgayCong(bcc); 
                }
                                   
            }
            if(check)
            {
                MessageBox.Show("Sử ngày công thành công");
            }
            List<eChamCongNhanVienDuAn> lChamCongNhanVienDuAn = ccdanvBUS.getNgayCongNhanVienTheoMaDuAn(MaDuAn);        
            LoadChamCong(lChamCongNhanVienDuAn);
        }
    }
}
