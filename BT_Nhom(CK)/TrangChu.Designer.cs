namespace BT_Nhom_CK_
{
    partial class fTrangChu
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
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.dangnhapmnu,
            this.trangChủToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(838, 54);
            this.menuStrip1.TabIndex = 0;
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // dangnhapmnu
            // 
            this.dangnhapmnu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapmnu.Name = "dangnhapmnu";
            this.dangnhapmnu.Size = new System.Drawing.Size(112, 27);
            this.dangnhapmnu.Text = "Đăng Nhập";
            this.dangnhapmnu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dangnhapmnu.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.trangChủToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 54);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(838, 423);
            this.pnl.TabIndex = 1;
            // 
            // fTrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(838, 477);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dangnhapmnu;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

