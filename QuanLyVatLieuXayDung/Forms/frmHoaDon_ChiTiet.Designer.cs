namespace QuanLyVatLieuXayDung.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnThoat = new Button();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            numSoLuongBan = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            cboVatLieu = new ComboBox();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenVatLieu = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGhiChuHoaDon = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(473, 323);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(78, 20);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(102, 323);
            btnLuuHoaDon.Margin = new Padding(2);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(114, 20);
            btnLuuHoaDon.TabIndex = 7;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(299, 323);
            btnInHoaDon.Margin = new Padding(2);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(78, 20);
            btnInHoaDon.TabIndex = 8;
            btnInHoaDon.Text = "in hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(300, 34);
            numSoLuongBan.Margin = new Padding(2);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(126, 23);
            numSoLuongBan.TabIndex = 8;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(148, 34);
            numDonGiaBan.Margin = new Padding(2);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(126, 23);
            numDonGiaBan.TabIndex = 7;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // cboVatLieu
            // 
            cboVatLieu.FormattingEnabled = true;
            cboVatLieu.Location = new Point(17, 33);
            cboVatLieu.Margin = new Padding(2);
            cboVatLieu.Name = "cboVatLieu";
            cboVatLieu.Size = new Size(117, 23);
            cboVatLieu.TabIndex = 6;
            cboVatLieu.SelectedIndexChanged += cboVatLieu_SelectedIndexChanged;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(554, 32);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 20);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(444, 32);
            btnXacNhanBan.Margin = new Padding(2);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(105, 20);
            btnXacNhanBan.TabIndex = 4;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 16);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 3;
            label6.Text = "Số lượng bán(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 15);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 2;
            label5.Text = "Đơn giá bán(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 1;
            label4.Text = "Sản phẩm(*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenVatLieu, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(2, 65);
            dataGridView.Margin = new Padding(2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(650, 135);
            dataGridView.TabIndex = 0;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 8;
            SanPhamID.Name = "SanPhamID";
            // 
            // TenVatLieu
            // 
            TenVatLieu.DataPropertyName = "TenVatLieu";
            TenVatLieu.HeaderText = "Tên sản phẩm";
            TenVatLieu.MinimumWidth = 8;
            TenVatLieu.Name = "TenVatLieu";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 8;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 8;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = Color.Blue;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(419, 25);
            cboKhachHang.Margin = new Padding(2);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(215, 23);
            cboKhachHang.TabIndex = 5;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(137, 25);
            cboNhanVien.Margin = new Padding(2);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(178, 23);
            cboNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Khách hàng(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Ghi chú hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhân viên lập(*):";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(137, 62);
            txtGhiChuHoaDon.Margin = new Padding(2);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(497, 23);
            txtGhiChuHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(cboVatLieu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(11, 108);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(654, 202);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(654, 97);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 362);
            Controls.Add(btnThoat);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(btnInHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHoaDon_ChiTiet";
            Text = "frmHoaDon_ChiTiet";
            Load += frmHoaDon_ChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private ComboBox cboVatLieu;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenVatLieu;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGhiChuHoaDon;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}