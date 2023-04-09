
namespace Project_DBMS.Shipper
{
    partial class ShipperForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TaiXe_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInforTaiXe = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.DSDH_Grid = new System.Windows.Forms.DataGridView();
            this.DonHang_gb = new System.Windows.Forms.GroupBox();
            this.HoanTat_Radio = new System.Windows.Forms.RadioButton();
            this.VChuyen_Radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDH_Grid)).BeginInit();
            this.DonHang_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.TaiXe_Label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInforTaiXe);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TaiXe_Label
            // 
            this.TaiXe_Label.AutoSize = true;
            this.TaiXe_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TaiXe_Label.Location = new System.Drawing.Point(127, 18);
            this.TaiXe_Label.Name = "TaiXe_Label";
            this.TaiXe_Label.Size = new System.Drawing.Size(210, 38);
            this.TaiXe_Label.TabIndex = 1;
            this.TaiXe_Label.Tag = "label2";
            this.TaiXe_Label.Text = "TaiXe_Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài xế: ";
            // 
            // btnInforTaiXe
            // 
            this.btnInforTaiXe.Location = new System.Drawing.Point(753, 18);
            this.btnInforTaiXe.Name = "btnInforTaiXe";
            this.btnInforTaiXe.Size = new System.Drawing.Size(126, 36);
            this.btnInforTaiXe.TabIndex = 1;
            this.btnInforTaiXe.Text = "Information";
            this.btnInforTaiXe.UseVisualStyleBackColor = true;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(756, 100);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(122, 36);
            this.btnViewOrder.TabIndex = 2;
            this.btnViewOrder.Text = "Danh sách đơn";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.Location = new System.Drawing.Point(145, 233);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(144, 36);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // DSDH_Grid
            // 
            this.DSDH_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSDH_Grid.Location = new System.Drawing.Point(336, 157);
            this.DSDH_Grid.Name = "DSDH_Grid";
            this.DSDH_Grid.RowHeadersWidth = 51;
            this.DSDH_Grid.RowTemplate.Height = 24;
            this.DSDH_Grid.Size = new System.Drawing.Size(542, 311);
            this.DSDH_Grid.TabIndex = 5;
            this.DSDH_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSDH_Grid_CellClick);
            // 
            // DonHang_gb
            // 
            this.DonHang_gb.Controls.Add(this.HoanTat_Radio);
            this.DonHang_gb.Controls.Add(this.VChuyen_Radio);
            this.DonHang_gb.Controls.Add(this.label2);
            this.DonHang_gb.Controls.Add(this.btn_Update);
            this.DonHang_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DonHang_gb.Location = new System.Drawing.Point(12, 157);
            this.DonHang_gb.Name = "DonHang_gb";
            this.DonHang_gb.Size = new System.Drawing.Size(295, 311);
            this.DonHang_gb.TabIndex = 6;
            this.DonHang_gb.TabStop = false;
            this.DonHang_gb.Text = "Đơn hàng: ";
            // 
            // HoanTat_Radio
            // 
            this.HoanTat_Radio.AutoSize = true;
            this.HoanTat_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HoanTat_Radio.Location = new System.Drawing.Point(18, 159);
            this.HoanTat_Radio.Name = "HoanTat_Radio";
            this.HoanTat_Radio.Size = new System.Drawing.Size(83, 21);
            this.HoanTat_Radio.TabIndex = 6;
            this.HoanTat_Radio.TabStop = true;
            this.HoanTat_Radio.Text = "Hoàn tất";
            this.HoanTat_Radio.UseVisualStyleBackColor = true;
            // 
            // VChuyen_Radio
            // 
            this.VChuyen_Radio.AutoSize = true;
            this.VChuyen_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.VChuyen_Radio.Location = new System.Drawing.Point(18, 132);
            this.VChuyen_Radio.Name = "VChuyen_Radio";
            this.VChuyen_Radio.Size = new System.Drawing.Size(140, 21);
            this.VChuyen_Radio.TabIndex = 5;
            this.VChuyen_Radio.TabStop = true;
            this.VChuyen_Radio.Text = "Đang vận chuyển";
            this.VChuyen_Radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tình trạng";
            // 
            // ShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 485);
            this.Controls.Add(this.DonHang_gb);
            this.Controls.Add(this.DSDH_Grid);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShipperForm";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDH_Grid)).EndInit();
            this.DonHang_gb.ResumeLayout(false);
            this.DonHang_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TaiXe_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInforTaiXe;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView DSDH_Grid;

        #endregion

        private System.Windows.Forms.GroupBox DonHang_gb;
        private System.Windows.Forms.RadioButton HoanTat_Radio;
        private System.Windows.Forms.RadioButton VChuyen_Radio;
        private System.Windows.Forms.Label label2;
    }
}