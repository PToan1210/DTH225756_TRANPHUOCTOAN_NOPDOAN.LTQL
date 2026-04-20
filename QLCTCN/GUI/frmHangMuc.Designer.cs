namespace GUI
{
    partial class frmHangMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSHangMuc = new System.Windows.Forms.DataGridView();
            this.btnHuyHM = new System.Windows.Forms.Button();
            this.btnSuaChiTieu = new System.Windows.Forms.Button();
            this.btnXoaThuNhap = new System.Windows.Forms.Button();
            this.btnThemThuNhap = new System.Windows.Forms.Button();
            this.txtTenHangMuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbHangMuc = new System.Windows.Forms.NumericUpDown();
            this.radThu = new System.Windows.Forms.RadioButton();
            this.radChi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbHangMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hạng mục";
            // 
            // dgvDSHangMuc
            // 
            this.dgvDSHangMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHangMuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSHangMuc.Location = new System.Drawing.Point(0, 244);
            this.dgvDSHangMuc.Name = "dgvDSHangMuc";
            this.dgvDSHangMuc.ReadOnly = true;
            this.dgvDSHangMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHangMuc.Size = new System.Drawing.Size(872, 383);
            this.dgvDSHangMuc.TabIndex = 76;
            this.dgvDSHangMuc.Click += new System.EventHandler(this.dgvDSHangMuc_Click);
            // 
            // btnHuyHM
            // 
            this.btnHuyHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHM.Location = new System.Drawing.Point(734, 172);
            this.btnHuyHM.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuyHM.Name = "btnHuyHM";
            this.btnHuyHM.Size = new System.Drawing.Size(138, 38);
            this.btnHuyHM.TabIndex = 75;
            this.btnHuyHM.Text = "Hủy";
            this.btnHuyHM.UseVisualStyleBackColor = true;
            this.btnHuyHM.Click += new System.EventHandler(this.btnHuyHM_Click);
            // 
            // btnSuaChiTieu
            // 
            this.btnSuaChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTieu.Location = new System.Drawing.Point(734, 124);
            this.btnSuaChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaChiTieu.Name = "btnSuaChiTieu";
            this.btnSuaChiTieu.Size = new System.Drawing.Size(138, 38);
            this.btnSuaChiTieu.TabIndex = 72;
            this.btnSuaChiTieu.Text = "Sửa";
            this.btnSuaChiTieu.UseVisualStyleBackColor = true;
            this.btnSuaChiTieu.Click += new System.EventHandler(this.btnSuaChiTieu_Click);
            // 
            // btnXoaThuNhap
            // 
            this.btnXoaThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuNhap.Location = new System.Drawing.Point(734, 76);
            this.btnXoaThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaThuNhap.Name = "btnXoaThuNhap";
            this.btnXoaThuNhap.Size = new System.Drawing.Size(138, 38);
            this.btnXoaThuNhap.TabIndex = 71;
            this.btnXoaThuNhap.Text = "Xóa";
            this.btnXoaThuNhap.UseVisualStyleBackColor = true;
            this.btnXoaThuNhap.Click += new System.EventHandler(this.btnXoaThuNhap_Click);
            // 
            // btnThemThuNhap
            // 
            this.btnThemThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuNhap.Location = new System.Drawing.Point(734, 28);
            this.btnThemThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemThuNhap.Name = "btnThemThuNhap";
            this.btnThemThuNhap.Size = new System.Drawing.Size(138, 38);
            this.btnThemThuNhap.TabIndex = 70;
            this.btnThemThuNhap.Text = "Thêm";
            this.btnThemThuNhap.UseVisualStyleBackColor = true;
            this.btnThemThuNhap.Click += new System.EventHandler(this.btnThemThuNhap_Click);
            // 
            // txtTenHangMuc
            // 
            this.txtTenHangMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHangMuc.Location = new System.Drawing.Point(165, 60);
            this.txtTenHangMuc.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenHangMuc.Name = "txtTenHangMuc";
            this.txtTenHangMuc.Size = new System.Drawing.Size(295, 30);
            this.txtTenHangMuc.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Hạn mức";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "Tên hạng mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Loại hạng mục";
            // 
            // nbHangMuc
            // 
            this.nbHangMuc.Location = new System.Drawing.Point(154, 187);
            this.nbHangMuc.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nbHangMuc.Name = "nbHangMuc";
            this.nbHangMuc.Size = new System.Drawing.Size(212, 27);
            this.nbHangMuc.TabIndex = 77;
            // 
            // radThu
            // 
            this.radThu.AutoSize = true;
            this.radThu.Checked = true;
            this.radThu.Location = new System.Drawing.Point(177, 123);
            this.radThu.Name = "radThu";
            this.radThu.Size = new System.Drawing.Size(105, 26);
            this.radThu.TabIndex = 78;
            this.radThu.TabStop = true;
            this.radThu.Text = "Thu nhập";
            this.radThu.UseVisualStyleBackColor = true;
            this.radThu.CheckedChanged += new System.EventHandler(this.radThu_CheckedChanged);
            // 
            // radChi
            // 
            this.radChi.AutoSize = true;
            this.radChi.Location = new System.Drawing.Point(299, 122);
            this.radChi.Name = "radChi";
            this.radChi.Size = new System.Drawing.Size(89, 26);
            this.radChi.TabIndex = 79;
            this.radChi.Text = "Chi tiêu";
            this.radChi.UseVisualStyleBackColor = true;
            this.radChi.CheckedChanged += new System.EventHandler(this.radChi_CheckedChanged);
            // 
            // frmHangMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 639);
            this.Controls.Add(this.radChi);
            this.Controls.Add(this.radThu);
            this.Controls.Add(this.nbHangMuc);
            this.Controls.Add(this.dgvDSHangMuc);
            this.Controls.Add(this.btnHuyHM);
            this.Controls.Add(this.btnSuaChiTieu);
            this.Controls.Add(this.btnXoaThuNhap);
            this.Controls.Add(this.btnThemThuNhap);
            this.Controls.Add(this.txtTenHangMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHangMuc";
            this.Text = "frmHangMuc";
            this.Load += new System.EventHandler(this.frmHangMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbHangMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSHangMuc;
        private System.Windows.Forms.Button btnHuyHM;
        private System.Windows.Forms.Button btnSuaChiTieu;
        private System.Windows.Forms.Button btnXoaThuNhap;
        private System.Windows.Forms.Button btnThemThuNhap;
        private System.Windows.Forms.TextBox txtTenHangMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbHangMuc;
        private System.Windows.Forms.RadioButton radThu;
        private System.Windows.Forms.RadioButton radChi;
    }
}