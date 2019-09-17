using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLiNhanSu
{
    public partial class FormDangNhap : Form
    {
       
        public FormDangNhap()
        {
            InitializeComponent();
           
         
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtQLNS_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
               // conn.Open();
                string tk = txtDanhNhap.Text;
                string mk = txtMatKhau.Text;

                if (ConnectDatabase.Login(tk, mk))
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK);
                    this.Hide();
                    Program.usernamelogin = tk;
                    Program.frMain_main = new frmMain();
                    Program.frMain_main.Show();
                   
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập lỗi");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDanhNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
