namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class dichvu_Long
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
            this.btnxoadv = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvgiodichvu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsd = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiodichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxoadv
            // 
            this.btnxoadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoadv.Location = new System.Drawing.Point(123, 378);
            this.btnxoadv.Name = "btnxoadv";
            this.btnxoadv.Size = new System.Drawing.Size(214, 56);
            this.btnxoadv.TabIndex = 11;
            this.btnxoadv.Text = "Xóa dịch vụ";
            this.btnxoadv.UseVisualStyleBackColor = true;
            this.btnxoadv.Click += new System.EventHandler(this.btnxoadv_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(706, 152);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(233, 56);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvgiodichvu
            // 
            this.dgvgiodichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgiodichvu.Location = new System.Drawing.Point(12, 237);
            this.dgvgiodichvu.Name = "dgvgiodichvu";
            this.dgvgiodichvu.RowHeadersWidth = 51;
            this.dgvgiodichvu.RowTemplate.Height = 24;
            this.dgvgiodichvu.Size = new System.Drawing.Size(955, 135);
            this.dgvgiodichvu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Những dịch vụ đã chọn";
            // 
            // btnsd
            // 
            this.btnsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsd.Location = new System.Drawing.Point(706, 378);
            this.btnsd.Name = "btnsd";
            this.btnsd.Size = new System.Drawing.Size(233, 56);
            this.btnsd.TabIndex = 7;
            this.btnsd.Text = "Sử dụng dịch Vụ";
            this.btnsd.UseVisualStyleBackColor = true;
            this.btnsd.Click += new System.EventHandler(this.btnsd_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(953, 134);
            this.dgv1.TabIndex = 6;
            // 
            // dichvu_Long
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 497);
            this.Controls.Add(this.btnxoadv);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvgiodichvu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsd);
            this.Controls.Add(this.dgv1);
            this.Name = "dichvu_Long";
            this.Text = "dichvu_Long";
            this.Load += new System.EventHandler(this.dichvu_Long_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiodichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnxoadv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvgiodichvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsd;
        private System.Windows.Forms.DataGridView dgv1;
    }
}