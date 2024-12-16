namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class frm_QLKhachHang_Tuyet
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
            this.dtgv_qlkh_Tuyet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SoCMT_Tuyet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SDT_Tuyet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them_Tuyet = new System.Windows.Forms.Button();
            this.btn_Sua_Tuyet = new System.Windows.Forms.Button();
            this.btn_Xoa_Tuyet = new System.Windows.Forms.Button();
            this.btn_TimKiem_Tuyet = new System.Windows.Forms.Button();
            this.btn_Thoat_Tuyet = new System.Windows.Forms.Button();
            this.cb_Gioitinh_Tuyet = new System.Windows.Forms.ComboBox();
            this.txt_Qtich_Tuyet = new System.Windows.Forms.TextBox();
            this.txt_MaKH_Tuyet = new System.Windows.Forms.TextBox();
            this.txt_Hoten_Tuyet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qlkh_Tuyet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_qlkh_Tuyet
            // 
            this.dtgv_qlkh_Tuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_qlkh_Tuyet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgv_qlkh_Tuyet.Location = new System.Drawing.Point(11, 397);
            this.dtgv_qlkh_Tuyet.Name = "dtgv_qlkh_Tuyet";
            this.dtgv_qlkh_Tuyet.RowHeadersWidth = 51;
            this.dtgv_qlkh_Tuyet.RowTemplate.Height = 24;
            this.dtgv_qlkh_Tuyet.Size = new System.Drawing.Size(1080, 232);
            this.dtgv_qlkh_Tuyet.TabIndex = 8;
            this.dtgv_qlkh_Tuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_qlkh_Tuyet_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txt_SoCMT_Tuyet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_SDT_Tuyet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Them_Tuyet);
            this.groupBox1.Controls.Add(this.btn_Sua_Tuyet);
            this.groupBox1.Controls.Add(this.btn_Xoa_Tuyet);
            this.groupBox1.Controls.Add(this.btn_TimKiem_Tuyet);
            this.groupBox1.Controls.Add(this.btn_Thoat_Tuyet);
            this.groupBox1.Controls.Add(this.cb_Gioitinh_Tuyet);
            this.groupBox1.Controls.Add(this.txt_Qtich_Tuyet);
            this.groupBox1.Controls.Add(this.txt_MaKH_Tuyet);
            this.groupBox1.Controls.Add(this.txt_Hoten_Tuyet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 325);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_SoCMT_Tuyet
            // 
            this.txt_SoCMT_Tuyet.Location = new System.Drawing.Point(692, 46);
            this.txt_SoCMT_Tuyet.Name = "txt_SoCMT_Tuyet";
            this.txt_SoCMT_Tuyet.Size = new System.Drawing.Size(246, 30);
            this.txt_SoCMT_Tuyet.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số chứng minh thư:";
            // 
            // txt_SDT_Tuyet
            // 
            this.txt_SDT_Tuyet.Location = new System.Drawing.Point(692, 169);
            this.txt_SDT_Tuyet.Name = "txt_SDT_Tuyet";
            this.txt_SDT_Tuyet.Size = new System.Drawing.Size(246, 30);
            this.txt_SDT_Tuyet.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại:";
            // 
            // btn_Them_Tuyet
            // 
            this.btn_Them_Tuyet.Location = new System.Drawing.Point(42, 263);
            this.btn_Them_Tuyet.Name = "btn_Them_Tuyet";
            this.btn_Them_Tuyet.Size = new System.Drawing.Size(168, 44);
            this.btn_Them_Tuyet.TabIndex = 14;
            this.btn_Them_Tuyet.Text = "Thêm";
            this.btn_Them_Tuyet.UseVisualStyleBackColor = true;
            this.btn_Them_Tuyet.Click += new System.EventHandler(this.btn_Them_Tuyet_Click);
            // 
            // btn_Sua_Tuyet
            // 
            this.btn_Sua_Tuyet.Location = new System.Drawing.Point(261, 263);
            this.btn_Sua_Tuyet.Name = "btn_Sua_Tuyet";
            this.btn_Sua_Tuyet.Size = new System.Drawing.Size(157, 44);
            this.btn_Sua_Tuyet.TabIndex = 13;
            this.btn_Sua_Tuyet.Text = "Sửa";
            this.btn_Sua_Tuyet.UseVisualStyleBackColor = true;
            this.btn_Sua_Tuyet.Click += new System.EventHandler(this.btn_Sua_Tuyet_Click);
            // 
            // btn_Xoa_Tuyet
            // 
            this.btn_Xoa_Tuyet.Location = new System.Drawing.Point(468, 263);
            this.btn_Xoa_Tuyet.Name = "btn_Xoa_Tuyet";
            this.btn_Xoa_Tuyet.Size = new System.Drawing.Size(175, 44);
            this.btn_Xoa_Tuyet.TabIndex = 12;
            this.btn_Xoa_Tuyet.Text = "Xóa";
            this.btn_Xoa_Tuyet.UseVisualStyleBackColor = true;
            this.btn_Xoa_Tuyet.Click += new System.EventHandler(this.btn_Xoa_Tuyet_Click);
            // 
            // btn_TimKiem_Tuyet
            // 
            this.btn_TimKiem_Tuyet.Location = new System.Drawing.Point(692, 263);
            this.btn_TimKiem_Tuyet.Name = "btn_TimKiem_Tuyet";
            this.btn_TimKiem_Tuyet.Size = new System.Drawing.Size(171, 44);
            this.btn_TimKiem_Tuyet.TabIndex = 11;
            this.btn_TimKiem_Tuyet.Text = "Tìm Kiếm";
            this.btn_TimKiem_Tuyet.UseVisualStyleBackColor = true;
            this.btn_TimKiem_Tuyet.Click += new System.EventHandler(this.btn_TimKiem_Tuyet_Click);
            // 
            // btn_Thoat_Tuyet
            // 
            this.btn_Thoat_Tuyet.Location = new System.Drawing.Point(897, 263);
            this.btn_Thoat_Tuyet.Name = "btn_Thoat_Tuyet";
            this.btn_Thoat_Tuyet.Size = new System.Drawing.Size(165, 44);
            this.btn_Thoat_Tuyet.TabIndex = 10;
            this.btn_Thoat_Tuyet.Text = "Thoát";
            this.btn_Thoat_Tuyet.UseVisualStyleBackColor = true;
            this.btn_Thoat_Tuyet.Click += new System.EventHandler(this.btn_Thoat_Tuyet_Click);
            // 
            // cb_Gioitinh_Tuyet
            // 
            this.cb_Gioitinh_Tuyet.FormattingEnabled = true;
            this.cb_Gioitinh_Tuyet.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_Gioitinh_Tuyet.Location = new System.Drawing.Point(208, 164);
            this.cb_Gioitinh_Tuyet.Name = "cb_Gioitinh_Tuyet";
            this.cb_Gioitinh_Tuyet.Size = new System.Drawing.Size(232, 33);
            this.cb_Gioitinh_Tuyet.TabIndex = 9;
            // 
            // txt_Qtich_Tuyet
            // 
            this.txt_Qtich_Tuyet.Location = new System.Drawing.Point(692, 111);
            this.txt_Qtich_Tuyet.Name = "txt_Qtich_Tuyet";
            this.txt_Qtich_Tuyet.Size = new System.Drawing.Size(246, 30);
            this.txt_Qtich_Tuyet.TabIndex = 8;
            // 
            // txt_MaKH_Tuyet
            // 
            this.txt_MaKH_Tuyet.Location = new System.Drawing.Point(208, 49);
            this.txt_MaKH_Tuyet.Name = "txt_MaKH_Tuyet";
            this.txt_MaKH_Tuyet.Size = new System.Drawing.Size(232, 30);
            this.txt_MaKH_Tuyet.TabIndex = 7;
            // 
            // txt_Hoten_Tuyet
            // 
            this.txt_Hoten_Tuyet.Location = new System.Drawing.Point(208, 109);
            this.txt_Hoten_Tuyet.Name = "txt_Hoten_Tuyet";
            this.txt_Hoten_Tuyet.Size = new System.Drawing.Size(232, 30);
            this.txt_Hoten_Tuyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Họ tên khách hàng: ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quốc tịch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1102, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKhachHang";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhachHang";
            this.Column2.HeaderText = "Họ tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoChungMinhThu";
            this.Column3.HeaderText = "Số CMT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "QuocTich";
            this.Column4.HeaderText = "Quốc tịch";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GioiTinh";
            this.Column5.HeaderText = "Giới tính";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoDienThoai";
            this.Column6.HeaderText = "SDT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // frm_QLKhachHang_Tuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 642);
            this.Controls.Add(this.dtgv_qlkh_Tuyet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLKhachHang_Tuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frm_QLKhachHang_Tuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qlkh_Tuyet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_qlkh_Tuyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SDT_Tuyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Them_Tuyet;
        private System.Windows.Forms.Button btn_Sua_Tuyet;
        private System.Windows.Forms.Button btn_Xoa_Tuyet;
        private System.Windows.Forms.Button btn_TimKiem_Tuyet;
        private System.Windows.Forms.Button btn_Thoat_Tuyet;
        private System.Windows.Forms.ComboBox cb_Gioitinh_Tuyet;
        private System.Windows.Forms.TextBox txt_Qtich_Tuyet;
        private System.Windows.Forms.TextBox txt_MaKH_Tuyet;
        private System.Windows.Forms.TextBox txt_Hoten_Tuyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoCMT_Tuyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}