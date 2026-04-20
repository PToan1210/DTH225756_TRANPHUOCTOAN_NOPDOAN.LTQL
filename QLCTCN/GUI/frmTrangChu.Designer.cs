namespace GUI
{
    partial class frmTrangChu
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
            this.scQuanLy = new System.Windows.Forms.SplitContainer();
            this.btnQuanLyND = new System.Windows.Forms.Button();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.btnNguonTien = new System.Windows.Forms.Button();
            this.btnHangMuc = new System.Windows.Forms.Button();
            this.btnThuNhap = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongkeChitiêu = new System.Windows.Forms.Button();
            this.btnChiTieu = new System.Windows.Forms.Button();
            this.lbTienVi = new System.Windows.Forms.Label();
            this.lbSoTienTaiKhoan = new System.Windows.Forms.Label();
            this.lbSoTienMat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenND = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scQuanLy)).BeginInit();
            this.scQuanLy.Panel1.SuspendLayout();
            this.scQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // scQuanLy
            // 
            this.scQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scQuanLy.Location = new System.Drawing.Point(0, 0);
            this.scQuanLy.Name = "scQuanLy";
            // 
            // scQuanLy.Panel1
            // 
            this.scQuanLy.Panel1.Controls.Add(this.btnQuanLyND);
            this.scQuanLy.Panel1.Controls.Add(this.lblVaiTro);
            this.scQuanLy.Panel1.Controls.Add(this.btnNguonTien);
            this.scQuanLy.Panel1.Controls.Add(this.btnHangMuc);
            this.scQuanLy.Panel1.Controls.Add(this.btnThuNhap);
            this.scQuanLy.Panel1.Controls.Add(this.btnDangXuat);
            this.scQuanLy.Panel1.Controls.Add(this.btnThongkeChitiêu);
            this.scQuanLy.Panel1.Controls.Add(this.btnChiTieu);
            this.scQuanLy.Panel1.Controls.Add(this.lbTienVi);
            this.scQuanLy.Panel1.Controls.Add(this.lbSoTienTaiKhoan);
            this.scQuanLy.Panel1.Controls.Add(this.lbSoTienMat);
            this.scQuanLy.Panel1.Controls.Add(this.label3);
            this.scQuanLy.Panel1.Controls.Add(this.label2);
            this.scQuanLy.Panel1.Controls.Add(this.label1);
            this.scQuanLy.Panel1.Controls.Add(this.lbTenND);
            this.scQuanLy.Size = new System.Drawing.Size(1284, 692);
            this.scQuanLy.SplitterDistance = 384;
            this.scQuanLy.TabIndex = 5;
            // 
            // btnQuanLyND
            // 
            this.btnQuanLyND.Location = new System.Drawing.Point(19, 568);
            this.btnQuanLyND.Name = "btnQuanLyND";
            this.btnQuanLyND.Size = new System.Drawing.Size(352, 52);
            this.btnQuanLyND.TabIndex = 17;
            this.btnQuanLyND.Text = "Quản lý người dùng";
            this.btnQuanLyND.UseVisualStyleBackColor = true;
            this.btnQuanLyND.Click += new System.EventHandler(this.btnQuanLyND_Click);
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVaiTro.Location = new System.Drawing.Point(141, 34);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(61, 22);
            this.lblVaiTro.TabIndex = 16;
            this.lblVaiTro.Text = "vaiTro";
            // 
            // btnNguonTien
            // 
            this.btnNguonTien.Location = new System.Drawing.Point(19, 431);
            this.btnNguonTien.Name = "btnNguonTien";
            this.btnNguonTien.Size = new System.Drawing.Size(352, 52);
            this.btnNguonTien.TabIndex = 15;
            this.btnNguonTien.Text = "Nguồn Tiền";
            this.btnNguonTien.UseVisualStyleBackColor = true;
            this.btnNguonTien.Click += new System.EventHandler(this.btnNguonTien_Click);
            // 
            // btnHangMuc
            // 
            this.btnHangMuc.Location = new System.Drawing.Point(19, 361);
            this.btnHangMuc.Name = "btnHangMuc";
            this.btnHangMuc.Size = new System.Drawing.Size(352, 52);
            this.btnHangMuc.TabIndex = 14;
            this.btnHangMuc.Text = "Hạng Mức";
            this.btnHangMuc.UseVisualStyleBackColor = true;
            this.btnHangMuc.Click += new System.EventHandler(this.btnHangMuc_Click);
            // 
            // btnThuNhap
            // 
            this.btnThuNhap.Location = new System.Drawing.Point(19, 222);
            this.btnThuNhap.Name = "btnThuNhap";
            this.btnThuNhap.Size = new System.Drawing.Size(352, 52);
            this.btnThuNhap.TabIndex = 13;
            this.btnThuNhap.Text = "Thu Nhập ";
            this.btnThuNhap.UseVisualStyleBackColor = true;
            this.btnThuNhap.Click += new System.EventHandler(this.btnThuNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(80, 638);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(218, 42);
            this.btnDangXuat.TabIndex = 12;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongkeChitiêu
            // 
            this.btnThongkeChitiêu.Location = new System.Drawing.Point(19, 500);
            this.btnThongkeChitiêu.Name = "btnThongkeChitiêu";
            this.btnThongkeChitiêu.Size = new System.Drawing.Size(352, 52);
            this.btnThongkeChitiêu.TabIndex = 11;
            this.btnThongkeChitiêu.Text = "Thống kê chi tiêu";
            this.btnThongkeChitiêu.UseVisualStyleBackColor = true;
            this.btnThongkeChitiêu.Click += new System.EventHandler(this.btnThongkeChitiêu_Click);
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.Location = new System.Drawing.Point(19, 292);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.Size = new System.Drawing.Size(352, 52);
            this.btnChiTieu.TabIndex = 8;
            this.btnChiTieu.Text = "Chi tiêu";
            this.btnChiTieu.UseVisualStyleBackColor = true;
            this.btnChiTieu.Click += new System.EventHandler(this.btnChiTieu_Click);
            // 
            // lbTienVi
            // 
            this.lbTienVi.AutoSize = true;
            this.lbTienVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienVi.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTienVi.Location = new System.Drawing.Point(242, 161);
            this.lbTienVi.Name = "lbTienVi";
            this.lbTienVi.Size = new System.Drawing.Size(56, 20);
            this.lbTienVi.TabIndex = 7;
            this.lbTienVi.Text = "0 VND";
            // 
            // lbSoTienTaiKhoan
            // 
            this.lbSoTienTaiKhoan.AutoSize = true;
            this.lbSoTienTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienTaiKhoan.ForeColor = System.Drawing.Color.IndianRed;
            this.lbSoTienTaiKhoan.Location = new System.Drawing.Point(242, 126);
            this.lbSoTienTaiKhoan.Name = "lbSoTienTaiKhoan";
            this.lbSoTienTaiKhoan.Size = new System.Drawing.Size(56, 20);
            this.lbSoTienTaiKhoan.TabIndex = 6;
            this.lbSoTienTaiKhoan.Text = "0 VND";
            // 
            // lbSoTienMat
            // 
            this.lbSoTienMat.AutoSize = true;
            this.lbSoTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienMat.ForeColor = System.Drawing.Color.IndianRed;
            this.lbSoTienMat.Location = new System.Drawing.Point(242, 87);
            this.lbSoTienMat.Name = "lbSoTienMat";
            this.lbSoTienMat.Size = new System.Drawing.Size(56, 20);
            this.lbSoTienMat.TabIndex = 5;
            this.lbSoTienMat.Text = "0 VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền ví:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số tiền tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền mặt:";
            // 
            // lbTenND
            // 
            this.lbTenND.AutoSize = true;
            this.lbTenND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenND.Location = new System.Drawing.Point(93, 9);
            this.lbTenND.Name = "lbTenND";
            this.lbTenND.Size = new System.Drawing.Size(169, 25);
            this.lbTenND.TabIndex = 1;
            this.lbTenND.Text = "Tên Người Dùng";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.scQuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTrangChu";
            this.Text = "Quản lý chi tiêu cá nhân";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.scQuanLy.Panel1.ResumeLayout(false);
            this.scQuanLy.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scQuanLy)).EndInit();
            this.scQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer scQuanLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenND;
        private System.Windows.Forms.Label lbSoTienMat;
        private System.Windows.Forms.Label lbTienVi;
        private System.Windows.Forms.Label lbSoTienTaiKhoan;
        private System.Windows.Forms.Button btnThuNhap;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongkeChitiêu;
        private System.Windows.Forms.Button btnChiTieu;
        private System.Windows.Forms.Button btnHangMuc;
        private System.Windows.Forms.Button btnNguonTien;
        private System.Windows.Forms.Button btnQuanLyND;
        private System.Windows.Forms.Label lblVaiTro;
    }
}