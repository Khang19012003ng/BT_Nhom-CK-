using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Nhom_CK_
{
    public partial class sinhvien : Form
    {
        private string username;
        private string pass;
        public sinhvien()
        {
            InitializeComponent();
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }
        public sinhvien(string username, string pass)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.username = username;
            this.pass = pass;
        }
        private void sinhvien_Load(object sender, EventArgs e)
        {
            
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Đăng Xuất", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Application.Exit();
            
        }
        private Form currentformchild;
        private void Openformchild(Form childform)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel2.Controls.Add(childform);
            panel2.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnqldiem_Click(object sender, EventArgs e)
        {
            Openformchild(new QLDiem(this.username,this.pass));
        }

        private void btnqlhp_Click(object sender, EventArgs e)
        {
            Openformchild(new QLHP());
        }

        private void btnttcn_Click(object sender, EventArgs e)
        {
            Openformchild(new ThongtinCaNhan(this.username,this.pass));
        }
    }
}
