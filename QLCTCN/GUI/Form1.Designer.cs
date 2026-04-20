namespace GUI
{
    partial class frmdangnhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkbQuen = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMatKhauDN = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.ckbHien = new System.Windows.Forms.CheckBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkbQuen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMatKhauDN);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.ckbHien);
            this.groupBox1.Controls.Add(this.btnDN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lkbQuen
            // 
            this.lkbQuen.AutoSize = true;
            this.lkbQuen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbQuen.Location = new System.Drawing.Point(37, 150);
            this.lkbQuen.Name = "lkbQuen";
            this.lkbQuen.Size = new System.Drawing.Size(117, 17);
            this.lkbQuen.TabIndex = 7;
            this.lkbQuen.TabStop = true;
            this.lkbQuen.Text = "Quên mật khẩu ?";
            this.lkbQuen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbQuen_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatKhauDN
            // 
            this.txtMatKhauDN.Location = new System.Drawing.Point(214, 102);
            this.txtMatKhauDN.Name = "txtMatKhauDN";
            this.txtMatKhauDN.Size = new System.Drawing.Size(230, 27);
            this.txtMatKhauDN.TabIndex = 5;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(214, 54);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(230, 27);
            this.txtTenDN.TabIndex = 4;
            // 
            // ckbHien
            // 
            this.ckbHien.AutoSize = true;
            this.ckbHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHien.Location = new System.Drawing.Point(281, 154);
            this.ckbHien.Name = "ckbHien";
            this.ckbHien.Size = new System.Drawing.Size(118, 21);
            this.ckbHien.TabIndex = 3;
            this.ckbHien.Text = "Hiện mật khẩu";
            this.ckbHien.UseVisualStyleBackColor = true;
            this.ckbHien.CheckedChanged += new System.EventHandler(this.ckbHien_CheckedChanged);
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(30, 189);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(163, 53);
            this.btnDN.TabIndex = 2;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 293);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmdangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lkbQuen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMatKhauDN;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.CheckBox ckbHien;
        private System.Windows.Forms.Button btnDN;
    }
}

