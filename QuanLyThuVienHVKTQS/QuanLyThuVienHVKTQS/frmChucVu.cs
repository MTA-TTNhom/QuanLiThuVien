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
    public partial class frmChucVu : Form
    {

        public frmChucVu()
        {
            InitializeComponent();
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
           

      
        private void btnThemPB_Click(object sender, EventArgs e)
        {       }
            
  
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();


        }

        private void dgvCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void txtMaCV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTenCV_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnNhaplai_Click_2(object sender, EventArgs e)
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemCV_Click_1(object sender, EventArgs e)
        {
            frmThemCV form = new frmThemCV();
            form.Show();

            
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            ChucVu temp = new ChucVu(txtTenCV.Text, txtMaCV.Text);
            ConnectDatabase.SuaChucVu(temp);
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
            MessageBox.Show("Sửa chức vụ thành công!!");
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            ChucVu temp = new ChucVu(txtMaCV.Text, txtTenCV.Text);
            ConnectDatabase.XoaChucVu(temp);
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
            MessageBox.Show("Xóa Thành Công Chức Vụ!!!");
        }
        
        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.frMain_main.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            dgvCV.DataSource = ConnectDatabase.TimKiemChucVu(txtTimKiem.Text);
        }


        

        private void btnHienThi_Click_1(object sender, EventArgs e)
        {
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void cboThongKe_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //ComboBox temp = sender as ComboBox;
            //string tencv = ((temp.SelectedValue) as DataRowView).Row[0].ToString();

            //string sql = "select TenCV,count(MaNV) as N'Số lượng nhân viên' from NHANVIEN_CHUCVU n, CHUCVU c where TenCV=@tencv and n.MaCV=c.MaCV group by TenCV";

            //DataTable dt = new DataTable();
            //using (SqlCommand command = new SqlCommand(sql, conn))
            //{
            //    command.Parameters.Add(new SqlParameter("@tencv", tencv));

            //    SqlDataAdapter da = new SqlDataAdapter(command);
            //    da.Fill(dt);


            //}
            //dgvCV.DataSource = dt;
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void dgvCV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaCV.Text = row.Cells[0].Value.ToString();
                txtTenCV.Text = row.Cells[1].Value.ToString();

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
 }


