namespace BT_Nhom_CK_
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.errusername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangchuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpass)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pass";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.Location = new System.Drawing.Point(109, 14);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(139, 22);
            this.txtusername.TabIndex = 3;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.Location = new System.Drawing.Point(109, 45);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(139, 22);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 367);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btndangnhap);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtpass);
            this.panel4.Controls.Add(this.txtusername);
            this.panel4.Location = new System.Drawing.Point(265, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 118);
            this.panel4.TabIndex = 6;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndangnhap.Location = new System.Drawing.Point(68, 87);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(104, 28);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // errusername
            // 
            this.errusername.ContainerControl = this;
            // 
            // errpass
            // 
            this.errpass.ContainerControl = this;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem,
            this.trangchuToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(806, 54);
            this.menuStrip2.TabIndex = 6;
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoatToolStripMenuItem.Text = "Thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // trangchuToolStripMenuItem
            // 
            this.trangchuToolStripMenuItem.Name = "trangchuToolStripMenuItem";
            this.trangchuToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.trangchuToolStripMenuItem.Text = "trangchu";
            this.trangchuToolStripMenuItem.Click += new System.EventHandler(this.trangchuToolStripMenuItem_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(806, 467);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpass)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errusername;
        private System.Windows.Forms.ErrorProvider errpass;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangchuToolStripMenuItem;
    }
}