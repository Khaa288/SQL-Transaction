
namespace Project_DBMS.Customer
{
    partial class OrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DonHang_gb = new System.Windows.Forms.GroupBox();
            this.CT_MonAn_Grid = new System.Windows.Forms.DataGridView();
            this.CN_Label = new System.Windows.Forms.Label();
            this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonHang_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_MonAn_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // DonHang_gb
            // 
            this.DonHang_gb.Controls.Add(this.CT_MonAn_Grid);
            this.DonHang_gb.Controls.Add(this.CN_Label);
            this.DonHang_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DonHang_gb.Location = new System.Drawing.Point(12, 21);
            this.DonHang_gb.Name = "DonHang_gb";
            this.DonHang_gb.Size = new System.Drawing.Size(281, 329);
            this.DonHang_gb.TabIndex = 0;
            this.DonHang_gb.TabStop = false;
            this.DonHang_gb.Text = "Đơn hàng: ";
            // 
            // CT_MonAn_Grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_MonAn_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CT_MonAn_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CT_MonAn_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonAn,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CT_MonAn_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CT_MonAn_Grid.Location = new System.Drawing.Point(10, 81);
            this.CT_MonAn_Grid.Name = "CT_MonAn_Grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CT_MonAn_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CT_MonAn_Grid.RowHeadersWidth = 51;
            this.CT_MonAn_Grid.RowTemplate.Height = 24;
            this.CT_MonAn_Grid.Size = new System.Drawing.Size(265, 242);
            this.CT_MonAn_Grid.TabIndex = 1;
            // 
            // CN_Label
            // 
            this.CN_Label.AutoSize = true;
            this.CN_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CN_Label.Location = new System.Drawing.Point(6, 48);
            this.CN_Label.Name = "CN_Label";
            this.CN_Label.Size = new System.Drawing.Size(105, 20);
            this.CN_Label.TabIndex = 0;
            this.CN_Label.Text = "- Chi nhánh: ";
            // 
            // MonAn
            // 
            this.MonAn.DataPropertyName = "TENMON";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.MonAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.MonAn.HeaderText = "Món ăn";
            this.MonAn.MinimumWidth = 6;
            this.MonAn.Name = "MonAn";
            this.MonAn.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 362);
            this.Controls.Add(this.DonHang_gb);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.DonHang_gb.ResumeLayout(false);
            this.DonHang_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_MonAn_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DonHang_gb;
        private System.Windows.Forms.DataGridView CT_MonAn_Grid;
        private System.Windows.Forms.Label CN_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}