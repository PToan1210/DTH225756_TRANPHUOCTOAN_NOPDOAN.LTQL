namespace GUI
{
    partial class frmNguonTien
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
            this.dgvDSNguonTien = new System.Windows.Forms.DataGridView();
            this.btnHuyNguonTien = new System.Windows.Forms.Button();
            this.btnSuaNguonTien = new System.Windows.Forms.Button();
            this.btnXoaNguonTien = new System.Windows.Forms.Button();
            this.btnThemNguonTien = new System.Windows.Forms.Button();
            this.radHang = new System.Windows.Forms.RadioButton();
            this.radMat = new System.Windows.Forms.RadioButton();
            this.txtTenNguonTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radTu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguonTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nguồn tiền";
            // 
            // dgvDSNguonTien
            // 
            this.dgvDSNguonTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNguonTien.Location = new System.Drawing.Point(3, 233);
            this.dgvDSNguonTien.Name = "dgvDSNguonTien";
            this.dgvDSNguonTien.ReadOnly = true;
            this.dgvDSNguonTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNguonTien.Size = new System.Drawing.Size(872, 383);
            this.dgvDSNguonTien.TabIndex = 59;
            this.dgvDSNguonTien.Click += new System.EventHandler(this.dgvDSNguonTien_Click);
            // 
            // btnHuyNguonTien
            // 
            this.btnHuyNguonTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyNguonTien.Location = new System.Drawing.Point(737, 164);
            this.btnHuyNguonTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuyNguonTien.Name = "btnHuyNguonTien";
            this.btnHuyNguonTien.Size = new System.Drawing.Size(138, 38);
            this.btnHuyNguonTien.TabIndex = 58;
            this.btnHuyNguonTien.Text = "Hủy";
            this.btnHuyNguonTien.UseVisualStyleBackColor = true;
            this.btnHuyNguonTien.Click += new System.EventHandler(this.btnHuyNguonTien_Click);
            // 
            // btnSuaNguonTien
            // 
            this.btnSuaNguonTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNguonTien.Location = new System.Drawing.Point(737, 116);
            this.btnSuaNguonTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaNguonTien.Name = "btnSuaNguonTien";
            this.btnSuaNguonTien.Size = new System.Drawing.Size(138, 38);
            this.btnSuaNguonTien.TabIndex = 55;
            this.btnSuaNguonTien.Text = "Sửa";
            this.btnSuaNguonTien.UseVisualStyleBackColor = true;
            this.btnSuaNguonTien.Click += new System.EventHandler(this.btnSuaNguonTien_Click);
            // 
            // btnXoaNguonTien
            // 
            this.btnXoaNguonTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNguonTien.Location = new System.Drawing.Point(737, 68);
            this.btnXoaNguonTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaNguonTien.Name = "btnXoaNguonTien";
            this.btnXoaNguonTien.Size = new System.Drawing.Size(138, 38);
            this.btnXoaNguonTien.TabIndex = 54;
            this.btnXoaNguonTien.Text = "Xóa";
            this.btnXoaNguonTien.UseVisualStyleBackColor = true;
            this.btnXoaNguonTien.Click += new System.EventHandler(this.btnXoaNguonTien_Click);
            // 
            // btnThemNguonTien
            // 
            this.btnThemNguonTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNguonTien.Location = new System.Drawing.Point(737, 20);
            this.btnThemNguonTien.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemNguonTien.Name = "btnThemNguonTien";
            this.btnThemNguonTien.Size = new System.Drawing.Size(138, 38);
            this.btnThemNguonTien.TabIndex = 53;
            this.btnThemNguonTien.Text = "Thêm";
            this.btnThemNguonTien.UseVisualStyleBackColor = true;
            this.btnThemNguonTien.Click += new System.EventHandler(this.btnThemNguonTien_Click);
            // 
            // radHang
            // 
            this.radHang.AutoSize = true;
            this.radHang.Location = new System.Drawing.Point(299, 120);
            this.radHang.Name = "radHang";
            this.radHang.Size = new System.Drawing.Size(119, 26);
            this.radHang.TabIndex = 84;
            this.radHang.Text = "Ngân Hàng";
            this.radHang.UseVisualStyleBackColor = true;
            // 
            // radMat
            // 
            this.radMat.AutoSize = true;
            this.radMat.Checked = true;
            this.radMat.Location = new System.Drawing.Point(177, 121);
            this.radMat.Name = "radMat";
            this.radMat.Size = new System.Drawing.Size(98, 26);
            this.radMat.TabIndex = 83;
            this.radMat.TabStop = true;
            this.radMat.Text = "Tiền mặt";
            this.radMat.UseVisualStyleBackColor = true;
            // 
            // txtTenNguonTien
            // 
            this.txtTenNguonTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguonTien.Location = new System.Drawing.Point(177, 53);
            this.txtTenNguonTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenNguonTien.Name = "txtTenNguonTien";
            this.txtTenNguonTien.Size = new System.Drawing.Size(295, 30);
            this.txtTenNguonTien.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Tên Nguồn Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Loại hạng mục";
            // 
            // radTu
            // 
            this.radTu.AutoSize = true;
            this.radTu.Location = new System.Drawing.Point(439, 120);
            this.radTu.Name = "radTu";
            this.radTu.Size = new System.Drawing.Size(103, 26);
            this.radTu.TabIndex = 85;
            this.radTu.Text = "Ví điện tử";
            this.radTu.UseVisualStyleBackColor = true;
            // 
            // frmNguonTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 629);
            this.Controls.Add(this.radTu);
            this.Controls.Add(this.radHang);
            this.Controls.Add(this.radMat);
            this.Controls.Add(this.txtTenNguonTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDSNguonTien);
            this.Controls.Add(this.btnHuyNguonTien);
            this.Controls.Add(this.btnSuaNguonTien);
            this.Controls.Add(this.btnXoaNguonTien);
            this.Controls.Add(this.btnThemNguonTien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNguonTien";
            this.Text = "frmNguonTien";
            this.Load += new System.EventHandler(this.frmNguonTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguonTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSNguonTien;
        private System.Windows.Forms.Button btnHuyNguonTien;
        private System.Windows.Forms.Button btnSuaNguonTien;
        private System.Windows.Forms.Button btnXoaNguonTien;
        private System.Windows.Forms.Button btnThemNguonTien;
        private System.Windows.Forms.RadioButton radHang;
        private System.Windows.Forms.RadioButton radMat;
        private System.Windows.Forms.TextBox txtTenNguonTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radTu;
    }
}