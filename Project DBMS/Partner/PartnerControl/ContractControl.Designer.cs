
namespace Project_DBMS.Partner.PartnerControl
{
    partial class ContractControl
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
            this.DSHDGrid = new System.Windows.Forms.DataGridView();
            this.selectCT_Label = new System.Windows.Forms.Label();
            this.HD_cbb = new System.Windows.Forms.ComboBox();
            this.Xem_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSHDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DSDH_Label
            // 
            this.DSDH_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DSDH_Label.AutoSize = true;
            this.DSDH_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSDH_Label.Location = new System.Drawing.Point(15, 14);
            this.DSDH_Label.Name = "DSDH_Label";
            this.DSDH_Label.Size = new System.Drawing.Size(146, 32);
            this.DSDH_Label.TabIndex = 3;
            this.DSDH_Label.Text = "Hợp đồng";
            // 
            // DSHDGrid
            // 
            this.DSHDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSHDGrid.Location = new System.Drawing.Point(21, 82);
            this.DSHDGrid.Name = "DSHDGrid";
            this.DSHDGrid.RowHeadersWidth = 51;
            this.DSHDGrid.RowTemplate.Height = 24;
            this.DSHDGrid.Size = new System.Drawing.Size(1138, 383);
            this.DSHDGrid.TabIndex = 4;
            // 
            // selectCT_Label
            // 
            this.selectCT_Label.AutoSize = true;
            this.selectCT_Label.Location = new System.Drawing.Point(896, 27);
            this.selectCT_Label.Name = "selectCT_Label";
            this.selectCT_Label.Size = new System.Drawing.Size(64, 17);
            this.selectCT_Label.TabIndex = 6;
            this.selectCT_Label.Text = "Tìm kiếm";
            // 
            // HD_cbb
            // 
            this.HD_cbb.FormattingEnabled = true;
            this.HD_cbb.Location = new System.Drawing.Point(966, 24);
            this.HD_cbb.Name = "HD_cbb";
            this.HD_cbb.Size = new System.Drawing.Size(121, 24);
            this.HD_cbb.TabIndex = 7;
            // 
            // Xem_Button
            // 
            this.Xem_Button.Location = new System.Drawing.Point(1093, 24);
            this.Xem_Button.Name = "Xem_Button";
            this.Xem_Button.Size = new System.Drawing.Size(75, 23);
            this.Xem_Button.TabIndex = 8;
            this.Xem_Button.Text = "Xem";
            this.Xem_Button.UseVisualStyleBackColor = true;
            this.Xem_Button.Click += new System.EventHandler(this.Xem_Button_Click);
            // 
            // ContractControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Xem_Button);
            this.Controls.Add(this.HD_cbb);
            this.Controls.Add(this.selectCT_Label);
            this.Controls.Add(this.DSHDGrid);
            this.Controls.Add(this.DSDH_Label);
            this.Name = "ContractControl";
            this.Size = new System.Drawing.Size(1182, 484);
            this.Load += new System.EventHandler(this.ContractControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSHDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DSDH_Label;
        private System.Windows.Forms.DataGridView DSHDGrid;
        private System.Windows.Forms.Label selectCT_Label;
        private System.Windows.Forms.ComboBox HD_cbb;
        private System.Windows.Forms.Button Xem_Button;
    }
}
