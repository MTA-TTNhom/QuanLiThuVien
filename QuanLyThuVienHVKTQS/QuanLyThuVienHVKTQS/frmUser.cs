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
    public partial class frmUser : Form
    {
        private bool Them_bool=false;
        private bool Sua_bool=false;
        List<User> l = null;
        public frmUser()
        {
            InitializeComponent();
       
        }
        public void btn_enable(bool t)
        {
           
        }
        public void HienThi_User()
        {
            
         
            btn_enable(false);
        }

        public void ListView_User_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
     
    }
}
