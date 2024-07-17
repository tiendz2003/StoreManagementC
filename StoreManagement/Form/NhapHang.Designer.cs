namespace StoreManagement
{
    partial class NhapHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.dtgrvnhap = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = " Nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập:";
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(183, 191);
            this.txtmapn.Margin = new System.Windows.Forms.Padding(4);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(160, 22);
            this.txtmapn.TabIndex = 3;
            // 
            // dtgrvnhap
            // 
            this.dtgrvnhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvnhap.Location = new System.Drawing.Point(544, 181);
            this.dtgrvnhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvnhap.Name = "dtgrvnhap";
            this.dtgrvnhap.RowHeadersWidth = 51;
            this.dtgrvnhap.Size = new System.Drawing.Size(500, 292);
            this.dtgrvnhap.TabIndex = 7;
            this.dtgrvnhap.SelectionChanged += new System.EventHandler(this.dtgrvnhap_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(381, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "PHIẾU NHẬP HÀNG";
            // 
            // btnsua
            // 
            this.btnsua.Image = global::StoreManagement.Properties.Resources.btSua;
            this.btnsua.Location = new System.Drawing.Point(426, 268);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(60, 55);
            this.btnsua.TabIndex = 9;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::StoreManagement.Properties.Resources.xoa;
            this.btnxoa.Location = new System.Drawing.Point(426, 350);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(60, 55);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::StoreManagement.Properties.Resources.them;
            this.btnthem.Location = new System.Drawing.Point(426, 191);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 55);
            this.btnthem.TabIndex = 11;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntim
            // 
            this.btntim.Image = global::StoreManagement.Properties.Resources.Search;
            this.btntim.Location = new System.Drawing.Point(800, 126);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(43, 39);
            this.btntim.TabIndex = 12;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // cbncc
            // 
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(183, 268);
            this.cbncc.Margin = new System.Windows.Forms.Padding(4);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(160, 24);
            this.cbncc.TabIndex = 13;
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaynhap.Location = new System.Drawing.Point(183, 353);
            this.dtngaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(160, 22);
            this.dtngaynhap.TabIndex = 14;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchitiet.Location = new System.Drawing.Point(49, 478);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(437, 42);
            this.btnchitiet.TabIndex = 15;
            this.btnchitiet.Text = "Xem chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(544, 127);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(247, 34);
            this.txttimkiem.TabIndex = 16;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(542, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhập mã phiếu nhập:";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(183, 420);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(160, 24);
            this.cbNhanVien.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nhân viên:";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dtngaynhap);
            this.Controls.Add(this.cbncc);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgrvnhap);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapHang";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.DataGridView dtgrvnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label6;
    }
}