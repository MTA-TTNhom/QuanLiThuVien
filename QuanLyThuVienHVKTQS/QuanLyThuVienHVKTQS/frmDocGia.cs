using QuanLyThuVienHVKTQS.controller;
using QuanLyThuVienHVKTQS.Model;
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
    public partial class frmDocGia : Form
    {
        List<docgia> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = false;
        public frmDocGia()
        {
            InitializeComponent();
            HienThi_DG();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void HienThi_DG()
        {
            var dg = new DocGiaController();
            l = dg.Detail();
            listView_DG.Items.Clear();
            int i = 1;

            sothetxt.Text = l[0].sothe.ToString();
            tendgtxt.Text = l[0].hoten.ToString();
            ngaysinhdg.Text = l[0].ngaysinh.ToString();
            if (l[0].gioitinh == null) gioitinhdgtxt.Text = "";
            else gioitinhdgtxt.Text = l[0].gioitinh.ToString();
            if (l[0].email == null) emaildgtxt.Text = "";
            else emaildgtxt.Text = l[0].email.ToString();
            if (l[0].diachi == null) diachidgtxt.Text = "";
            else diachidgtxt.Text = l[0].diachi.ToString();
            if (l[0].socmtnd == null) socmtnddgtxt.Text = "";
            else socmtnddgtxt.Text = l[0].socmtnd.ToString();
            if (l[0].ngaylamthe == null) ngaythedg.Text = "";
            else ngaythedg.Text = l[0].ngaylamthe.ToString();
            if (l[0].handungthe == null) hanthedg.Text = "";
            else hanthedg.Text = l[0].handungthe.ToString();
            foreach (var row in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(row.sothe.ToString());
                item.SubItems.Add(row.hoten.ToString());
                item.SubItems.Add(row.ngaysinh.ToString());
                item.SubItems.Add(row.ngaylamthe.ToString());

                listView_DG.Items.Add(item);
            }
            if (PhanQuyen.quyen == 1)
                btn_enable(false);
            else
            {
                groupDG.Enabled = false;
                Them_DG.Enabled = Sua_DG.Enabled = Xoa_DG.Enabled = Luu_DG.Enabled = Boqua_DG.Enabled = false;
                Thoat_DG.Enabled = true;
            }
        }
        public void btn_enable(bool t)
        {
            groupDG.Enabled = t;
            Them_DG.Enabled = !t;
            Sua_DG.Enabled = !t;
            Xoa_DG.Enabled = !t;
            Luu_DG.Enabled = t;
            Boqua_DG.Enabled = t;
            Them_bool = false;
            Sua_bool = false;
        }

    }
}
