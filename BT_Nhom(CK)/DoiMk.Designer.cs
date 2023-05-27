namespace BT_Nhom_CK_
{
    partial class DoiMk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.btndoimk = new System.Windows.Forms.Button();
            this.loimkcu = new System.Windows.Forms.ErrorProvider(this.components);
            this.loimkmoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loimkcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loimkmoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MK cu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MK moi";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(244, 123);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(100, 22);
            this.txtmkcu.TabIndex = 2;
            this.txtmkcu.TextChanged += new System.EventHandler(this.txtmkcu_TextChanged);
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(244, 192);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(100, 22);
            this.txtmkmoi.TabIndex = 3;
            this.txtmkmoi.TextChanged += new System.EventHandler(this.txtmkmoi_TextChanged);
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(320, 367);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(75, 23);
            this.btndoimk.TabIndex = 4;
            this.btndoimk.Text = "doi mk";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // loimkcu
            // 
            this.loimkcu.ContainerControl = this;
            // 
            // loimkmoi
            // 
            this.loimkmoi.ContainerControl = this;
            // 
            // DoiMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndoimk);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMk";
            ((System.ComponentModel.ISupportInitialize)(this.loimkcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loimkmoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.ErrorProvider loimkcu;
        private System.Windows.Forms.ErrorProvider loimkmoi;
    }
}