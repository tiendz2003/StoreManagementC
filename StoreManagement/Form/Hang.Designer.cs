using StoreManagement.Properties;

namespace StoreManagement
{
    partial class Hang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hang));
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbmaloai = new System.Windows.Forms.ComboBox();
            this.cbmanhacc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.dtgrvhang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quanLySanPhamDataSet = new StoreManagement.QuanLySanPhamDataSet();
            this.quanLySanPhamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvhang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPhamDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÀNG";
            // 
            // btExit
            // 
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btExit.Location = new System.Drawing.Point(1000, 2);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(67, 28);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà cung cấp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSize);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbmaloai);
            this.panel1.Controls.Add(this.cbmanhacc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtdongia);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.txttim);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.txttenhang);
            this.panel1.Controls.Add(this.txtmahang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(147, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 251);
            this.panel1.TabIndex = 6;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(465, 16);
            this.cbSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(196, 24);
            this.cbSize.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(420, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tên hàng cần tìm:";
            // 
            // cbmaloai
            // 
            this.cbmaloai.FormattingEnabled = true;
            this.cbmaloai.Location = new System.Drawing.Point(103, 113);
            this.cbmaloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbmaloai.Name = "cbmaloai";
            this.cbmaloai.Size = new System.Drawing.Size(196, 24);
            this.cbmaloai.TabIndex = 21;
            // 
            // cbmanhacc
            // 
            this.cbmanhacc.FormattingEnabled = true;
            this.cbmanhacc.Location = new System.Drawing.Point(103, 63);
            this.cbmanhacc.Margin = new System.Windows.Forms.Padding(4);
            this.cbmanhacc.Name = "cbmanhacc";
            this.cbmanhacc.Size = new System.Drawing.Size(196, 24);
            this.cbmanhacc.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(363, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Đơn giá:";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(465, 105);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(196, 22);
            this.txtdongia.TabIndex = 18;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Image = global::StoreManagement.Properties.Resources.Search;
            this.btntimkiem.Location = new System.Drawing.Point(651, 201);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(43, 36);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnsua
            // 
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnsua.Image = global::StoreManagement.Properties.Resources.btSua;
            this.btnsua.Location = new System.Drawing.Point(215, 190);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(60, 55);
            this.btnsua.TabIndex = 16;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(424, 201);
            this.txttim.Margin = new System.Windows.Forms.Padding(4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(217, 35);
            this.txttim.TabIndex = 7;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxoa.Location = new System.Drawing.Point(307, 191);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(60, 55);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnthem.Image = global::StoreManagement.Properties.Resources.them;
            this.btnthem.Location = new System.Drawing.Point(119, 190);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 55);
            this.btnthem.TabIndex = 14;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(367, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(367, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(465, 63);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(196, 22);
            this.txtsoluong.TabIndex = 10;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(103, 158);
            this.txttenhang.Margin = new System.Windows.Forms.Padding(4);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(196, 22);
            this.txttenhang.TabIndex = 8;
            // 
            // txtmahang
            // 
            this.txtmahang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmahang.Location = new System.Drawing.Point(103, 12);
            this.txtmahang.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(197, 22);
            this.txtmahang.TabIndex = 6;
            // 
            // dtgrvhang
            // 
            this.dtgrvhang.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvhang.Location = new System.Drawing.Point(0, 0);
            this.dtgrvhang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvhang.Name = "dtgrvhang";
            this.dtgrvhang.RowHeadersWidth = 51;
            this.dtgrvhang.Size = new System.Drawing.Size(795, 225);
            this.dtgrvhang.TabIndex = 7;
            this.dtgrvhang.SelectionChanged += new System.EventHandler(this.dtgrvhang_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgrvhang);
            this.panel2.Location = new System.Drawing.Point(155, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 225);
            this.panel2.TabIndex = 8;
            // 
            // quanLySanPhamDataSet
            // 
            this.quanLySanPhamDataSet.DataSetName = "QuanLySanPhamDataSet";
            this.quanLySanPhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLySanPhamDataSetBindingSource
            // 
            this.quanLySanPhamDataSetBindingSource.DataSource = this.quanLySanPhamDataSet;
            this.quanLySanPhamDataSetBindingSource.Position = 0;
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hang";
            this.Text = "Hang";
            this.Load += new System.EventHandler(this.Hang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvhang)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPhamDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.DataGridView dtgrvhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.ComboBox cbmaloai;
        private System.Windows.Forms.ComboBox cbmanhacc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.BindingSource quanLySanPhamDataSetBindingSource;
        private QuanLySanPhamDataSet quanLySanPhamDataSet;
    }

}
