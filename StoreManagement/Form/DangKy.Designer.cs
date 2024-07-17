namespace StoreManagement
{
    partial class DangKy
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
            this.dtgrvdk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendk = new System.Windows.Forms.TextBox();
            this.txtpassdk = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtmadk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdk)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrvdk
            // 
            this.dtgrvdk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvdk.Location = new System.Drawing.Point(554, 122);
            this.dtgrvdk.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrvdk.Name = "dtgrvdk";
            this.dtgrvdk.RowHeadersWidth = 51;
            this.dtgrvdk.Size = new System.Drawing.Size(500, 309);
            this.dtgrvdk.TabIndex = 0;
            this.dtgrvdk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvdk_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(85, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "password:";
            // 
            // txttendk
            // 
            this.txttendk.Location = new System.Drawing.Point(204, 237);
            this.txttendk.Margin = new System.Windows.Forms.Padding(4);
            this.txttendk.Multiline = true;
            this.txttendk.Name = "txttendk";
            this.txttendk.Size = new System.Drawing.Size(176, 37);
            this.txttendk.TabIndex = 6;
            // 
            // txtpassdk
            // 
            this.txtpassdk.Location = new System.Drawing.Point(204, 318);
            this.txtpassdk.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassdk.Multiline = true;
            this.txtpassdk.Name = "txtpassdk";
            this.txtpassdk.Size = new System.Drawing.Size(176, 37);
            this.txtpassdk.TabIndex = 7;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Image = global::StoreManagement.Properties.Resources.them;
            this.btnthem.Location = new System.Drawing.Point(423, 149);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(60, 55);
            this.btnthem.TabIndex = 8;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnsua.Image = global::StoreManagement.Properties.Resources.btSua;
            this.btnsua.Location = new System.Drawing.Point(425, 225);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(60, 55);
            this.btnsua.TabIndex = 9;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btnxoa.Image = global::StoreManagement.Properties.Resources.xoa;
            this.btnxoa.Location = new System.Drawing.Point(425, 306);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(60, 55);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmadk
            // 
            this.txtmadk.Location = new System.Drawing.Point(204, 150);
            this.txtmadk.Margin = new System.Windows.Forms.Padding(4);
            this.txtmadk.Multiline = true;
            this.txtmadk.Name = "txtmadk";
            this.txtmadk.Size = new System.Drawing.Size(176, 37);
            this.txtmadk.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(85, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(454, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "ĐĂNG KÝ";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btBack.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btBack.Image = global::StoreManagement.Properties.Resources.Home;
            this.btBack.Location = new System.Drawing.Point(13, 13);
            this.btBack.Margin = new System.Windows.Forms.Padding(4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(60, 55);
            this.btBack.TabIndex = 14;
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmadk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtpassdk);
            this.Controls.Add(this.txttendk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrvdk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangKy";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvdk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendk;
        private System.Windows.Forms.TextBox txtpassdk;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtmadk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
    }
}