namespace BT_Nhom_CK_
{
    partial class QLHP
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
            this.dgvmainqlhp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.cbonganh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmainqlhp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmainqlhp
            // 
            this.dgvmainqlhp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmainqlhp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvmainqlhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmainqlhp.Location = new System.Drawing.Point(0, 170);
            this.dgvmainqlhp.Name = "dgvmainqlhp";
            this.dgvmainqlhp.RowHeadersWidth = 51;
            this.dgvmainqlhp.RowTemplate.Height = 24;
            this.dgvmainqlhp.Size = new System.Drawing.Size(800, 280);
            this.dgvmainqlhp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngành";
            // 
            // cbokhoa
            // 
            this.cbokhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Items.AddRange(new object[] {
            "--"});
            this.cbokhoa.Location = new System.Drawing.Point(180, 13);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(180, 24);
            this.cbokhoa.TabIndex = 3;
            this.cbokhoa.SelectedIndexChanged += new System.EventHandler(this.cbokhoa_SelectedIndexChanged);
            // 
            // cbonganh
            // 
            this.cbonganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonganh.FormattingEnabled = true;
            this.cbonganh.Items.AddRange(new object[] {
            "--"});
            this.cbonganh.Location = new System.Drawing.Point(180, 49);
            this.cbonganh.Name = "cbonganh";
            this.cbonganh.Size = new System.Drawing.Size(180, 24);
            this.cbonganh.TabIndex = 4;
            this.cbonganh.SelectedIndexChanged += new System.EventHandler(this.cbonganh_SelectedIndexChanged);
            // 
            // QLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbonganh);
            this.Controls.Add(this.cbokhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmainqlhp);
            this.Name = "QLHP";
            this.Text = "QLHP";
            this.Load += new System.EventHandler(this.QLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmainqlhp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmainqlhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.ComboBox cbonganh;
    }
}