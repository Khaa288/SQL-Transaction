
namespace Project_DBMS
{
    partial class Login
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
            this.userName = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userName.Location = new System.Drawing.Point(12, 42);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(94, 20);
            this.userName.TabIndex = 0;
            this.userName.Text = "Username";
            this.userName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passWord
            // 
            this.passWord.AutoSize = true;
            this.passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passWord.Location = new System.Drawing.Point(12, 90);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(91, 20);
            this.passWord.TabIndex = 1;
            this.passWord.Text = "Password";
            this.passWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(125, 42);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(271, 22);
            this.usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(125, 90);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(271, 22);
            this.passwordTxt.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(182, 133);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(157, 39);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 211);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label passWord;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginButton;
    }
}

