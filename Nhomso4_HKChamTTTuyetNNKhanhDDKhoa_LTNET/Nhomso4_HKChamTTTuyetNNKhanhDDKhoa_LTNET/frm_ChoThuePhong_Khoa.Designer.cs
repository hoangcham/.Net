namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class frm_ChoThuePhong_Khoa
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
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhanvien.Location = new System.Drawing.Point(241, 435);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(224, 30);
            this.txtmanhanvien.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // cbkh
            // 
            this.cbkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(241, 388);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(224, 33);
            this.cbkh.TabIndex = 19;
            // 
            // txtMahd
            // 
            this.txtMahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahd.Location = new System.Drawing.Point(241, 345);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(224, 30);
            this.txtMahd.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Location = new System.Drawing.Point(578, 376);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(133, 45);
            this.btnDatHang.TabIndex = 15;
            this.btnDatHang.Text = "Đặt Phòng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // dgvphong
            // 
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Location = new System.Drawing.Point(12, 143);
            this.dgvphong.Name = "dgvphong";
            this.dgvphong.RowHeadersWidth = 51;
            this.dgvphong.RowTemplate.Height = 24;
            this.dgvphong.Size = new System.Drawing.Size(780, 168);
            this.dgvphong.TabIndex = 14;
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.BackColor = System.Drawing.SystemColors.Control;
            this.btnkiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkiemtra.Location = new System.Drawing.Point(578, 66);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(133, 45);
            this.btnkiemtra.TabIndex = 13;
            this.btnkiemtra.Text = "Kiểm Tra";
            this.btnkiemtra.UseVisualStyleBackColor = false;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cmnd";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmnd.Location = new System.Drawing.Point(236, 78);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(229, 30);
            this.txtcmnd.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumPurple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, -6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(880, 52);
            this.label5.TabIndex = 22;
            this.label5.Text = "QUẢN LÝ THUÊ PHÒNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ChoThuePhong_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbkh);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.dgvphong);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcmnd);
            this.Name = "frm_ChoThuePhong_Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cho Thuê Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbkh;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label5;
    }
}