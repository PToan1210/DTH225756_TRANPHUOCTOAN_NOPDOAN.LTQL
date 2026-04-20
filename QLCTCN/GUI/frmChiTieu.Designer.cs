namespace GUI
{
    partial class frmChiTieu
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
            this.btnThemChiTieu = new System.Windows.Forms.Button();
            this.txtMoTaChiTieu = new System.Windows.Forms.TextBox();
            this.cbbTenChiTieu = new System.Windows.Forms.ComboBox();
            this.cbbNTChiTieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHanMucChiTieu = new System.Windows.Forms.Label();
            this.btnXoaChiTieu = new System.Windows.Forms.Button();
            this.btnSuaChiTieu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayChiTieu = new System.Windows.Forms.DateTimePicker();
            this.btnHuyChiTieu = new System.Windows.Forms.Button();
            this.dgvDSChiTieu = new System.Windows.Forms.DataGridView();
            this.nbChiTieu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemChiTieu
            // 
            this.btnThemChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTieu.Location = new System.Drawing.Point(734, 61);
            this.btnThemChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemChiTieu.Name = "btnThemChiTieu";
            this.btnThemChiTieu.Size = new System.Drawing.Size(138, 38);
            this.btnThemChiTieu.TabIndex = 19;
            this.btnThemChiTieu.Text = "Thêm";
            this.btnThemChiTieu.UseVisualStyleBackColor = true;
            this.btnThemChiTieu.Click += new System.EventHandler(this.btnThemChiTieu_Click);
            // 
            // txtMoTaChiTieu
            // 
            this.txtMoTaChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaChiTieu.Location = new System.Drawing.Point(462, 153);
            this.txtMoTaChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.txtMoTaChiTieu.Name = "txtMoTaChiTieu";
            this.txtMoTaChiTieu.Size = new System.Drawing.Size(183, 30);
            this.txtMoTaChiTieu.TabIndex = 18;
            // 
            // cbbTenChiTieu
            // 
            this.cbbTenChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenChiTieu.FormattingEnabled = true;
            this.cbbTenChiTieu.Location = new System.Drawing.Point(142, 148);
            this.cbbTenChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTenChiTieu.Name = "cbbTenChiTieu";
            this.cbbTenChiTieu.Size = new System.Drawing.Size(183, 33);
            this.cbbTenChiTieu.TabIndex = 16;
            this.cbbTenChiTieu.SelectedIndexChanged += new System.EventHandler(this.cbbTenChiTieu_SelectedIndexChanged);
            // 
            // cbbNTChiTieu
            // 
            this.cbbNTChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNTChiTieu.FormattingEnabled = true;
            this.cbbNTChiTieu.Location = new System.Drawing.Point(142, 85);
            this.cbbNTChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNTChiTieu.Name = "cbbNTChiTieu";
            this.cbbNTChiTieu.Size = new System.Drawing.Size(183, 33);
            this.cbbNTChiTieu.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên chi tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nguồn tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chi tiêu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hạn mức còn lại";
            // 
            // lbHanMucChiTieu
            // 
            this.lbHanMucChiTieu.AutoSize = true;
            this.lbHanMucChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanMucChiTieu.ForeColor = System.Drawing.Color.IndianRed;
            this.lbHanMucChiTieu.Location = new System.Drawing.Point(539, 218);
            this.lbHanMucChiTieu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHanMucChiTieu.Name = "lbHanMucChiTieu";
            this.lbHanMucChiTieu.Size = new System.Drawing.Size(151, 25);
            this.lbHanMucChiTieu.TabIndex = 21;
            this.lbHanMucChiTieu.Text = "Hạn mức còn lại";
            // 
            // btnXoaChiTieu
            // 
            this.btnXoaChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiTieu.Location = new System.Drawing.Point(734, 109);
            this.btnXoaChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaChiTieu.Name = "btnXoaChiTieu";
            this.btnXoaChiTieu.Size = new System.Drawing.Size(138, 38);
            this.btnXoaChiTieu.TabIndex = 22;
            this.btnXoaChiTieu.Text = "Xóa";
            this.btnXoaChiTieu.UseVisualStyleBackColor = true;
            this.btnXoaChiTieu.Click += new System.EventHandler(this.btnXoaChiTieu_Click);
            // 
            // btnSuaChiTieu
            // 
            this.btnSuaChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTieu.Location = new System.Drawing.Point(734, 157);
            this.btnSuaChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaChiTieu.Name = "btnSuaChiTieu";
            this.btnSuaChiTieu.Size = new System.Drawing.Size(138, 38);
            this.btnSuaChiTieu.TabIndex = 23;
            this.btnSuaChiTieu.Text = "Sửa";
            this.btnSuaChiTieu.UseVisualStyleBackColor = true;
            this.btnSuaChiTieu.Click += new System.EventHandler(this.btnSuaChiTieu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ngày";
            // 
            // dtpNgayChiTieu
            // 
            this.dtpNgayChiTieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChiTieu.Location = new System.Drawing.Point(142, 216);
            this.dtpNgayChiTieu.Name = "dtpNgayChiTieu";
            this.dtpNgayChiTieu.Size = new System.Drawing.Size(183, 27);
            this.dtpNgayChiTieu.TabIndex = 25;
            // 
            // btnHuyChiTieu
            // 
            this.btnHuyChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChiTieu.Location = new System.Drawing.Point(734, 205);
            this.btnHuyChiTieu.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuyChiTieu.Name = "btnHuyChiTieu";
            this.btnHuyChiTieu.Size = new System.Drawing.Size(138, 38);
            this.btnHuyChiTieu.TabIndex = 26;
            this.btnHuyChiTieu.Text = "Hủy";
            this.btnHuyChiTieu.UseVisualStyleBackColor = true;
            this.btnHuyChiTieu.Click += new System.EventHandler(this.btnHuyChiTieu_Click);
            // 
            // dgvDSChiTieu
            // 
            this.dgvDSChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChiTieu.Location = new System.Drawing.Point(0, 274);
            this.dgvDSChiTieu.Name = "dgvDSChiTieu";
            this.dgvDSChiTieu.ReadOnly = true;
            this.dgvDSChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSChiTieu.Size = new System.Drawing.Size(872, 383);
            this.dgvDSChiTieu.TabIndex = 27;
            this.dgvDSChiTieu.Click += new System.EventHandler(this.dgvDSChiTieu_Click);
            // 
            // nbChiTieu
            // 
            this.nbChiTieu.Location = new System.Drawing.Point(462, 95);
            this.nbChiTieu.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbChiTieu.Name = "nbChiTieu";
            this.nbChiTieu.Size = new System.Drawing.Size(136, 27);
            this.nbChiTieu.TabIndex = 63;
            // 
            // frmChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 669);
            this.Controls.Add(this.nbChiTieu);
            this.Controls.Add(this.dgvDSChiTieu);
            this.Controls.Add(this.btnHuyChiTieu);
            this.Controls.Add(this.dtpNgayChiTieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSuaChiTieu);
            this.Controls.Add(this.btnXoaChiTieu);
            this.Controls.Add(this.lbHanMucChiTieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThemChiTieu);
            this.Controls.Add(this.txtMoTaChiTieu);
            this.Controls.Add(this.cbbTenChiTieu);
            this.Controls.Add(this.cbbNTChiTieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChiTieu";
            this.Text = "frmChiTieu";
            this.Load += new System.EventHandler(this.frmChiTieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbChiTieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemChiTieu;
        private System.Windows.Forms.TextBox txtMoTaChiTieu;
        private System.Windows.Forms.ComboBox cbbTenChiTieu;
        private System.Windows.Forms.ComboBox cbbNTChiTieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHanMucChiTieu;
        private System.Windows.Forms.Button btnXoaChiTieu;
        private System.Windows.Forms.Button btnSuaChiTieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayChiTieu;
        private System.Windows.Forms.Button btnHuyChiTieu;
        private System.Windows.Forms.DataGridView dgvDSChiTieu;
        private System.Windows.Forms.NumericUpDown nbChiTieu;
    }
}