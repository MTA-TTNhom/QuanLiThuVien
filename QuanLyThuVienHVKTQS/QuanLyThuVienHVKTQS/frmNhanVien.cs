﻿using System;
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
    public partial class frmNhanVien : Form
    {
        List<nhanvien> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = false;
        public frmNhanVien()
        {
            InitializeComponent();
            HienthiNV();
        }
        public void btn_edit(bool t)
        {
            groupedit_NV.Enabled = t;
            ThemNV.Enabled = !t;
            SuaNV.Enabled = !t;
            XoaNV.Enabled = !t;
            LuuNV.Enabled = t;
            BoquaNV.Enabled = t;
            Them_bool = false;
            Sua_bool = false;
        }
        public void HienthiNV()
        {

            var nv = new NhanVienController();
            l = nv.Detail();
            listView_NV.Items.Clear();
            var i = 1;

            manvtxt.Text = l[0].manv.ToString();
            tennvtxt.Text = l[0].tennv.ToString();
            ngaysinhnv.Text = l[0].ngaysinh.ToString();
            if (l[0].gioitinh == null) gioitinhtxt.Text = "";
            else gioitinhtxt.Text = l[0].gioitinh.ToString();
            if (l[0].sdt == null) sdttxt.Text = "";
            else sdttxt.Text = l[0].sdt.ToString();
            if (l[0].diachi == null) diachitxt.Text = "";
            else diachitxt.Text = l[0].diachi.ToString();
            if (l[0].socmtnd == null) socmtndtxt.Text = "";
            else socmtndtxt.Text = l[0].socmtnd.ToString();
            if (l[0].quyenhan == null) quyenhantxt.Text = "";
            else quyenhantxt.Text = l[0].quyenhan.ToString();

            foreach (nhanvien row in l)
            {
                ListViewItem item = new ListViewItem();

                item.Text = "" + i++;
                item.SubItems.Add(row.manv.ToString());
                item.SubItems.Add(row.tennv.ToString());
                item.SubItems.Add(row.diachi.ToString());
                item.SubItems.Add(row.sdt.ToString());
                listView_NV.Items.Add(item);
            }
            if (PhanQuyen.quyen == 1)
                btn_edit(false);
            else
            {
                groupedit_NV.Enabled = false;
                ThemNV.Enabled = SuaNV.Enabled = XoaNV.Enabled = LuuNV.Enabled = BoquaNV.Enabled = false;
                Thoat.Enabled = true;
            }

        }

    }
}
