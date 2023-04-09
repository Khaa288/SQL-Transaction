
namespace Project_DBMS.Partner.PartnerControl
{
    partial class OrderControl
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
            this.DSDHGrid = new System.Windows.Forms.DataGridView();
            this.Update_OrderStat_Button = new System.Windows.Forms.Button();
            this.update_gb = new System.Windows.Forms.GroupBox();
            this.DangCB_Radio = new System.Windows.Forms.RadioButton();
            this.ChoNhan_Radio = new System.Windows.Forms.RadioButton();
            this.Status_Label = new System.Windows.Forms.Label();
            this.DS_DH_Button = new System.Windows.Forms.Button();
            this.Dirty_Radio = new System.Windows.Forms.RadioButton();
            this.LostUp_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSDHGrid)).BeginInit();
            this.update_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSDH_Label
            // 
            this.DSDH_Label.AutoSize = true;
            this.DSDH_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSDH_Label.Location = new System.Drawing.Point(17, 15);
            this.DSDH_Label.Name = "DSDH_Label";
            this.DSDH_Label.Size = new System.Drawing.Size(294, 32);
            this.DSDH_Label.TabIndex = 1;
            this.DSDH_Label.Text = "Danh sách đơn hàng";
            // 
            // DSDHGrid
            // 
            this.DSDHGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSDHGrid.Location = new System.Drawing.Point(23, 63);
            this.DSDHGrid.Name = "DSDHGrid";
            this.DSDHGrid.RowHeadersWidth = 51;
            this.DSDHGrid.RowTemplate.Height = 24;
            this.DSDHGrid.Size = new System.Drawing.Size(809, 401);
            this.DSDHGrid.TabIndex = 2;
            this.DSDHGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSDHGrid_CellClick);
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
            this.Update_OrderStat_Button.Click += new System.EventHandler(this.Update_OrderStat_Button_Click);
            // 
            // update_gb
            // 
            this.update_gb.Controls.Add(this.DangCB_Radio);
            this.update_gb.Controls.Add(this.ChoNhan_Radio);
            this.update_gb.Controls.Add(this.Status_Label);
            this.update_gb.Controls.Add(this.Update_OrderStat_Button);
            this.update_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.update_gb.Location = new System.Drawing.Point(855, 131);
            this.update_gb.Name = "update_gb";
            this.update_gb.Size = new System.Drawing.Size(306, 325);
            this.update_gb.TabIndex = 0;
            this.update_gb.TabStop = false;
            this.update_gb.Text = "Đơn hàng: ";
            // 
            // DangCB_Radio
            // 
            this.DangCB_Radio.AutoSize = true;
            this.DangCB_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DangCB_Radio.Location = new System.Drawing.Point(16, 98);
            this.DangCB_Radio.Name = "DangCB_Radio";
            this.DangCB_Radio.Size = new System.Drawing.Size(121, 21);
            this.DangCB_Radio.TabIndex = 11;
            this.DangCB_Radio.TabStop = true;
            this.DangCB_Radio.Text = "Đang chuẩn bị";
            this.DangCB_Radio.UseVisualStyleBackColor = true;
            // 
            // ChoNhan_Radio
            // 
            this.ChoNhan_Radio.AutoSize = true;
            this.ChoNhan_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChoNhan_Radio.Location = new System.Drawing.Point(16, 71);
            this.ChoNhan_Radio.Name = "ChoNhan_Radio";
            this.ChoNhan_Radio.Size = new System.Drawing.Size(90, 21);
            this.ChoNhan_Radio.TabIndex = 10;
            this.ChoNhan_Radio.TabStop = true;
            this.ChoNhan_Radio.Text = "Chờ nhận";
            this.ChoNhan_Radio.UseVisualStyleBackColor = true;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Status_Label.Location = new System.Drawing.Point(13, 36);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(73, 17);
            this.Status_Label.TabIndex = 9;
            this.Status_Label.Text = "Tình trạng";
            // 
            // DS_DH_Button
            // 
            this.DS_DH_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DS_DH_Button.Location = new System.Drawing.Point(729, 8);
            this.DS_DH_Button.Name = "DS_DH_Button";
            this.DS_DH_Button.Size = new System.Drawing.Size(103, 49);
            this.DS_DH_Button.TabIndex = 10;
            this.DS_DH_Button.Text = "Danh sách đơn";
            this.DS_DH_Button.UseVisualStyleBackColor = true;
            this.DS_DH_Button.Click += new System.EventHandler(this.DS_DH_Button_Click);
            // 
            // Dirty_Radio
            // 
            this.Dirty_Radio.AutoSize = true;
            this.Dirty_Radio.Location = new System.Drawing.Point(25, 30);
            this.Dirty_Radio.Name = "Dirty_Radio";
            this.Dirty_Radio.Size = new System.Drawing.Size(96, 21);
            this.Dirty_Radio.TabIndex = 11;
            this.Dirty_Radio.TabStop = true;
            this.Dirty_Radio.Text = "Dirty Read";
            this.Dirty_Radio.UseVisualStyleBackColor = true;
            // 
            // LostUp_Radio
            // 
            this.LostUp_Radio.AutoSize = true;
            this.LostUp_Radio.Location = new System.Drawing.Point(139, 30);
            this.LostUp_Radio.Name = "LostUp_Radio";
            this.LostUp_Radio.Size = new System.Drawing.Size(104, 21);
            this.LostUp_Radio.TabIndex = 12;
            this.LostUp_Radio.TabStop = true;
            this.LostUp_Radio.Text = "Lost update";
            this.LostUp_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dirty_Radio);
            this.groupBox1.Controls.Add(this.LostUp_Radio);
            this.groupBox1.Location = new System.Drawing.Point(855, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình huống";
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DS_DH_Button);
            this.Controls.Add(this.update_gb);
            this.Controls.Add(this.DSDHGrid);
            this.Controls.Add(this.DSDH_Label);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(1182, 484);
            ((System.ComponentModel.ISupportInitialize)(this.DSDHGrid)).EndInit();
            this.update_gb.ResumeLayout(false);
            this.update_gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DSDH_Label;
        private System.Windows.Forms.DataGridView DSDHGrid;
        private System.Windows.Forms.Button Update_OrderStat_Button;
        private System.Windows.Forms.GroupBox update_gb;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Button DS_DH_Button;
        private System.Windows.Forms.RadioButton DangCB_Radio;
        private System.Windows.Forms.RadioButton ChoNhan_Radio;
        private System.Windows.Forms.RadioButton Dirty_Radio;
        private System.Windows.Forms.RadioButton LostUp_Radio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
