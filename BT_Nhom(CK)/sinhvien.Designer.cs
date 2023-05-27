namespace BT_Nhom_CK_
{
    partial class sinhvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnttcn = new System.Windows.Forms.Button();
            this.btnqlhp = new System.Windows.Forms.Button();
            this.btnqldiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.dangXuatToolStripMenuItem.Text = "dang xuat";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.thoatToolStripMenuItem.Text = "thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnttcn);
            this.panel1.Controls.Add(this.btnqlhp);
            this.panel1.Controls.Add(this.btnqldiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 420);
            this.panel1.TabIndex = 1;
            // 
            // btnttcn
            // 
            this.btnttcn.Location = new System.Drawing.Point(0, 142);
            this.btnttcn.Name = "btnttcn";
            this.btnttcn.Size = new System.Drawing.Size(200, 64);
            this.btnttcn.TabIndex = 2;
            this.btnttcn.Text = "Thong Tin Ca Nhan";
            this.btnttcn.UseVisualStyleBackColor = true;
            this.btnttcn.Click += new System.EventHandler(this.btnttcn_Click);
            // 
            // btnqlhp
            // 
            this.btnqlhp.Location = new System.Drawing.Point(0, 72);
            this.btnqlhp.Name = "btnqlhp";
            this.btnqlhp.Size = new System.Drawing.Size(200, 64);
            this.btnqlhp.TabIndex = 1;
            this.btnqlhp.Text = "Quan ly hoc phan";
            this.btnqlhp.UseVisualStyleBackColor = true;
            this.btnqlhp.Click += new System.EventHandler(this.btnqlhp_Click);
            // 
            // btnqldiem
            // 
            this.btnqldiem.Location = new System.Drawing.Point(0, 2);
            this.btnqldiem.Name = "btnqldiem";
            this.btnqldiem.Size = new System.Drawing.Size(200, 64);
            this.btnqldiem.TabIndex = 0;
            this.btnqldiem.Text = "QUAN LY DIEM";
            this.btnqldiem.UseVisualStyleBackColor = true;
            this.btnqldiem.Click += new System.EventHandler(this.btnqldiem_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 420);
            this.panel2.TabIndex = 2;
            // 
            // sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sinhvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sinhvien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnttcn;
        private System.Windows.Forms.Button btnqlhp;
        private System.Windows.Forms.Button btnqldiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}