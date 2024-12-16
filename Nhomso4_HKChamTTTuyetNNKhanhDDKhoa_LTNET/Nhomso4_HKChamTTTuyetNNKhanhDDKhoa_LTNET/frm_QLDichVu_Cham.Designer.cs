namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class frm_QLDichVu_Cham
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
            this.dtgv_qldv_Cham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GiaDV_Cham = new System.Windows.Forms.TextBox();
            this.btn_Them_Cham = new System.Windows.Forms.Button();
            this.btn_Sua_Cham = new System.Windows.Forms.Button();
            this.btn_Xoa_Cham = new System.Windows.Forms.Button();
            this.btn_Thoat_Cham = new System.Windows.Forms.Button();
            this.txt_MaDV_Cham = new System.Windows.Forms.TextBox();
            this.txt_TenDV_Cham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TimKiem_Cham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TKTTen_Cham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qldv_Cham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_qldv_Cham
            // 
            this.dtgv_qldv_Cham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_qldv_Cham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5});
            this.dtgv_qldv_Cham.Location = new System.Drawing.Point(4, 341);
            this.dtgv_qldv_Cham.Name = "dtgv_qldv_Cham";
            this.dtgv_qldv_Cham.RowHeadersWidth = 51;
            this.dtgv_qldv_Cham.RowTemplate.Height = 24;
            this.dtgv_qldv_Cham.Size = new System.Drawing.Size(961, 238);
            this.dtgv_qldv_Cham.TabIndex = 8;
            this.dtgv_qldv_Cham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_qldv_Cham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDichVu";
            this.Column1.HeaderText = "Mã dịch vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 225;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDichVu";
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 225;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaDichVu";
            this.Column5.HeaderText = "Giá dịch vụ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 225;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txt_GiaDV_Cham);
            this.groupBox1.Controls.Add(this.btn_Them_Cham);
            this.groupBox1.Controls.Add(this.btn_Sua_Cham);
            this.groupBox1.Controls.Add(this.btn_Xoa_Cham);
            this.groupBox1.Controls.Add(this.btn_Thoat_Cham);
            this.groupBox1.Controls.Add(this.txt_MaDV_Cham);
            this.groupBox1.Controls.Add(this.txt_TenDV_Cham);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txt_GiaDV_Cham
            // 
            this.txt_GiaDV_Cham.Location = new System.Drawing.Point(208, 147);
            this.txt_GiaDV_Cham.Name = "txt_GiaDV_Cham";
            this.txt_GiaDV_Cham.Size = new System.Drawing.Size(232, 30);
            this.txt_GiaDV_Cham.TabIndex = 15;
            // 
            // btn_Them_Cham
            // 
            this.btn_Them_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_Cham.Location = new System.Drawing.Point(549, 35);
            this.btn_Them_Cham.Name = "btn_Them_Cham";
            this.btn_Them_Cham.Size = new System.Drawing.Size(168, 44);
            this.btn_Them_Cham.TabIndex = 14;
            this.btn_Them_Cham.Text = "Thêm";
            this.btn_Them_Cham.UseVisualStyleBackColor = false;
            this.btn_Them_Cham.Click += new System.EventHandler(this.btn_Them_Cham_Click);
            // 
            // btn_Sua_Cham
            // 
            this.btn_Sua_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_Cham.Location = new System.Drawing.Point(549, 97);
            this.btn_Sua_Cham.Name = "btn_Sua_Cham";
            this.btn_Sua_Cham.Size = new System.Drawing.Size(168, 44);
            this.btn_Sua_Cham.TabIndex = 13;
            this.btn_Sua_Cham.Text = "Sửa";
            this.btn_Sua_Cham.UseVisualStyleBackColor = false;
            this.btn_Sua_Cham.Click += new System.EventHandler(this.btn_Sua_Cham_Click);
            // 
            // btn_Xoa_Cham
            // 
            this.btn_Xoa_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_Cham.Location = new System.Drawing.Point(754, 35);
            this.btn_Xoa_Cham.Name = "btn_Xoa_Cham";
            this.btn_Xoa_Cham.Size = new System.Drawing.Size(168, 44);
            this.btn_Xoa_Cham.TabIndex = 12;
            this.btn_Xoa_Cham.Text = "Xóa";
            this.btn_Xoa_Cham.UseVisualStyleBackColor = false;
            this.btn_Xoa_Cham.Click += new System.EventHandler(this.btn_Xoa_Cham_Click);
            // 
            // btn_Thoat_Cham
            // 
            this.btn_Thoat_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Thoat_Cham.Location = new System.Drawing.Point(757, 100);
            this.btn_Thoat_Cham.Name = "btn_Thoat_Cham";
            this.btn_Thoat_Cham.Size = new System.Drawing.Size(165, 44);
            this.btn_Thoat_Cham.TabIndex = 10;
            this.btn_Thoat_Cham.Text = "Thoát";
            this.btn_Thoat_Cham.UseVisualStyleBackColor = false;
            this.btn_Thoat_Cham.Click += new System.EventHandler(this.btn_Thoat_Cham_Click);
            // 
            // txt_MaDV_Cham
            // 
            this.txt_MaDV_Cham.Location = new System.Drawing.Point(208, 40);
            this.txt_MaDV_Cham.Name = "txt_MaDV_Cham";
            this.txt_MaDV_Cham.Size = new System.Drawing.Size(232, 30);
            this.txt_MaDV_Cham.TabIndex = 7;
            // 
            // txt_TenDV_Cham
            // 
            this.txt_TenDV_Cham.Location = new System.Drawing.Point(208, 92);
            this.txt_TenDV_Cham.Name = "txt_TenDV_Cham";
            this.txt_TenDV_Cham.Size = new System.Drawing.Size(232, 30);
            this.txt_TenDV_Cham.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên dịch vụ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá dịch vụ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã dịch vụ:";
            // 
            // btn_TimKiem_Cham
            // 
            this.btn_TimKiem_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiem_Cham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem_Cham.Location = new System.Drawing.Point(589, 273);
            this.btn_TimKiem_Cham.Name = "btn_TimKiem_Cham";
            this.btn_TimKiem_Cham.Size = new System.Drawing.Size(171, 44);
            this.btn_TimKiem_Cham.TabIndex = 11;
            this.btn_TimKiem_Cham.Text = "Tìm Kiếm";
            this.btn_TimKiem_Cham.UseVisualStyleBackColor = false;
            this.btn_TimKiem_Cham.Click += new System.EventHandler(this.btn_TimKiem_Cham_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TKTTen_Cham
            // 
            this.txt_TKTTen_Cham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TKTTen_Cham.Location = new System.Drawing.Point(312, 280);
            this.txt_TKTTen_Cham.Name = "txt_TKTTen_Cham";
            this.txt_TKTTen_Cham.Size = new System.Drawing.Size(232, 30);
            this.txt_TKTTen_Cham.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tìm kiếm theo tên dịch vụ:";
            // 
            // frm_QLDichVu_Cham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 594);
            this.Controls.Add(this.txt_TKTTen_Cham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv_qldv_Cham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TimKiem_Cham);
            this.Name = "frm_QLDichVu_Cham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.frm_QLDichVu_Cham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qldv_Cham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_qldv_Cham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Them_Cham;
        private System.Windows.Forms.Button btn_Sua_Cham;
        private System.Windows.Forms.Button btn_Xoa_Cham;
        private System.Windows.Forms.Button btn_TimKiem_Cham;
        private System.Windows.Forms.Button btn_Thoat_Cham;
        private System.Windows.Forms.TextBox txt_MaDV_Cham;
        private System.Windows.Forms.TextBox txt_TenDV_Cham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiaDV_Cham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txt_TKTTen_Cham;
        private System.Windows.Forms.Label label3;
    }
}