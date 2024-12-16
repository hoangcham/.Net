namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class frm_QLNhanVien_Cham
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
            this.dtgv_qlnv_Cham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_Ngaysinh_Cham = new System.Windows.Forms.DateTimePicker();
            this.txt_Loaind_Cham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them_Cham = new System.Windows.Forms.Button();
            this.btn_Sua_Cham = new System.Windows.Forms.Button();
            this.btn_Xoa_Cham = new System.Windows.Forms.Button();
            this.btn_TimKiem_Cham = new System.Windows.Forms.Button();
            this.btn_Thoat_Cham = new System.Windows.Forms.Button();
            this.cb_Gioitinh_Cham = new System.Windows.Forms.ComboBox();
            this.txt_Matkhau_Cham = new System.Windows.Forms.TextBox();
            this.txt_MaNV_Cham = new System.Windows.Forms.TextBox();
            this.txt_Hoten_Cham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qlnv_Cham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_qlnv_Cham
            // 
            this.dtgv_qlnv_Cham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_qlnv_Cham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgv_qlnv_Cham.Location = new System.Drawing.Point(6, 398);
            this.dtgv_qlnv_Cham.Name = "dtgv_qlnv_Cham";
            this.dtgv_qlnv_Cham.RowHeadersWidth = 51;
            this.dtgv_qlnv_Cham.RowTemplate.Height = 24;
            this.dtgv_qlnv_Cham.Size = new System.Drawing.Size(1080, 232);
            this.dtgv_qlnv_Cham.TabIndex = 5;
            this.dtgv_qlnv_Cham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_qlnv_Cham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhanVien";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MatKhau";
            this.Column5.HeaderText = "Mật khẩu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "LoaiNguoiDung";
            this.Column6.HeaderText = "Loại người dùng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.dt_Ngaysinh_Cham);
            this.groupBox1.Controls.Add(this.txt_Loaind_Cham);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Them_Cham);
            this.groupBox1.Controls.Add(this.btn_Sua_Cham);
            this.groupBox1.Controls.Add(this.btn_Xoa_Cham);
            this.groupBox1.Controls.Add(this.btn_TimKiem_Cham);
            this.groupBox1.Controls.Add(this.btn_Thoat_Cham);
            this.groupBox1.Controls.Add(this.cb_Gioitinh_Cham);
            this.groupBox1.Controls.Add(this.txt_Matkhau_Cham);
            this.groupBox1.Controls.Add(this.txt_MaNV_Cham);
            this.groupBox1.Controls.Add(this.txt_Hoten_Cham);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 325);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dt_Ngaysinh_Cham
            // 
            this.dt_Ngaysinh_Cham.Location = new System.Drawing.Point(653, 54);
            this.dt_Ngaysinh_Cham.Name = "dt_Ngaysinh_Cham";
            this.dt_Ngaysinh_Cham.Size = new System.Drawing.Size(246, 30);
            this.dt_Ngaysinh_Cham.TabIndex = 17;
            // 
            // txt_Loaind_Cham
            // 
            this.txt_Loaind_Cham.Location = new System.Drawing.Point(653, 167);
            this.txt_Loaind_Cham.Name = "txt_Loaind_Cham";
            this.txt_Loaind_Cham.Size = new System.Drawing.Size(246, 30);
            this.txt_Loaind_Cham.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Loại người dùng:";
            // 
            // btn_Them_Cham
            // 
            this.btn_Them_Cham.Location = new System.Drawing.Point(42, 263);
            this.btn_Them_Cham.Name = "btn_Them_Cham";
            this.btn_Them_Cham.Size = new System.Drawing.Size(168, 44);
            this.btn_Them_Cham.TabIndex = 14;
            this.btn_Them_Cham.Text = "Thêm";
            this.btn_Them_Cham.UseVisualStyleBackColor = true;
            this.btn_Them_Cham.Click += new System.EventHandler(this.btn_Them_Cham_Click);
            // 
            // btn_Sua_Cham
            // 
            this.btn_Sua_Cham.Location = new System.Drawing.Point(261, 263);
            this.btn_Sua_Cham.Name = "btn_Sua_Cham";
            this.btn_Sua_Cham.Size = new System.Drawing.Size(157, 44);
            this.btn_Sua_Cham.TabIndex = 13;
            this.btn_Sua_Cham.Text = "Sửa";
            this.btn_Sua_Cham.UseVisualStyleBackColor = true;
            this.btn_Sua_Cham.Click += new System.EventHandler(this.btn_Sua_Cham_Click);
            // 
            // btn_Xoa_Cham
            // 
            this.btn_Xoa_Cham.Location = new System.Drawing.Point(468, 263);
            this.btn_Xoa_Cham.Name = "btn_Xoa_Cham";
            this.btn_Xoa_Cham.Size = new System.Drawing.Size(175, 44);
            this.btn_Xoa_Cham.TabIndex = 12;
            this.btn_Xoa_Cham.Text = "Xóa";
            this.btn_Xoa_Cham.UseVisualStyleBackColor = true;
            this.btn_Xoa_Cham.Click += new System.EventHandler(this.btn_Xoa_Cham_Click);
            // 
            // btn_TimKiem_Cham
            // 
            this.btn_TimKiem_Cham.Location = new System.Drawing.Point(692, 263);
            this.btn_TimKiem_Cham.Name = "btn_TimKiem_Cham";
            this.btn_TimKiem_Cham.Size = new System.Drawing.Size(171, 44);
            this.btn_TimKiem_Cham.TabIndex = 11;
            this.btn_TimKiem_Cham.Text = "Tìm Kiếm";
            this.btn_TimKiem_Cham.UseVisualStyleBackColor = true;
            this.btn_TimKiem_Cham.Click += new System.EventHandler(this.btn_TimKiem_Cham_Click);
            // 
            // btn_Thoat_Cham
            // 
            this.btn_Thoat_Cham.Location = new System.Drawing.Point(897, 263);
            this.btn_Thoat_Cham.Name = "btn_Thoat_Cham";
            this.btn_Thoat_Cham.Size = new System.Drawing.Size(165, 44);
            this.btn_Thoat_Cham.TabIndex = 10;
            this.btn_Thoat_Cham.Text = "Thoát";
            this.btn_Thoat_Cham.UseVisualStyleBackColor = true;
            this.btn_Thoat_Cham.Click += new System.EventHandler(this.btn_Thoat_Cham_Click);
            // 
            // cb_Gioitinh_Cham
            // 
            this.cb_Gioitinh_Cham.FormattingEnabled = true;
            this.cb_Gioitinh_Cham.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_Gioitinh_Cham.Location = new System.Drawing.Point(208, 164);
            this.cb_Gioitinh_Cham.Name = "cb_Gioitinh_Cham";
            this.cb_Gioitinh_Cham.Size = new System.Drawing.Size(232, 33);
            this.cb_Gioitinh_Cham.TabIndex = 9;
            // 
            // txt_Matkhau_Cham
            // 
            this.txt_Matkhau_Cham.Location = new System.Drawing.Point(653, 109);
            this.txt_Matkhau_Cham.Name = "txt_Matkhau_Cham";
            this.txt_Matkhau_Cham.Size = new System.Drawing.Size(246, 30);
            this.txt_Matkhau_Cham.TabIndex = 8;
            // 
            // txt_MaNV_Cham
            // 
            this.txt_MaNV_Cham.Location = new System.Drawing.Point(208, 49);
            this.txt_MaNV_Cham.Name = "txt_MaNV_Cham";
            this.txt_MaNV_Cham.Size = new System.Drawing.Size(232, 30);
            this.txt_MaNV_Cham.TabIndex = 7;
            // 
            // txt_Hoten_Cham
            // 
            this.txt_Hoten_Cham.Location = new System.Drawing.Point(208, 109);
            this.txt_Hoten_Cham.Name = "txt_Hoten_Cham";
            this.txt_Hoten_Cham.Size = new System.Drawing.Size(232, 30);
            this.txt_Hoten_Cham.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Họ tên nhân viên: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1102, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_QLNhanVien_Cham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 629);
            this.Controls.Add(this.dtgv_qlnv_Cham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLNhanVien_Cham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhân Viên_Hoàng Kim Châm";
            this.Load += new System.EventHandler(this.frm_QLNhanVien_Cham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qlnv_Cham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_qlnv_Cham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Them_Cham;
        private System.Windows.Forms.Button btn_Sua_Cham;
        private System.Windows.Forms.Button btn_Xoa_Cham;
        private System.Windows.Forms.Button btn_TimKiem_Cham;
        private System.Windows.Forms.Button btn_Thoat_Cham;
        private System.Windows.Forms.ComboBox cb_Gioitinh_Cham;
        private System.Windows.Forms.TextBox txt_Matkhau_Cham;
        private System.Windows.Forms.TextBox txt_MaNV_Cham;
        private System.Windows.Forms.TextBox txt_Hoten_Cham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Ngaysinh_Cham;
        private System.Windows.Forms.TextBox txt_Loaind_Cham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}