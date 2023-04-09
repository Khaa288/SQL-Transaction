
namespace Project_DBMS
{
    partial class BugAndFix_Version
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
            this.BugVer_Button = new System.Windows.Forms.Button();
            this.FixVer_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BugVer_Button
            // 
            this.BugVer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BugVer_Button.Location = new System.Drawing.Point(30, 12);
            this.BugVer_Button.Name = "BugVer_Button";
            this.BugVer_Button.Size = new System.Drawing.Size(350, 408);
            this.BugVer_Button.TabIndex = 0;
            this.BugVer_Button.Text = "Phiên bản lỗi";
            this.BugVer_Button.UseVisualStyleBackColor = true;
            this.BugVer_Button.Click += new System.EventHandler(this.BugVer_Button_Click);
            // 
            // FixVer_Button
            // 
            this.FixVer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FixVer_Button.Location = new System.Drawing.Point(419, 12);
            this.FixVer_Button.Name = "FixVer_Button";
            this.FixVer_Button.Size = new System.Drawing.Size(350, 408);
            this.FixVer_Button.TabIndex = 1;
            this.FixVer_Button.Text = "Sửa lỗi";
            this.FixVer_Button.UseVisualStyleBackColor = true;
            this.FixVer_Button.Click += new System.EventHandler(this.FixVer_Button_Click);
            // 
            // BugAndFix_Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FixVer_Button);
            this.Controls.Add(this.BugVer_Button);
            this.Name = "BugAndFix_Version";
            this.Text = "BugAndFix_Version";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BugVer_Button;
        private System.Windows.Forms.Button FixVer_Button;
    }
}