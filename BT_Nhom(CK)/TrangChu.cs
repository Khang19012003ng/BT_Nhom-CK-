using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Nhom_CK_
{
    public partial class fTrangChu : Form
    {
        public fTrangChu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }
        
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
        
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Chương Trình","Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
