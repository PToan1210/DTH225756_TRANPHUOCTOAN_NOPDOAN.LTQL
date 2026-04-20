namespace GUI
{
    partial class frmThuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSThuNhap = new System.Windows.Forms.DataGridView();
            this.btnHuyThuThap = new System.Windows.Forms.Button();
            this.dtpNgayThuNhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuaThuNhap = new System.Windows.Forms.Button();
            this.btnXoaThuNhap = new System.Windows.Forms.Button();
            this.btnThemThuNhap = new System.Windows.Forms.Button();
            this.txtMoTaThu = new System.Windows.Forms.TextBox();
            this.cbbTenThuNhap = new System.Windows.Forms.ComboBox();
            this.cbbNTThuNhap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbThuNhap = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbThuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thu Nhập";
            // 
            // dgvDSThuNhap
            // 
            this.dgvDSThuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSThuNhap.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSThuNhap.Location = new System.Drawing.Point(3, 239);
            this.dgvDSThuNhap.Name = "dgvDSThuNhap";
            this.dgvDSThuNhap.ReadOnly = true;
            this.dgvDSThuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSThuNhap.Size = new System.Drawing.Size(872, 383);
            this.dgvDSThuNhap.TabIndex = 44;
            this.dgvDSThuNhap.Click += new System.EventHandler(this.dgvDSThuNhap_Click);
            // 
            // btnHuyThuThap
            // 
            this.btnHuyThuThap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThuThap.Location = new System.Drawing.Point(737, 170);
            this.btnHuyThuThap.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuyThuThap.Name = "btnHuyThuThap";
            this.btnHuyThuThap.Size = new System.Drawing.Size(138, 38);
            this.btnHuyThuThap.TabIndex = 43;
            this.btnHuyThuThap.Text = "Hủy";
            this.btnHuyThuThap.UseVisualStyleBackColor = true;
            this.btnHuyThuThap.Click += new System.EventHandler(this.btnHuyThuThap_Click);
            // 
            // dtpNgayThuNhap
            // 
            this.dtpNgayThuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThuNhap.Location = new System.Drawing.Point(145, 181);
            this.dtpNgayThuNhap.Name = "dtpNgayThuNhap";
            this.dtpNgayThuNhap.Size = new System.Drawing.Size(183, 27);
            this.dtpNgayThuNhap.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ngày";
            // 
            // btnSuaThuNhap
            // 
            this.btnSuaThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuNhap.Location = new System.Drawing.Point(737, 122);
            this.btnSuaThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaThuNhap.Name = "btnSuaThuNhap";
            this.btnSuaThuNhap.Size = new System.Drawing.Size(138, 38);
            this.btnSuaThuNhap.TabIndex = 40;
            this.btnSuaThuNhap.Text = "Sửa";
            this.btnSuaThuNhap.UseVisualStyleBackColor = true;
            this.btnSuaThuNhap.Click += new System.EventHandler(this.btnSuaThuNhap_Click);
            // 
            // btnXoaThuNhap
            // 
            this.btnXoaThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuNhap.Location = new System.Drawing.Point(737, 74);
            this.btnXoaThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaThuNhap.Name = "btnXoaThuNhap";
            this.btnXoaThuNhap.Size = new System.Drawing.Size(138, 38);
            this.btnXoaThuNhap.TabIndex = 39;
            this.btnXoaThuNhap.Text = "Xóa";
            this.btnXoaThuNhap.UseVisualStyleBackColor = true;
            this.btnXoaThuNhap.Click += new System.EventHandler(this.btnXoaThuNhap_Click);
            // 
            // btnThemThuNhap
            // 
            this.btnThemThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuNhap.Location = new System.Drawing.Point(737, 26);
            this.btnThemThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemThuNhap.Name = "btnThemThuNhap";
            this.btnThemThuNhap.Size = new System.Drawing.Size(138, 38);
            this.btnThemThuNhap.TabIndex = 36;
            this.btnThemThuNhap.Text = "Thêm";
            this.btnThemThuNhap.UseVisualStyleBackColor = true;
            this.btnThemThuNhap.Click += new System.EventHandler(this.btnThemThuNhap_Click);
            // 
            // txtMoTaThu
            // 
            this.txtMoTaThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaThu.Location = new System.Drawing.Point(465, 118);
            this.txtMoTaThu.Margin = new System.Windows.Forms.Padding(5);
            this.txtMoTaThu.Name = "txtMoTaThu";
            this.txtMoTaThu.Size = new System.Drawing.Size(183, 30);
            this.txtMoTaThu.TabIndex = 35;
            // 
            // cbbTenThuNhap
            // 
            this.cbbTenThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThuNhap.FormattingEnabled = true;
            this.cbbTenThuNhap.Location = new System.Drawing.Point(145, 113);
            this.cbbTenThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTenThuNhap.Name = "cbbTenThuNhap";
            this.cbbTenThuNhap.Size = new System.Drawing.Size(183, 33);
            this.cbbTenThuNhap.TabIndex = 33;
            // 
            // cbbNTThuNhap
            // 
            this.cbbNTThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNTThuNhap.FormattingEnabled = true;
            this.cbbNTThuNhap.Location = new System.Drawing.Point(145, 50);
            this.cbbNTThuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNTThuNhap.Name = "cbbNTThuNhap";
            this.cbbNTThuNhap.Size = new System.Drawing.Size(183, 33);
            this.cbbNTThuNhap.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên thu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nguồn tiền";
            // 
            // nbThuNhap
            // 
            this.nbThuNhap.Location = new System.Drawing.Point(465, 60);
            this.nbThuNhap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbThuNhap.Name = "nbThuNhap";
            this.nbThuNhap.Size = new System.Drawing.Size(136, 27);
            this.nbThuNhap.TabIndex = 63;
            // 
            // frmThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 626);
            this.Controls.Add(this.nbThuNhap);
            this.Controls.Add(this.dgvDSThuNhap);
            this.Controls.Add(this.btnHuyThuThap);
            this.Controls.Add(this.dtpNgayThuNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSuaThuNhap);
            this.Controls.Add(this.btnXoaThuNhap);
            this.Controls.Add(this.btnThemThuNhap);
            this.Controls.Add(this.txtMoTaThu);
            this.Controls.Add(this.cbbTenThuNhap);
            this.Controls.Add(this.cbbNTThuNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThuNhap";
            this.Text = "frmThuNhap";
            this.Load += new System.EventHandler(this.frmThuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbThuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSThuNhap;
        private System.Windows.Forms.Button btnHuyThuThap;
        private System.Windows.Forms.DateTimePicker dtpNgayThuNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuaThuNhap;
        private System.Windows.Forms.Button btnXoaThuNhap;
        private System.Windows.Forms.Button btnThemThuNhap;
        private System.Windows.Forms.TextBox txtMoTaThu;
        private System.Windows.Forms.ComboBox cbbTenThuNhap;
        private System.Windows.Forms.ComboBox cbbNTThuNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbThuNhap;
    }
}