namespace XayDung_HeThongQuanLyBanHang
{
    partial class frmLichSuDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaTaiThoiDiemMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGhiChuLichSu = new System.Windows.Forms.TextBox();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(63)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(37, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG ";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonHang,
            this.nguoiBan,
            this.NgayTao,
            this.HoTen,
            this.SoDienThoai,
            this.TongTien,
            this.PhuongThucThanhToan,
            this.GhiChu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonHang.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDonHang.Location = new System.Drawing.Point(44, 272);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(984, 650);
            this.dgvDonHang.TabIndex = 3;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            this.dgvDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellContentClick);
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.AllowUserToAddRows = false;
            this.dgvChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGiaTaiThoiDiemMua});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDonHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietDonHang.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(1108, 212);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.ReadOnly = true;
            this.dgvChiTietDonHang.RowHeadersWidth = 51;
            this.dgvChiTietDonHang.RowTemplate.Height = 24;
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(797, 507);
            this.dgvChiTietDonHang.TabIndex = 5;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 9;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 9;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 9;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGiaTaiThoiDiemMua
            // 
            this.DonGiaTaiThoiDiemMua.DataPropertyName = "DonGiaTaiThoiDiemMua";
            this.DonGiaTaiThoiDiemMua.HeaderText = "Giá thời điểm mua";
            this.DonGiaTaiThoiDiemMua.MinimumWidth = 9;
            this.DonGiaTaiThoiDiemMua.Name = "DonGiaTaiThoiDiemMua";
            this.DonGiaTaiThoiDiemMua.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(63)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(1103, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "CHI TIẾT ĐƠN HÀNG ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Ubuntu", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm theo Tên / Sdt:";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(273, 212);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(263, 32);
            this.tbTimKiem.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Ubuntu Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Location = new System.Drawing.Point(823, 198);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(205, 48);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Ubuntu Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.Red;
            this.btnTaiLai.Location = new System.Drawing.Point(591, 198);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(205, 48);
            this.btnTaiLai.TabIndex = 14;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Ubuntu", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(223)))));
            this.label10.Location = new System.Drawing.Point(508, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(971, 127);
            this.label10.TabIndex = 15;
            this.label10.Text = "Lịch sử Đơn hàng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Ubuntu", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ghi chú đơn hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhiChuLichSu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1108, 749);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 173);
            this.panel1.TabIndex = 17;
            // 
            // txtGhiChuLichSu
            // 
            this.txtGhiChuLichSu.BackColor = System.Drawing.SystemColors.Info;
            this.txtGhiChuLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChuLichSu.Location = new System.Drawing.Point(8, 45);
            this.txtGhiChuLichSu.Multiline = true;
            this.txtGhiChuLichSu.Name = "txtGhiChuLichSu";
            this.txtGhiChuLichSu.ReadOnly = true;
            this.txtGhiChuLichSu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChuLichSu.Size = new System.Drawing.Size(746, 127);
            this.txtGhiChuLichSu.TabIndex = 18;
            // 
            // MaDonHang
            // 
            this.MaDonHang.DataPropertyName = "MaDonHang";
            this.MaDonHang.HeaderText = "Mã đơn ";
            this.MaDonHang.MinimumWidth = 9;
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.ReadOnly = true;
            // 
            // nguoiBan
            // 
            this.nguoiBan.DataPropertyName = "nguoiBan";
            this.nguoiBan.HeaderText = "Người bán";
            this.nguoiBan.MinimumWidth = 9;
            this.nguoiBan.Name = "nguoiBan";
            this.nguoiBan.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 9;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 9;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 9;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 9;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // PhuongThucThanhToan
            // 
            this.PhuongThucThanhToan.DataPropertyName = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.HeaderText = "P.thức thanh toán";
            this.PhuongThucThanhToan.MinimumWidth = 9;
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 9;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // frmLichSuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1865, 947);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvChiTietDonHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.label1);
            this.Name = "frmLichSuDonHang";
            this.Text = "Lịch sử Đơn hàng";
            this.Load += new System.EventHandler(this.fmLichSuDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGhiChuLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaTaiThoiDiemMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}