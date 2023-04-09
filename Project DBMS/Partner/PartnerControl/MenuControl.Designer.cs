
namespace Project_DBMS.Partner.PartnerControl
{
    partial class MenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DSDH_Label = new System.Windows.Forms.Label();
            this.DSTDGrid = new System.Windows.Forms.DataGridView();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MieuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CN_cbb = new System.Windows.Forms.ComboBox();
            this.selectCN_Label = new System.Windows.Forms.Label();
            this.Xem_Button = new System.Windows.Forms.Button();
            this.MonAn_cbb = new System.Windows.Forms.ComboBox();
            this.Them_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSTDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DSDH_Label
            // 
            this.DSDH_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DSDH_Label.AutoSize = true;
            this.DSDH_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSDH_Label.Location = new System.Drawing.Point(17, 19);
            this.DSDH_Label.Name = "DSDH_Label";
            this.DSDH_Label.Size = new System.Drawing.Size(141, 32);
            this.DSDH_Label.TabIndex = 2;
            this.DSDH_Label.Text = "Thực đơn";
            // 
            // DSTDGrid
            // 
            this.DSTDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSTDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn,
            this.MieuTa,
            this.Gia,
            this.delete_btn});
            this.DSTDGrid.Location = new System.Drawing.Point(23, 72);
            this.DSTDGrid.Name = "DSTDGrid";
            this.DSTDGrid.RowHeadersWidth = 51;
            this.DSTDGrid.RowTemplate.Height = 24;
            this.DSTDGrid.Size = new System.Drawing.Size(806, 383);
            this.DSTDGrid.TabIndex = 3;
            this.DSTDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSTDGrid_CellContentClick);
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TENMON";
            this.TenMonAn.HeaderText = "Món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 125;
            // 
            // MieuTa
            // 
            this.MieuTa.DataPropertyName = "MIEUTA";
            this.MieuTa.HeaderText = "Miêu tả";
            this.MieuTa.MinimumWidth = 6;
            this.MieuTa.Name = "MieuTa";
            this.MieuTa.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GIA";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // delete_btn
            // 
            this.delete_btn.HeaderText = "Delete";
            this.delete_btn.MinimumWidth = 6;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Text = "Xóa";
            this.delete_btn.UseColumnTextForButtonValue = true;
            this.delete_btn.Width = 125;
            // 
            // CN_cbb
            // 
            this.CN_cbb.FormattingEnabled = true;
            this.CN_cbb.Location = new System.Drawing.Point(616, 29);
            this.CN_cbb.Name = "CN_cbb";
            this.CN_cbb.Size = new System.Drawing.Size(121, 24);
            this.CN_cbb.TabIndex = 4;
            // 
            // selectCN_Label
            // 
            this.selectCN_Label.AutoSize = true;
            this.selectCN_Label.Location = new System.Drawing.Point(503, 32);
            this.selectCN_Label.Name = "selectCN_Label";
            this.selectCN_Label.Size = new System.Drawing.Size(107, 17);
            this.selectCN_Label.TabIndex = 5;
            this.selectCN_Label.Text = "Chọn chi nhánh";
            // 
            // Xem_Button
            // 
            this.Xem_Button.Location = new System.Drawing.Point(754, 29);
            this.Xem_Button.Name = "Xem_Button";
            this.Xem_Button.Size = new System.Drawing.Size(75, 23);
            this.Xem_Button.TabIndex = 6;
            this.Xem_Button.Text = "Xem";
            this.Xem_Button.UseVisualStyleBackColor = true;
            this.Xem_Button.Click += new System.EventHandler(this.Xem_Button_Click);
            // 
            // MonAn_cbb
            // 
            this.MonAn_cbb.FormattingEnabled = true;
            this.MonAn_cbb.Location = new System.Drawing.Point(946, 72);
            this.MonAn_cbb.Name = "MonAn_cbb";
            this.MonAn_cbb.Size = new System.Drawing.Size(121, 24);
            this.MonAn_cbb.TabIndex = 7;
            // 
            // Them_btn
            // 
            this.Them_btn.Location = new System.Drawing.Point(1083, 73);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(75, 23);
            this.Them_btn.TabIndex = 8;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.UseVisualStyleBackColor = true;
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Món ăn";
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Them_btn);
            this.Controls.Add(this.MonAn_cbb);
            this.Controls.Add(this.Xem_Button);
            this.Controls.Add(this.selectCN_Label);
            this.Controls.Add(this.CN_cbb);
            this.Controls.Add(this.DSTDGrid);
            this.Controls.Add(this.DSDH_Label);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(1182, 484);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSTDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DSDH_Label;
        private System.Windows.Forms.DataGridView DSTDGrid;
        private System.Windows.Forms.ComboBox CN_cbb;
        private System.Windows.Forms.Label selectCN_Label;
        private System.Windows.Forms.Button Xem_Button;
        private System.Windows.Forms.ComboBox MonAn_cbb;
        private System.Windows.Forms.Button Them_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MieuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewButtonColumn delete_btn;
    }
}
