using System;

namespace GUI
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimKim = new System.Windows.Forms.ComboBox();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongChi = new System.Windows.Forms.Label();
            this.lbTongThu = new System.Windows.Forms.Label();
            this.lbLech = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê Chi Thu";
            // 
            // cbbTimKim
            // 
            this.cbbTimKim.FormattingEnabled = true;
            this.cbbTimKim.Items.AddRange(new object[] {
            "Theo Tuần",
            "Theo Tháng",
            "Theo Năm",
            "Từ ngày đến ngày"});
            this.cbbTimKim.Location = new System.Drawing.Point(12, 54);
            this.cbbTimKim.Name = "cbbTimKim";
            this.cbbTimKim.Size = new System.Drawing.Size(155, 28);
            this.cbbTimKim.TabIndex = 1;
            this.cbbTimKim.SelectedIndexChanged += new System.EventHandler(this.cbbTimKim_SelectedIndexChanged);
            // 
            // dtpTu
            // 
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(183, 54);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(116, 27);
            this.dtpTu.TabIndex = 2;
            this.dtpTu.ValueChanged += new System.EventHandler(this.dtpTu_ValueChanged);
            // 
            // dtpDen
            // 
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(317, 54);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(105, 27);
            this.dtpDen.TabIndex = 3;
            this.dtpDen.ValueChanged += new System.EventHandler(this.dtpDen_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng Chi";
            // 
            // lbTongChi
            // 
            this.lbTongChi.AutoSize = true;
            this.lbTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongChi.ForeColor = System.Drawing.Color.Maroon;
            this.lbTongChi.Location = new System.Drawing.Point(178, 454);
            this.lbTongChi.Name = "lbTongChi";
            this.lbTongChi.Size = new System.Drawing.Size(93, 25);
            this.lbTongChi.TabIndex = 8;
            this.lbTongChi.Text = "Tổng Chi";
            // 
            // lbTongThu
            // 
            this.lbTongThu.AutoSize = true;
            this.lbTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThu.ForeColor = System.Drawing.Color.Maroon;
            this.lbTongThu.Location = new System.Drawing.Point(178, 485);
            this.lbTongThu.Name = "lbTongThu";
            this.lbTongThu.Size = new System.Drawing.Size(98, 25);
            this.lbTongThu.TabIndex = 7;
            this.lbTongThu.Text = "Tổng Thu";
            // 
            // lbLech
            // 
            this.lbLech.AutoSize = true;
            this.lbLech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLech.ForeColor = System.Drawing.Color.Maroon;
            this.lbLech.Location = new System.Drawing.Point(178, 514);
            this.lbLech.Name = "lbLech";
            this.lbLech.Size = new System.Drawing.Size(93, 25);
            this.lbLech.TabIndex = 10;
            this.lbLech.Text = "Tổng Chi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số trên lệch";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(12, 98);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(849, 335);
            this.dgvThongKe.TabIndex = 11;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(756, 55);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(98, 30);
            this.btnXuat.TabIndex = 12;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(440, 51);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 30);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(866, 561);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.lbLech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTongChi);
            this.Controls.Add(this.lbTongThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.cbbTimKim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Thu Chi";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimKim;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongChi;
        private System.Windows.Forms.Label lbTongThu;
        private System.Windows.Forms.Label lbLech;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTim;
    }
}