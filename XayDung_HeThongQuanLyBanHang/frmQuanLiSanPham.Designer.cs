namespace XayDung_HeThongQuanLyBanHang
{
    partial class frmQuanLiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenSP
            // 
            this.tbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSP.Location = new System.Drawing.Point(478, 271);
            this.tbTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenSP.Multiline = true;
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(297, 56);
            this.tbTenSP.TabIndex = 1;
            this.tbTenSP.TextChanged += new System.EventHandler(this.tbTenSP_TextChanged);
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(478, 447);
            this.tbGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbGia.Multiline = true;
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(297, 56);
            this.tbGia.TabIndex = 2;
            this.tbGia.TextChanged += new System.EventHandler(this.tbGia_TextChanged);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(478, 628);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Multiline = true;
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(297, 56);
            this.tbSoLuong.TabIndex = 3;
            this.tbSoLuong.TextChanged += new System.EventHandler(this.tbSoLuong_TextChanged);
            // 
            // tbMoTa
            // 
            this.tbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoTa.Location = new System.Drawing.Point(477, 809);
            this.tbMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.tbMoTa.Multiline = true;
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(297, 56);
            this.tbMoTa.TabIndex = 4;
            this.tbMoTa.TextChanged += new System.EventHandler(this.tbMoTa_TextChanged);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonGia,
            this.SoLuongTon,
            this.MoTa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSanPham.Location = new System.Drawing.Point(821, 271);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1817, 1097);
            this.dgvSanPham.TabIndex = 6;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSp";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 9;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 9;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 9;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng tồn kho";
            this.SoLuongTon.MinimumWidth = 9;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 9;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 92);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 59);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giá tiền:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 628);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 59);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 809);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 59);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mô tả sản phẩm: ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Ubuntu", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(223)))));
            this.label10.Location = new System.Drawing.Point(688, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1368, 161);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quản lý Sản phẩm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTaiLai
            // 
            this.btTaiLai.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiLai.ForeColor = System.Drawing.Color.Blue;
            this.btTaiLai.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Regroup_2x;
            this.btTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaiLai.Location = new System.Drawing.Point(502, 1259);
            this.btTaiLai.Margin = new System.Windows.Forms.Padding(4);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(273, 107);
            this.btTaiLai.TabIndex = 9;
            this.btTaiLai.Text = "Nhập mới";
            this.btTaiLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaiLai.UseVisualStyleBackColor = true;
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Edit_fill_2x;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.Location = new System.Drawing.Point(73, 1259);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(273, 107);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Close_round_2x;
            this.btXoa.Location = new System.Drawing.Point(502, 1115);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(273, 107);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.ForestGreen;
            this.btThem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Add_round_2x2;
            this.btThem.Location = new System.Drawing.Point(73, 1115);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(273, 107);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // frmQuanLiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1514);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbMoTa);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbTenSP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiSanPham";
            this.Text = "Quản lý sản phẩm ";
            this.Load += new System.EventHandler(this.frmQuanLiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTaiLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}

