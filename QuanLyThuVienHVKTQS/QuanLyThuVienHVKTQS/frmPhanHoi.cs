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
    public partial class frmPhanHoi : Form
    {
        public frmPhanHoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPhanHoi close = new frmPhanHoi();
            close.Hide();
            frmMain open = new frmMain();
            open.Show();
        }
    }
}
