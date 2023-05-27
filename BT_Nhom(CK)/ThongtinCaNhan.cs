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
    public partial class ThongtinCaNhan : Form
    {
        private string username;
        private string pass;
        SqlConnection conn=new SqlConnection("Data Source=KHANG\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        public ThongtinCaNhan()
        {
            InitializeComponent();
        }
        public ThongtinCaNhan(string username,string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        private void lblmasv_Click(object sender, EventArgs e)
        {
            
        }

        private void ThongtinCaNhan_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            string query1 = "select * from SinhVien where MaSinhVien='"+this.username+"'";
            SqlCommand cmd = new SqlCommand(query1,conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt1);
            if(dt1.Rows.Count > 0 )
            {
                lblmasv.Text = dt1.Rows[0]["MaSinhVien"].ToString();
                lblhoten.Text = dt1.Rows[0]["Hoten"].ToString();
                lbltenlop.Text = dt1.Rows[0]["TenLop"].ToString();
                lblquequan.Text = dt1.Rows[0]["QueQuan"].ToString();
                lblnoisinh.Text= dt1.Rows[0]["NoiSinh"].ToString();
                lblgt.Text = dt1.Rows[0]["GioiTinh"].ToString();
                dtpngaysinh.Value=Convert.ToDateTime( dt1.Rows[0]["NgaySinh"].ToString());
                lblghichu.Text= dt1.Rows[0]["GhiChu"].ToString();
            }
            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            suathongtincanhan stt = new suathongtincanhan(this.username, this.pass);
            stt.ShowDialog();
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            DoiMk doiMk = new DoiMk(this.username,this.pass);
            doiMk.ShowDialog();

        }
    }
}
