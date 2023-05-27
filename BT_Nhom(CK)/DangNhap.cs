using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Nhom_CK_
{
    public partial class DangNhap : Form
    {
        
        public DangNhap()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }
       
        SqlDataReader reader;
        SqlConnection conn = new SqlConnection("Data Source=KHANG\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void reset()
        {
            txtusername.Text = "";
            txtpass.Text = "";
            txtusername.Focus();
        }
        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            errusername.Clear();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            int a = 0, b = 0;
            if(txtusername.Text =="" )
            {
                errusername.SetError(txtusername, "Chưa Nhập UserName");
                a = 1;
            }
            if(txtpass.Text == "")
            {
                errpass.SetError(txtpass, "Chưa Nhập Pass");
                b = 1;
            }
            if (a == 0 || b == 0)
            {

                string query = "select * from TaiKhoan where Username='"+txtusername.Text.Trim()+"' and Pass='"+txtpass.Text.Trim()+"' and quyen = 0";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    sinhvien sv=new sinhvien(txtusername.Text,txtpass.Text);
                    sv.ShowDialog();             
                }
                else
                {
                    MessageBox.Show("Khong tim thay tai khoan ");
                }       
                reset();
                conn.Close();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
            
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Chương Trình", "Luu y", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            errpass.Clear();
        }

        private void trangchuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTrangChu fTrangChu = new fTrangChu();
            fTrangChu.Show();
        }
    }
}
