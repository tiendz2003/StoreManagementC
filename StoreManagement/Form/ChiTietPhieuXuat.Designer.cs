namespace StoreManagement
{
    partial class ChiTietPhieuXuat
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.cbmapx = new System.Windows.Forms.ComboBox();
            this.dtgrvctpx = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtmact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvctpx)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(651, 250);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nhập mã phiếu xuất cần tìm";
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(168, 274);
            this.cbmanv.Margin = new System.Windows.Forms.Padding(4);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(179, 24);
            this.cbmanv.TabIndex = 45;
            // 
            // cbmahang
            // 
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(168, 212);
            this.cbmahang.Margin = new System.Windows.Forms.Padding(4);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(179, 24);
            this.cbmahang.TabIndex = 44;
            // 
            // cbmapx
            // 
            this.cbmapx.FormattingEnabled = true;
            this.cbmapx.Location = new System.Drawing.Point(168, 148);
            this.cbmapx.Margin = new System.Windows.Forms.Padding(4);
            this.cbmapx.Name = "cbmapx";
            this.cbmapx.Size = new System.Drawing.Size(179, 24);
            this.cbmapx.TabIndex = 43;
            // 
            // dtgrvctpx
            // 
            this.dtgrvctpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvctpx.Location = new System.Drawing.Point(42, 318);
            this.dtgrvctpx.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvctpx.Name = "dtgrvctpx";
            this.dtgrvctpx.RowHeadersWidth = 51;
            this.dtgrvctpx.Size = new System.Drawing.Size(986, 310);
            this.dtgrvctpx.TabIndex = 42;
            this.dtgrvctpx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvctpx_CellContentClick);
            this.dtgrvctpx.SelectionChanged += new System.EventHandler(this.dtgrvctpx_SelectionChanged);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(653, 274);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(245, 31);
            this.txttimkiem.TabIndex = 41;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("UTM Nokia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(908, 274);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 32);
            this.btntim.TabIndex = 40;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("UTM Nokia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(572, 204);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 39;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("UTM Nokia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(411, 204);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 38;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("UTM Nokia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(727, 204);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(527, 151);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(179, 22);
            this.txtsl.TabIndex = 35;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(848, 90);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(179, 22);
            this.txtdongia.TabIndex = 34;
            // 
            // txtmact
            // 
            this.txtmact.Location = new System.Drawing.Point(168, 97);
            this.txtmact.Margin = new System.Windows.Forms.Padding(4);
            this.txtmact.Name = "txtmact";
            this.txtmact.Size = new System.Drawing.Size(179, 22);
            this.txtmact.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(49, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tên hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(49, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(405, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(405, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số lượng xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(741, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đơn giá xuất: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(49, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã phiếu xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(348, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "CHI TIẾT PHIẾU XUẤT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã chi tiết:";
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("UTM Nokia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Location = new System.Drawing.Point(882, 203);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(100, 28);
            this.btIn.TabIndex = 47;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(527, 86);
            this.cbSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(179, 24);
            this.cbSize.TabIndex = 48;
            // 
            // ChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 661);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbmanv);
            this.Controls.Add(this.cbmahang);
            this.Controls.Add(this.cbmapx);
            this.Controls.Add(this.dtgrvctpx);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtmact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietPhieuXuat";
            this.Text = "chitietxuat";
            this.Load += new System.EventHandler(this.ChiTietPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvctpx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.ComboBox cbmahang;
        private System.Windows.Forms.ComboBox cbmapx;
        private System.Windows.Forms.DataGridView dtgrvctpx;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtmact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.ComboBox cbSize;
    }
}