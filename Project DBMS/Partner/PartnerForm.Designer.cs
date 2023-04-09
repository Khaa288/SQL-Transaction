
namespace Project_DBMS.Partner
{
    partial class PartnerForm
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
            this.Partner_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partnerID_Label = new System.Windows.Forms.Label();
            this.par_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QL_ChiNhanh_button = new System.Windows.Forms.Button();
            this.QL_ThucDon_button = new System.Windows.Forms.Button();
            this.QL_DonHang = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.QL_HopDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Partner_Label
            // 
            this.Partner_Label.AutoSize = true;
            this.Partner_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Partner_Label.Location = new System.Drawing.Point(12, 9);
            this.Partner_Label.Name = "Partner_Label";
            this.Partner_Label.Size = new System.Drawing.Size(0, 32);
            this.Partner_Label.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.partnerID_Label);
            this.panel1.Controls.Add(this.par_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 44);
            this.panel1.TabIndex = 1;
            // 
            // partnerID_Label
            // 
            this.partnerID_Label.AutoSize = true;
            this.partnerID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.partnerID_Label.Location = new System.Drawing.Point(124, 9);
            this.partnerID_Label.Name = "partnerID_Label";
            this.partnerID_Label.Size = new System.Drawing.Size(99, 32);
            this.partnerID_Label.TabIndex = 4;
            this.partnerID_Label.Text = "label1";
            // 
            // par_label
            // 
            this.par_label.AutoSize = true;
            this.par_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.par_label.Location = new System.Drawing.Point(12, 9);
            this.par_label.Name = "par_label";
            this.par_label.Size = new System.Drawing.Size(127, 32);
            this.par_label.TabIndex = 3;
            this.par_label.Text = "Đối tác: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.QL_HopDong);
            this.panel2.Controls.Add(this.QL_ChiNhanh_button);
            this.panel2.Controls.Add(this.QL_ThucDon_button);
            this.panel2.Controls.Add(this.QL_DonHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 42);
            this.panel2.TabIndex = 2;
            // 
            // QL_ChiNhanh_button
            // 
            this.QL_ChiNhanh_button.Location = new System.Drawing.Point(-1, 0);
            this.QL_ChiNhanh_button.Name = "QL_ChiNhanh_button";
            this.QL_ChiNhanh_button.Size = new System.Drawing.Size(300, 43);
            this.QL_ChiNhanh_button.TabIndex = 3;
            this.QL_ChiNhanh_button.Text = "Quản lí chi nhánh";
            this.QL_ChiNhanh_button.UseVisualStyleBackColor = true;
            this.QL_ChiNhanh_button.Click += new System.EventHandler(this.QL_ChiNhanh_button_Click);
            // 
            // QL_ThucDon_button
            // 
            this.QL_ThucDon_button.Location = new System.Drawing.Point(296, 0);
            this.QL_ThucDon_button.Name = "QL_ThucDon_button";
            this.QL_ThucDon_button.Size = new System.Drawing.Size(300, 43);
            this.QL_ThucDon_button.TabIndex = 4;
            this.QL_ThucDon_button.Text = "Quản lí thực đơn";
            this.QL_ThucDon_button.UseVisualStyleBackColor = true;
            this.QL_ThucDon_button.Click += new System.EventHandler(this.QL_ThucDon_button_Click);
            // 
            // QL_DonHang
            // 
            this.QL_DonHang.Location = new System.Drawing.Point(594, -1);
            this.QL_DonHang.Name = "QL_DonHang";
            this.QL_DonHang.Size = new System.Drawing.Size(306, 43);
            this.QL_DonHang.TabIndex = 5;
            this.QL_DonHang.Text = "Quản lí đơn hàng";
            this.QL_DonHang.UseVisualStyleBackColor = true;
            this.QL_DonHang.Click += new System.EventHandler(this.QL_DonHang_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 92);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1182, 484);
            this.panelContainer.TabIndex = 3;
            // 
            // QL_HopDong
            // 
            this.QL_HopDong.Location = new System.Drawing.Point(882, -1);
            this.QL_HopDong.Name = "QL_HopDong";
            this.QL_HopDong.Size = new System.Drawing.Size(300, 43);
            this.QL_HopDong.TabIndex = 6;
            this.QL_HopDong.Text = "Quản lí hợp đồng";
            this.QL_HopDong.UseVisualStyleBackColor = true;
            this.QL_HopDong.Click += new System.EventHandler(this.QL_HopDong_Click);
            // 
            // PartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 578);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Partner_Label);
            this.Name = "PartnerForm";
            this.Text = "Đối tác";
            this.Load += new System.EventHandler(this.Partner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Partner_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label par_label;
        private System.Windows.Forms.Button QL_DonHang;
        private System.Windows.Forms.Button QL_ThucDon_button;
        private System.Windows.Forms.Button QL_ChiNhanh_button;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label partnerID_Label;
        private System.Windows.Forms.Button QL_HopDong;
    }
}