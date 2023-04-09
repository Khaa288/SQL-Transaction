
namespace Project_DBMS.Partner.PartnerControl
{
    partial class BranchControl
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
            this.DSCN_Label = new System.Windows.Forms.Label();
            this.DSCN_Grid = new System.Windows.Forms.DataGridView();
            this.DS_CN_Button = new System.Windows.Forms.Button();
            this.update_gb = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Status_Label = new System.Windows.Forms.Label();
            this.ChiNhanh_Label = new System.Windows.Forms.Label();
            this.DonHang_txtBox = new System.Windows.Forms.TextBox();
            this.Update_OrderStat_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSCN_Grid)).BeginInit();
            this.update_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSCN_Label
            // 
            this.DSCN_Label.AutoSize = true;
            this.DSCN_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSCN_Label.Location = new System.Drawing.Point(17, 15);
            this.DSCN_Label.Name = "DSCN_Label";
            this.DSCN_Label.Size = new System.Drawing.Size(300, 32);
            this.DSCN_Label.TabIndex = 2;
            this.DSCN_Label.Text = "Danh sách chi nhánh";
            // 
            // DSCN_Grid
            // 
            this.DSCN_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSCN_Grid.Location = new System.Drawing.Point(23, 63);
            this.DSCN_Grid.Name = "DSCN_Grid";
            this.DSCN_Grid.RowHeadersWidth = 51;
            this.DSCN_Grid.RowTemplate.Height = 24;
            this.DSCN_Grid.Size = new System.Drawing.Size(809, 401);
            this.DSCN_Grid.TabIndex = 3;
            // 
            // DS_CN_Button
            // 
            this.DS_CN_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DS_CN_Button.Location = new System.Drawing.Point(1060, 361);
            this.DS_CN_Button.Name = "DS_CN_Button";
            this.DS_CN_Button.Size = new System.Drawing.Size(103, 103);
            this.DS_CN_Button.TabIndex = 11;
            this.DS_CN_Button.Text = "Danh sách chi nhánh";
            this.DS_CN_Button.UseVisualStyleBackColor = true;
            this.DS_CN_Button.Click += new System.EventHandler(this.DS_CN_Button_Click);
            // 
            // update_gb
            // 
            this.update_gb.Controls.Add(this.radioButton2);
            this.update_gb.Controls.Add(this.radioButton1);
            this.update_gb.Controls.Add(this.Status_Label);
            this.update_gb.Controls.Add(this.ChiNhanh_Label);
            this.update_gb.Controls.Add(this.DonHang_txtBox);
            this.update_gb.Controls.Add(this.Update_OrderStat_Button);
            this.update_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.update_gb.Location = new System.Drawing.Point(857, 63);
            this.update_gb.Name = "update_gb";
            this.update_gb.Size = new System.Drawing.Size(306, 172);
            this.update_gb.TabIndex = 12;
            this.update_gb.TabStop = false;
            this.update_gb.Text = "Cập nhật chi nhánh";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton2.Location = new System.Drawing.Point(13, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 21);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "tạm nghỉ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton1.Location = new System.Drawing.Point(13, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "bình thường";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Status_Label.Location = new System.Drawing.Point(10, 76);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(73, 17);
            this.Status_Label.TabIndex = 9;
            this.Status_Label.Text = "Tình trạng";
            // 
            // ChiNhanh_Label
            // 
            this.ChiNhanh_Label.AutoSize = true;
            this.ChiNhanh_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChiNhanh_Label.Location = new System.Drawing.Point(13, 43);
            this.ChiNhanh_Label.Name = "ChiNhanh_Label";
            this.ChiNhanh_Label.Size = new System.Drawing.Size(72, 17);
            this.ChiNhanh_Label.TabIndex = 8;
            this.ChiNhanh_Label.Text = "Chi nhánh";
            // 
            // DonHang_txtBox
            // 
            this.DonHang_txtBox.Location = new System.Drawing.Point(89, 37);
            this.DonHang_txtBox.Name = "DonHang_txtBox";
            this.DonHang_txtBox.Size = new System.Drawing.Size(149, 27);
            this.DonHang_txtBox.TabIndex = 7;
            // 
            // Update_OrderStat_Button
            // 
            this.Update_OrderStat_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Update_OrderStat_Button.Location = new System.Drawing.Point(197, 114);
            this.Update_OrderStat_Button.Name = "Update_OrderStat_Button";
            this.Update_OrderStat_Button.Size = new System.Drawing.Size(103, 49);
            this.Update_OrderStat_Button.TabIndex = 4;
            this.Update_OrderStat_Button.Text = "Cập nhật";
            this.Update_OrderStat_Button.UseVisualStyleBackColor = true;
            // 
            // BranchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update_gb);
            this.Controls.Add(this.DS_CN_Button);
            this.Controls.Add(this.DSCN_Grid);
            this.Controls.Add(this.DSCN_Label);
            this.Name = "BranchControl";
            this.Size = new System.Drawing.Size(1182, 484);
            ((System.ComponentModel.ISupportInitialize)(this.DSCN_Grid)).EndInit();
            this.update_gb.ResumeLayout(false);
            this.update_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DSCN_Label;
        private System.Windows.Forms.DataGridView DSCN_Grid;
        private System.Windows.Forms.Button DS_CN_Button;
        private System.Windows.Forms.GroupBox update_gb;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Label ChiNhanh_Label;
        private System.Windows.Forms.TextBox DonHang_txtBox;
        private System.Windows.Forms.Button Update_OrderStat_Button;
    }
}
