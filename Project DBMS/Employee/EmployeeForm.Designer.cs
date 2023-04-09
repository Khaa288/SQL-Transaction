
namespace Project_DBMS.Employee
{
    partial class EmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeID_Label = new System.Windows.Forms.Label();
            this.cus_label = new System.Windows.Forms.Label();
            this.HopDong_Grid = new System.Windows.Forms.DataGridView();
            this.DSHD_Label = new System.Windows.Forms.Label();
            this.TGHL_txtBox = new System.Windows.Forms.TextBox();
            this.GiaHan_Label = new System.Windows.Forms.Label();
            this.GiaHan_Button = new System.Windows.Forms.Button();
            this.HopDong_gb = new System.Windows.Forms.GroupBox();
            this.PTHH_Label = new System.Windows.Forms.Label();
            this.PTHH_txtBox = new System.Windows.Forms.TextBox();
            this.TaiLai_btn = new System.Windows.Forms.Button();
            this.mahopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PT_HoaHong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiKichHoat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TG_HieuLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HopDong_Grid)).BeginInit();
            this.HopDong_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.EmployeeID_Label);
            this.panel1.Controls.Add(this.cus_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 3;
            // 
            // EmployeeID_Label
            // 
            this.EmployeeID_Label.AutoSize = true;
            this.EmployeeID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.EmployeeID_Label.Location = new System.Drawing.Point(173, 9);
            this.EmployeeID_Label.Name = "EmployeeID_Label";
            this.EmployeeID_Label.Size = new System.Drawing.Size(99, 32);
            this.EmployeeID_Label.TabIndex = 4;
            this.EmployeeID_Label.Text = "label1";
            // 
            // cus_label
            // 
            this.cus_label.AutoSize = true;
            this.cus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cus_label.Location = new System.Drawing.Point(12, 9);
            this.cus_label.Name = "cus_label";
            this.cus_label.Size = new System.Drawing.Size(169, 32);
            this.cus_label.TabIndex = 3;
            this.cus_label.Text = "Nhân viên: ";
            // 
            // HopDong_Grid
            // 
            this.HopDong_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HopDong_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahopdong,
            this.MaNDD,
            this.PT_HoaHong,
            this.PhiKichHoat,
            this.TG_HieuLuc});
            this.HopDong_Grid.Location = new System.Drawing.Point(12, 134);
            this.HopDong_Grid.Name = "HopDong_Grid";
            this.HopDong_Grid.RowHeadersWidth = 51;
            this.HopDong_Grid.RowTemplate.Height = 24;
            this.HopDong_Grid.Size = new System.Drawing.Size(570, 296);
            this.HopDong_Grid.TabIndex = 4;
            this.HopDong_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HopDong_Grid_CellClick);
            // 
            // DSHD_Label
            // 
            this.DSHD_Label.AutoSize = true;
            this.DSHD_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.DSHD_Label.Location = new System.Drawing.Point(12, 89);
            this.DSHD_Label.Name = "DSHD_Label";
            this.DSHD_Label.Size = new System.Drawing.Size(210, 32);
            this.DSHD_Label.TabIndex = 5;
            this.DSHD_Label.Text = "Hợp đồng xử lí";
            // 
            // TGHL_txtBox
            // 
            this.TGHL_txtBox.Location = new System.Drawing.Point(17, 71);
            this.TGHL_txtBox.Name = "TGHL_txtBox";
            this.TGHL_txtBox.Size = new System.Drawing.Size(171, 22);
            this.TGHL_txtBox.TabIndex = 6;
            // 
            // GiaHan_Label
            // 
            this.GiaHan_Label.AutoSize = true;
            this.GiaHan_Label.Location = new System.Drawing.Point(14, 37);
            this.GiaHan_Label.Name = "GiaHan_Label";
            this.GiaHan_Label.Size = new System.Drawing.Size(82, 17);
            this.GiaHan_Label.TabIndex = 7;
            this.GiaHan_Label.Text = "Hiệu lực tới:";
            // 
            // GiaHan_Button
            // 
            this.GiaHan_Button.Location = new System.Drawing.Point(116, 182);
            this.GiaHan_Button.Name = "GiaHan_Button";
            this.GiaHan_Button.Size = new System.Drawing.Size(72, 23);
            this.GiaHan_Button.TabIndex = 8;
            this.GiaHan_Button.Text = "Gia hạn";
            this.GiaHan_Button.UseVisualStyleBackColor = true;
            this.GiaHan_Button.Click += new System.EventHandler(this.GiaHan_Button_Click);
            // 
            // HopDong_gb
            // 
            this.HopDong_gb.Controls.Add(this.PTHH_Label);
            this.HopDong_gb.Controls.Add(this.PTHH_txtBox);
            this.HopDong_gb.Controls.Add(this.GiaHan_Label);
            this.HopDong_gb.Controls.Add(this.GiaHan_Button);
            this.HopDong_gb.Controls.Add(this.TGHL_txtBox);
            this.HopDong_gb.Location = new System.Drawing.Point(600, 134);
            this.HopDong_gb.Name = "HopDong_gb";
            this.HopDong_gb.Size = new System.Drawing.Size(200, 310);
            this.HopDong_gb.TabIndex = 9;
            this.HopDong_gb.TabStop = false;
            this.HopDong_gb.Text = "Hợp đồng: ";
            // 
            // PTHH_Label
            // 
            this.PTHH_Label.AutoSize = true;
            this.PTHH_Label.Location = new System.Drawing.Point(14, 111);
            this.PTHH_Label.Name = "PTHH_Label";
            this.PTHH_Label.Size = new System.Drawing.Size(141, 17);
            this.PTHH_Label.TabIndex = 10;
            this.PTHH_Label.Text = "Phần trăm hoa hồng:";
            // 
            // PTHH_txtBox
            // 
            this.PTHH_txtBox.Location = new System.Drawing.Point(17, 140);
            this.PTHH_txtBox.Name = "PTHH_txtBox";
            this.PTHH_txtBox.Size = new System.Drawing.Size(171, 22);
            this.PTHH_txtBox.TabIndex = 9;
            // 
            // TaiLai_btn
            // 
            this.TaiLai_btn.Location = new System.Drawing.Point(510, 99);
            this.TaiLai_btn.Name = "TaiLai_btn";
            this.TaiLai_btn.Size = new System.Drawing.Size(72, 23);
            this.TaiLai_btn.TabIndex = 10;
            this.TaiLai_btn.Text = "Tải lại";
            this.TaiLai_btn.UseVisualStyleBackColor = true;
            this.TaiLai_btn.Click += new System.EventHandler(this.TaiLai_btn_Click);
            // 
            // mahopdong
            // 
            this.mahopdong.DataPropertyName = "MAHOPDONG";
            this.mahopdong.HeaderText = "Mã hợp đồng";
            this.mahopdong.MinimumWidth = 6;
            this.mahopdong.Name = "mahopdong";
            this.mahopdong.Width = 125;
            // 
            // MaNDD
            // 
            this.MaNDD.DataPropertyName = "MA_NDD";
            this.MaNDD.HeaderText = "Người đại diện";
            this.MaNDD.MinimumWidth = 6;
            this.MaNDD.Name = "MaNDD";
            this.MaNDD.Width = 125;
            // 
            // PT_HoaHong
            // 
            this.PT_HoaHong.DataPropertyName = "PT_HOAHONG";
            this.PT_HoaHong.HeaderText = "Hoa Hồng (%)";
            this.PT_HoaHong.MinimumWidth = 6;
            this.PT_HoaHong.Name = "PT_HoaHong";
            this.PT_HoaHong.Width = 125;
            // 
            // PhiKichHoat
            // 
            this.PhiKichHoat.DataPropertyName = "PHIKICHHOAT";
            this.PhiKichHoat.HeaderText = "Phí kích hoạt";
            this.PhiKichHoat.MinimumWidth = 6;
            this.PhiKichHoat.Name = "PhiKichHoat";
            this.PhiKichHoat.Width = 125;
            // 
            // TG_HieuLuc
            // 
            this.TG_HieuLuc.DataPropertyName = "TG_HIEULUC";
            this.TG_HieuLuc.HeaderText = "Thời gian hiệu lực";
            this.TG_HieuLuc.MinimumWidth = 6;
            this.TG_HieuLuc.Name = "TG_HieuLuc";
            this.TG_HieuLuc.Width = 125;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaiLai_btn);
            this.Controls.Add(this.HopDong_gb);
            this.Controls.Add(this.DSHD_Label);
            this.Controls.Add(this.HopDong_Grid);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HopDong_Grid)).EndInit();
            this.HopDong_gb.ResumeLayout(false);
            this.HopDong_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmployeeID_Label;
        private System.Windows.Forms.Label cus_label;
        private System.Windows.Forms.DataGridView HopDong_Grid;
        private System.Windows.Forms.Label DSHD_Label;
        private System.Windows.Forms.TextBox TGHL_txtBox;
        private System.Windows.Forms.Label GiaHan_Label;
        private System.Windows.Forms.Button GiaHan_Button;
        private System.Windows.Forms.GroupBox HopDong_gb;
        private System.Windows.Forms.Label PTHH_Label;
        private System.Windows.Forms.TextBox PTHH_txtBox;
        private System.Windows.Forms.Button TaiLai_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PT_HoaHong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiKichHoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TG_HieuLuc;
    }
}