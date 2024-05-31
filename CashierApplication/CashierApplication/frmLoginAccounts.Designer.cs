namespace CashierApplication
{
    partial class frmLoginAccounts
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
            this.usernamee = new System.Windows.Forms.Label();
            this.passwordd = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.Logins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamee
            // 
            this.usernamee.AutoSize = true;
            this.usernamee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamee.Location = new System.Drawing.Point(12, 40);
            this.usernamee.Name = "usernamee";
            this.usernamee.Size = new System.Drawing.Size(83, 20);
            this.usernamee.TabIndex = 0;
            this.usernamee.Text = "Username";
            // 
            // passwordd
            // 
            this.passwordd.AutoSize = true;
            this.passwordd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordd.Location = new System.Drawing.Point(12, 132);
            this.passwordd.Name = "passwordd";
            this.passwordd.Size = new System.Drawing.Size(78, 20);
            this.passwordd.TabIndex = 1;
            this.passwordd.Text = "Password";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(12, 63);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(229, 26);
            this.userName.TabIndex = 2;
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(12, 155);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(229, 26);
            this.passWord.TabIndex = 3;
            // 
            // Logins
            // 
            this.Logins.BackColor = System.Drawing.Color.IndianRed;
            this.Logins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logins.Location = new System.Drawing.Point(12, 214);
            this.Logins.Name = "Logins";
            this.Logins.Size = new System.Drawing.Size(229, 50);
            this.Logins.TabIndex = 4;
            this.Logins.Text = "Login";
            this.Logins.UseVisualStyleBackColor = false;
            this.Logins.Click += new System.EventHandler(this.Logins_Click);
            // 
            // frmLoginAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(261, 317);
            this.Controls.Add(this.Logins);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passwordd);
            this.Controls.Add(this.usernamee);
            this.Name = "frmLoginAccounts";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamee;
        private System.Windows.Forms.Label passwordd;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button Logins;
    }
}