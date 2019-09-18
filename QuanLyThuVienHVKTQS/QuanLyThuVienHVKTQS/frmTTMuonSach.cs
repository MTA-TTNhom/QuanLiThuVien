using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienHVKTQS
{
    public partial class frmTTMuonSach : Form
    {
        List<sach> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = false;
        public frmTTMuonSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void HienThiSach()
        {
            var s = new SachController();
            l = s.Detail();
            lvSach.Items.Clear();

            var i = 1;

            var nxb = new NhaXuatBanController();
            List<nhaxuatban> listNXB = nxb.Detail();

            cbbNXB.DataSource = listNXB;
            cbbNXB.DisplayMember = "tennxb";
            cbbNXB.ValueMember = "manxb".ToString();

            txtMaSach.Text = l[0].masach.ToString();
            txtTenSach.Text = l[0].tensach.ToString();
            txtTacGia.Text = l[0].tentacgia.ToString();
            if (l[0].nhaxuatban != null)
                cbbNXB.Text = l[0].nhaxuatban.tennxb.ToString();
            else
                cbbNXB.Text = "";
            txtNamXB.Text = l[0].namxb.ToString();
            txtSoTrang.Text = l[0].sotrang.ToString();
            txtGiaTien.Text = l[0].giatien.ToString();
            txtSoLuong.Text = l[0].soluong.ToString();
            txtNgonNgu.Text = l[0].ngonngu.ToString();
            txtTheLoai.Text = l[0].theloai.ToString();
            foreach (sach row in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;

                item.SubItems.Add(row.masach.ToString());
                item.SubItems.Add(row.tensach.ToString());
                item.SubItems.Add(row.theloai.ToString());
                item.SubItems.Add(row.ngonngu.ToString());
                item.SubItems.Add(row.soluong.ToString());

                lvSach.Items.Add(item);
            }
            if (PhanQuyen.quyen == 1)
                btn_edit(false);
            else
            {
                grpEdit.Enabled = false;
                btnThemSach.Enabled = btnSuaSach.Enabled = btnXoaSach.Enabled = btnLuuSach.Enabled = btnBoQua.Enabled = false;
                btnThoat.Enabled = true;
            }
        }
        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count == 0)
                return;
            int i = Convert.ToInt32(lvSach.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.masach == i);
            txtMaSach.Text = l[index].masach.ToString();
            txtTenSach.Text = l[index].tensach.ToString();
            txtTacGia.Text = l[index].tentacgia.ToString();
            if (l[index].manxb != null)
                cbbNXB.Text = l[index].nhaxuatban.tennxb.ToString();
            else
                cbbNXB.Text = "";
            txtNamXB.Text = l[index].namxb.ToString();
            txtSoTrang.Text = l[index].sotrang.ToString();
            txtGiaTien.Text = l[index].giatien.ToString();
            txtSoLuong.Text = l[index].soluong.ToString();
            txtNgonNgu.Text = l[index].ngonngu.ToString();
            txtTheLoai.Text = l[index].theloai.ToString();

        }
    }
}
