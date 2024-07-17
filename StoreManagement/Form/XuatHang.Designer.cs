namespace StoreManagement
{
    partial class XuatHang
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
            this.btnchitiet = new System.Windows.Forms.Button();
            this.dtngayxuat = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrvxuat = new System.Windows.Forms.DataGridView();
            this.txtmaxuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnchitiet
            // 
            this.btnchitiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchitiet.Location = new System.Drawing.Point(52, 411);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(295, 43);
            this.btnchitiet.TabIndex = 29;
            this.btnchitiet.Text = "Xem chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // dtngayxuat
            // 
            this.dtngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayxuat.Location = new System.Drawing.Point(185, 297);
            this.dtngayxuat.Margin = new System.Windows.Forms.Padding(4);
            this.dtngayxuat.Name = "dtngayxuat";
            this.dtngayxuat.Size = new System.Drawing.Size(160, 22);
            this.dtngayxuat.TabIndex = 28;
            // 
            // btnthem
            // 
            this.btnthem.Image = global::StoreManagement.Properties.Resources.them;
            this.btnthem.Location = new System.Drawing.Point(413, 242);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 55);
            this.btnthem.TabIndex = 25;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::StoreManagement.Properties.Resources.xoa;
            this.btnxoa.Location = new System.Drawing.Point(413, 391);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(60, 55);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::StoreManagement.Properties.Resources.btSua;
            this.btnsua.Location = new System.Drawing.Point(413, 315);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(60, 55);
            this.btnsua.TabIndex = 23;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 38);
            this.label4.TabIndex = 22;
            this.label4.Text = "PHIẾU XUẤT HÀNG";
            // 
            // dtgrvxuat
            // 
            this.dtgrvxuat.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvxuat.Location = new System.Drawing.Point(520, 214);
            this.dtgrvxuat.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvxuat.Name = "dtgrvxuat";
            this.dtgrvxuat.RowHeadersWidth = 51;
            this.dtgrvxuat.Size = new System.Drawing.Size(500, 240);
            this.dtgrvxuat.TabIndex = 21;
            this.dtgrvxuat.SelectionChanged += new System.EventHandler(this.dtgrvxuat_SelectionChanged);
            // 
            // txtmaxuat
            // 
            this.txtmaxuat.Location = new System.Drawing.Point(185, 242);
            this.txtmaxuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaxuat.Name = "txtmaxuat";
            this.txtmaxuat.Size = new System.Drawing.Size(160, 22);
            this.txtmaxuat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã phiếu xuất:";
            // 
            // txtNv
            // 
            this.txtNv.Location = new System.Drawing.Point(185, 350);
            this.txtNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNv.Name = "txtNv";
            this.txtNv.Size = new System.Drawing.Size(160, 22);
            this.txtNv.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(518, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nhập mã phiếu xuất:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(520, 159);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(247, 34);
            this.txttimkiem.TabIndex = 33;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btntim
            // 
            this.btntim.Image = global::StoreManagement.Properties.Resources.Search;
            this.btntim.Location = new System.Drawing.Point(776, 158);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(43, 39);
            this.btntim.TabIndex = 32;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txtNv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dtngayxuat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgrvxuat);
            this.Controls.Add(this.txtmaxuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XuatHang";
            this.Text = "XuatHang";
            this.Load += new System.EventHandler(this.XuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.DateTimePicker dtngayxuat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgrvxuat;
        private System.Windows.Forms.TextBox txtmaxuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntim;
    }
}