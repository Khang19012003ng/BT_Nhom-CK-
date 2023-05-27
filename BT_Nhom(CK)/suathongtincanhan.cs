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
    public partial class suathongtincanhan : Form
    {
        private string username;
        private string pass;
        public suathongtincanhan()
        {
            InitializeComponent();
              
        }
        public suathongtincanhan(string username,string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        SqlConnection conn = new SqlConnection("Data Source=KHANG\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void suathongtincanhan_Load(object sender, EventArgs e)
        {
            txtmasv.Enabled = false;
            txthoten.Enabled = false;
            txtlop.Enabled = false;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            string query = "select * from SinhVien where MaSinhVien='" + this.username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtmasv.Text = dt.Rows[0]["MaSinhVien"].ToString();
                txthoten.Text = dt.Rows[0]["Hoten"].ToString();
                txtlop.Text = dt.Rows[0]["TenLop"].ToString();
                txtquequan.Text = dt.Rows[0]["QueQuan"].ToString();
                txtnoisinh.Text = dt.Rows[0]["NoiSinh"].ToString();
                if (dt.Rows[0]["GioiTinh"].ToString().Equals("NAM")){
                    rbonam.Checked = true;
                    rbonu.Checked = false;
                }
                else
                {
                    rbonu.Checked= true;
                    rbonam.Checked= false;
                }
                dtpngaysinh.Value = Convert.ToDateTime( dt.Rows[0]["NgaySinh"].ToString());
                
                txtghichu.Text = dt.Rows[0]["GhiChu"].ToString();
            }
            conn.Close();
        }

        private void btnsuadl_Click(object sender, EventArgs e)
        {
            string gt;
            if (rbonam.Checked)
            {
                gt = "NAM";
            }
            else
            {
                gt = "NU";
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            string query1 = "update SinhVien set NgaySinh='"+Convert.ToDateTime(dtpngaysinh.Text).ToString("MM/dd/yyyy")+"',QueQuan=N'"+txtquequan.Text+ "',NoiSinh=N'" + txtnoisinh.Text+"',GioiTinh='"+gt+ "',GhiChu=N'"+txtghichu.Text.Trim()+"' where MaSinhVien='" +this.username+ "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            var result= cmd1.ExecuteNonQuery();
            if(result != 0)
            {
                MessageBox.Show("cap nhat du lieu thanh cong");
            }
            conn.Close();
        }
    }
}
