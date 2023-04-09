
namespace Project_DBMS.Customer
{
    partial class Order
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
            this.DonHang_gb = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CN_cbb = new System.Windows.Forms.ComboBox();
            this.btn_Tailai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TD_Grid = new System.Windows.Forms.DataGridView();
            this.ChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MieuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonHang_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TD_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // DonHang_gb
            // 
            this.DonHang_gb.Controls.Add(this.label2);
            this.DonHang_gb.Controls.Add(this.CN_cbb);
            this.DonHang_gb.Controls.Add(this.btn_Tailai);
            this.DonHang_gb.Controls.Add(this.button1);
            this.DonHang_gb.Controls.Add(this.TD_Grid);
            this.DonHang_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DonHang_gb.Location = new System.Drawing.Point(12, 12);
            this.DonHang_gb.Name = "DonHang_gb";
            this.DonHang_gb.Size = new System.Drawing.Size(858, 429);
            this.DonHang_gb.TabIndex = 0;
            this.DonHang_gb.TabStop = false;
            this.DonHang_gb.Text = "Đơn hàng mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn chi nhánh";
            // 
            // CN_cbb
            // 
            this.CN_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CN_cbb.FormattingEnabled = true;
            this.CN_cbb.Location = new System.Drawing.Point(128, 60);
            this.CN_cbb.Name = "CN_cbb";
            this.CN_cbb.Size = new System.Drawing.Size(89, 24);
            this.CN_cbb.TabIndex = 4;
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Tailai.Location = new System.Drawing.Point(232, 58);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(77, 26);
            this.btn_Tailai.TabIndex = 3;
            this.btn_Tailai.Text = "Tải lại";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            this.btn_Tailai.Click += new System.EventHandler(this.btn_Tailai_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TD_Grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TD_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TD_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TD_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChiNhanh,
            this.MonAn,
            this.MieuTa,
            this.Gia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TD_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TD_Grid.Location = new System.Drawing.Point(18, 97);
            this.TD_Grid.Name = "TD_Grid";
            this.TD_Grid.RowHeadersWidth = 51;
            this.TD_Grid.RowTemplate.Height = 24;
            this.TD_Grid.Size = new System.Drawing.Size(672, 304);
            this.TD_Grid.TabIndex = 0;
            // 
            // ChiNhanh
            // 
            this.ChiNhanh.DataPropertyName = "MACHINHANH";
            this.ChiNhanh.HeaderText = "Chi nhánh";
            this.ChiNhanh.MinimumWidth = 6;
            this.ChiNhanh.Name = "ChiNhanh";
            this.ChiNhanh.Width = 125;
            // 
            // MonAn
            // 
            this.MonAn.DataPropertyName = "TENMONAN";
            this.MonAn.HeaderText = "Món ăn";
            this.MonAn.MinimumWidth = 6;
            this.MonAn.Name = "MonAn";
            this.MonAn.Width = 125;
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
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.DonHang_gb);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.DonHang_gb.ResumeLayout(false);
            this.DonHang_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TD_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DonHang_gb;
        private System.Windows.Forms.DataGridView TD_Grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MieuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button btn_Tailai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CN_cbb;
    }
}