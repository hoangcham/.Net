namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    partial class frm_TraPhong_Long
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
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvtraphong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtraphong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.SystemColors.Control;
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(423, 455);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(185, 53);
            this.btnthanhtoan.TabIndex = 9;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(344, 388);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(264, 30);
            this.txttimkiem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm Kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(125, 455);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(174, 55);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgvtraphong
            // 
            this.dgvtraphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtraphong.Location = new System.Drawing.Point(12, 67);
            this.dgvtraphong.Name = "dgvtraphong";
            this.dgvtraphong.RowHeadersWidth = 51;
            this.dgvtraphong.RowTemplate.Height = 24;
            this.dgvtraphong.Size = new System.Drawing.Size(801, 294);
            this.dgvtraphong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumPurple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(831, 52);
            this.label5.TabIndex = 23;
            this.label5.Text = "QUẢN LÝ THUÊ PHÒNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_TraPhong_Long
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvtraphong);
            this.Name = "frm_TraPhong_Long";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Phòng";
            this.Load += new System.EventHandler(this.frm_TraPhong_Long_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtraphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvtraphong;
        private System.Windows.Forms.Label label5;
    }
}