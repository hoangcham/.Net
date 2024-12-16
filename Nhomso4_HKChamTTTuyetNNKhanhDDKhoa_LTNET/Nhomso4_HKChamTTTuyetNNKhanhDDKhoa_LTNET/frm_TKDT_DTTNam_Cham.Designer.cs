namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class frm_TKDT_DTTNam_Cham
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
            this.dtgv_DTTN_Cham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_XuatExcel_Cham = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Thoat_Cham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DTTN_Cham)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_DTTN_Cham
            // 
            this.dtgv_DTTN_Cham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DTTN_Cham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgv_DTTN_Cham.Location = new System.Drawing.Point(23, 80);
            this.dtgv_DTTN_Cham.Name = "dtgv_DTTN_Cham";
            this.dtgv_DTTN_Cham.RowHeadersWidth = 51;
            this.dtgv_DTTN_Cham.RowTemplate.Height = 24;
            this.dtgv_DTTN_Cham.Size = new System.Drawing.Size(414, 230);
            this.dtgv_DTTN_Cham.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Thang";
            this.Column1.HeaderText = "Thang";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DoanhThu";
            this.Column2.HeaderText = "Doanh Thu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // btn_XuatExcel_Cham
            // 
            this.btn_XuatExcel_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_XuatExcel_Cham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel_Cham.Location = new System.Drawing.Point(474, 122);
            this.btn_XuatExcel_Cham.Name = "btn_XuatExcel_Cham";
            this.btn_XuatExcel_Cham.Size = new System.Drawing.Size(159, 42);
            this.btn_XuatExcel_Cham.TabIndex = 20;
            this.btn_XuatExcel_Cham.Text = "Xuất Excel";
            this.btn_XuatExcel_Cham.UseVisualStyleBackColor = false;
            this.btn_XuatExcel_Cham.Click += new System.EventHandler(this.btn_XuatExcel_Cham_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumPurple;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(677, 52);
            this.label4.TabIndex = 19;
            this.label4.Text = "THỐNG KÊ DOANH THU THEO THÁNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Thoat_Cham
            // 
            this.btn_Thoat_Cham.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Thoat_Cham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat_Cham.Location = new System.Drawing.Point(474, 188);
            this.btn_Thoat_Cham.Name = "btn_Thoat_Cham";
            this.btn_Thoat_Cham.Size = new System.Drawing.Size(159, 42);
            this.btn_Thoat_Cham.TabIndex = 22;
            this.btn_Thoat_Cham.Text = "Thoát";
            this.btn_Thoat_Cham.UseVisualStyleBackColor = false;
            this.btn_Thoat_Cham.Click += new System.EventHandler(this.btn_Thoat_Cham_Click);
            // 
            // frm_TKDT_DTTNam_Cham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 365);
            this.Controls.Add(this.btn_Thoat_Cham);
            this.Controls.Add(this.dtgv_DTTN_Cham);
            this.Controls.Add(this.btn_XuatExcel_Cham);
            this.Controls.Add(this.label4);
            this.Name = "frm_TKDT_DTTNam_Cham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TKDT_DTTNam_Cham";
            this.Load += new System.EventHandler(this.frm_TKDT_DTTNam_Cham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DTTN_Cham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_DTTN_Cham;
        private System.Windows.Forms.Button btn_XuatExcel_Cham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_Thoat_Cham;
    }
}