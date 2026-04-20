namespace GUI
{
    partial class frmQuanLyND
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
            this.dgvDSND = new System.Windows.Forms.DataGridView();
            this.btnHuyND = new System.Windows.Forms.Button();
            this.btnSuaND = new System.Windows.Forms.Button();
            this.btnXoaND = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemND = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhauDN = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtTenND = new System.Windows.Forms.TextBox();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radND = new System.Windows.Forms.RadioButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSND)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSND
            // 
            this.dgvDSND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSND.Location = new System.Drawing.Point(17, 238);
            this.dgvDSND.Name = "dgvDSND";
            this.dgvDSND.ReadOnly = true;
            this.dgvDSND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSND.Size = new System.Drawing.Size(872, 383);
            this.dgvDSND.TabIndex = 80;
            this.dgvDSND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSND_CellClick);
            // 
            // btnHuyND
            // 
            this.btnHuyND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyND.Location = new System.Drawing.Point(755, 180);
            this.btnHuyND.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuyND.Name = "btnHuyND";
            this.btnHuyND.Size = new System.Drawing.Size(138, 38);
            this.btnHuyND.TabIndex = 79;
            this.btnHuyND.Text = "Hủy";
            this.btnHuyND.UseVisualStyleBackColor = true;
            this.btnHuyND.Click += new System.EventHandler(this.btnHuyND_Click);
            // 
            // btnSuaND
            // 
            this.btnSuaND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaND.Location = new System.Drawing.Point(755, 132);
            this.btnSuaND.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaND.Name = "btnSuaND";
            this.btnSuaND.Size = new System.Drawing.Size(138, 38);
            this.btnSuaND.TabIndex = 76;
            this.btnSuaND.Text = "Sửa";
            this.btnSuaND.UseVisualStyleBackColor = true;
            this.btnSuaND.Click += new System.EventHandler(this.btnSuaND_Click);
            // 
            // btnXoaND
            // 
            this.btnXoaND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaND.Location = new System.Drawing.Point(755, 84);
            this.btnXoaND.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaND.Name = "btnXoaND";
            this.btnXoaND.Size = new System.Drawing.Size(138, 38);
            this.btnXoaND.TabIndex = 75;
            this.btnXoaND.Text = "Xóa";
            this.btnXoaND.UseVisualStyleBackColor = true;
            this.btnXoaND.Click += new System.EventHandler(this.btnXoaND_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Vai trò";
            // 
            // btnThemND
            // 
            this.btnThemND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemND.Location = new System.Drawing.Point(755, 39);
            this.btnThemND.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemND.Name = "btnThemND";
            this.btnThemND.Size = new System.Drawing.Size(138, 38);
            this.btnThemND.TabIndex = 72;
            this.btnThemND.Text = "Thêm";
            this.btnThemND.UseVisualStyleBackColor = true;
            this.btnThemND.Click += new System.EventHandler(this.btnThemND_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(490, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 30);
            this.txtEmail.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Quản lý người dùng";
            // 
            // txtMatKhauDN
            // 
            this.txtMatKhauDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauDN.Location = new System.Drawing.Point(490, 47);
            this.txtMatKhauDN.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhauDN.Name = "txtMatKhauDN";
            this.txtMatKhauDN.Size = new System.Drawing.Size(183, 30);
            this.txtMatKhauDN.TabIndex = 81;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(186, 115);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(183, 30);
            this.txtTenDN.TabIndex = 82;
            // 
            // txtTenND
            // 
            this.txtTenND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenND.Location = new System.Drawing.Point(186, 49);
            this.txtTenND.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenND.Name = "txtTenND";
            this.txtTenND.Size = new System.Drawing.Size(183, 30);
            this.txtTenND.TabIndex = 83;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Location = new System.Drawing.Point(490, 176);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(78, 26);
            this.radAdmin.TabIndex = 84;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radND
            // 
            this.radND.AutoSize = true;
            this.radND.Location = new System.Drawing.Point(612, 181);
            this.radND.Name = "radND";
            this.radND.Size = new System.Drawing.Size(120, 26);
            this.radND.TabIndex = 85;
            this.radND.TabStop = true;
            this.radND.Text = "Người dùng";
            this.radND.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(17, 200);
            this.txtTim.Margin = new System.Windows.Forms.Padding(5);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(183, 30);
            this.txtTim.TabIndex = 86;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(210, 200);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 87;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmQuanLyND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 626);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.radND);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.txtTenND);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.txtMatKhauDN);
            this.Controls.Add(this.dgvDSND);
            this.Controls.Add(this.btnHuyND);
            this.Controls.Add(this.btnSuaND);
            this.Controls.Add(this.btnXoaND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThemND);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyND";
            this.Text = "frmQuanLyND";
            this.Load += new System.EventHandler(this.frmQuanLyND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSND;
        private System.Windows.Forms.Button btnHuyND;
        private System.Windows.Forms.Button btnSuaND;
        private System.Windows.Forms.Button btnXoaND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhauDN;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtTenND;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radND;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}