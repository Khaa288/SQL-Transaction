
namespace Project_DBMS.Customer
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerID_Label = new System.Windows.Forms.Label();
            this.cus_label = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.DonHang_gb = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.XemChiTiet_Button = new System.Windows.Forms.Button();
            this.Huydon_Button = new System.Windows.Forms.Button();
            this.Xem_Button = new System.Windows.Forms.Button();
            this.dathang_button = new System.Windows.Forms.Button();
            this.DHKH_Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiVanChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIXEXULI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.DonHang_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DHKH_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.customerID_Label);
            this.panel1.Controls.Add(this.cus_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 44);
            this.panel1.TabIndex = 2;
            // 
            // customerID_Label
            // 
            this.customerID_Label.AutoSize = true;
            this.customerID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.customerID_Label.Location = new System.Drawing.Point(194, 9);
            this.customerID_Label.Name = "customerID_Label";
            this.customerID_Label.Size = new System.Drawing.Size(99, 32);
            this.customerID_Label.TabIndex = 4;
            this.customerID_Label.Text = "label1";
            // 
            // cus_label
            // 
            this.cus_label.AutoSize = true;
            this.cus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cus_label.Location = new System.Drawing.Point(12, 9);
            this.cus_label.Name = "cus_label";
            this.cus_label.Size = new System.Drawing.Size(194, 32);
            this.cus_label.TabIndex = 3;
            this.cus_label.Text = "Khách hàng: ";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.DonHang_gb);
            this.panelContainer.Controls.Add(this.Xem_Button);
            this.panelContainer.Controls.Add(this.dathang_button);
            this.panelContainer.Controls.Add(this.DHKH_Grid);
            this.panelContainer.Location = new System.Drawing.Point(0, 154);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1182, 428);
            this.panelContainer.TabIndex = 4;
            // 
            // DonHang_gb
            // 
            this.DonHang_gb.Controls.Add(this.pictureBox1);
            this.DonHang_gb.Controls.Add(this.XemChiTiet_Button);
            this.DonHang_gb.Controls.Add(this.Huydon_Button);
            this.DonHang_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DonHang_gb.Location = new System.Drawing.Point(900, 15);
            this.DonHang_gb.Name = "DonHang_gb";
            this.DonHang_gb.Size = new System.Drawing.Size(270, 349);
            this.DonHang_gb.TabIndex = 4;
            this.DonHang_gb.TabStop = false;
            this.DonHang_gb.Text = "Đơn hàng: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // XemChiTiet_Button
            // 
            this.XemChiTiet_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.XemChiTiet_Button.Location = new System.Drawing.Point(5, 271);
            this.XemChiTiet_Button.Name = "XemChiTiet_Button";
            this.XemChiTiet_Button.Size = new System.Drawing.Size(259, 33);
            this.XemChiTiet_Button.TabIndex = 4;
            this.XemChiTiet_Button.Text = "Xem chi tiết";
            this.XemChiTiet_Button.UseVisualStyleBackColor = true;
            this.XemChiTiet_Button.Click += new System.EventHandler(this.XemChiTiet_Button_Click);
            // 
            // Huydon_Button
            // 
            this.Huydon_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Huydon_Button.Location = new System.Drawing.Point(6, 310);
            this.Huydon_Button.Name = "Huydon_Button";
            this.Huydon_Button.Size = new System.Drawing.Size(259, 33);
            this.Huydon_Button.TabIndex = 3;
            this.Huydon_Button.Text = "Hủy đơn";
            this.Huydon_Button.UseVisualStyleBackColor = true;
            this.Huydon_Button.Click += new System.EventHandler(this.Huydon_Button_Click);
            // 
            // Xem_Button
            // 
            this.Xem_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Xem_Button.Location = new System.Drawing.Point(18, 379);
            this.Xem_Button.Name = "Xem_Button";
            this.Xem_Button.Size = new System.Drawing.Size(282, 33);
            this.Xem_Button.TabIndex = 2;
            this.Xem_Button.Text = "Danh sách đơn hàng";
            this.Xem_Button.UseVisualStyleBackColor = true;
            this.Xem_Button.Click += new System.EventHandler(this.Xem_Button_Click);
            // 
            // dathang_button
            // 
            this.dathang_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dathang_button.Location = new System.Drawing.Point(605, 379);
            this.dathang_button.Name = "dathang_button";
            this.dathang_button.Size = new System.Drawing.Size(282, 33);
            this.dathang_button.TabIndex = 1;
            this.dathang_button.Text = "Tiến hành đặt hàng";
            this.dathang_button.UseVisualStyleBackColor = true;
            this.dathang_button.Click += new System.EventHandler(this.dathang_button_Click);
            // 
            // DHKH_Grid
            // 
            this.DHKH_Grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DHKH_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DHKH_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChiNhanh,
            this.MaDonHang,
            this.NgayLap,
            this.HinhThucThanhToan,
            this.TinhTrang,
            this.PhiVanChuyen,
            this.TongTien,
            this.TAIXEXULI});
            this.DHKH_Grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DHKH_Grid.Location = new System.Drawing.Point(18, 15);
            this.DHKH_Grid.Name = "DHKH_Grid";
            this.DHKH_Grid.RowHeadersWidth = 51;
            this.DHKH_Grid.RowTemplate.Height = 24;
            this.DHKH_Grid.Size = new System.Drawing.Size(869, 349);
            this.DHKH_Grid.TabIndex = 0;
            this.DHKH_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DHKH_Grid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(296, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách đơn hàng";
            // 
            // ChiNhanh
            // 
            this.ChiNhanh.DataPropertyName = "CHINHANH";
            this.ChiNhanh.HeaderText = "Chi nhánh";
            this.ChiNhanh.MinimumWidth = 6;
            this.ChiNhanh.Name = "ChiNhanh";
            this.ChiNhanh.Width = 125;
            // 
            // MaDonHang
            // 
            this.MaDonHang.DataPropertyName = "MADONHANG";
            this.MaDonHang.HeaderText = "Mã đơn hàng";
            this.MaDonHang.MinimumWidth = 6;
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NGAYLAP";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // HinhThucThanhToan
            // 
            this.HinhThucThanhToan.DataPropertyName = "HINHTHUCTHANHTOAN";
            this.HinhThucThanhToan.HeaderText = "Hình thức thanh toán";
            this.HinhThucThanhToan.MinimumWidth = 6;
            this.HinhThucThanhToan.Name = "HinhThucThanhToan";
            this.HinhThucThanhToan.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TINHTRANG";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // PhiVanChuyen
            // 
            this.PhiVanChuyen.DataPropertyName = "PHIVANCHUYEN";
            this.PhiVanChuyen.HeaderText = "Phí vận chuyển";
            this.PhiVanChuyen.MinimumWidth = 6;
            this.PhiVanChuyen.Name = "PhiVanChuyen";
            this.PhiVanChuyen.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TONGTIEN";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // TAIXEXULI
            // 
            this.TAIXEXULI.DataPropertyName = "TAIXEXULI";
            this.TAIXEXULI.HeaderText = "Tài xế xử lí";
            this.TAIXEXULI.MinimumWidth = 6;
            this.TAIXEXULI.Name = "TAIXEXULI";
            this.TAIXEXULI.Width = 125;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.DonHang_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DHKH_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label customerID_Label;
        private System.Windows.Forms.Label cus_label;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button Xem_Button;
        private System.Windows.Forms.Button dathang_button;
        private System.Windows.Forms.DataGridView DHKH_Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Huydon_Button;
        private System.Windows.Forms.GroupBox DonHang_gb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button XemChiTiet_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiVanChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIXEXULI;
    }
}