namespace OnTap
{
    partial class Form_loginfacebook
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_save = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.SteelBlue;
            this.label_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_username.Location = new System.Drawing.Point(14, 63);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(55, 13);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.BackColor = System.Drawing.Color.SteelBlue;
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_password.Location = new System.Drawing.Point(16, 95);
            this.label_password.Name = "label_password";
            this.label_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_username.Location = new System.Drawing.Point(89, 60);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_username.Size = new System.Drawing.Size(183, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(89, 92);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_password.Size = new System.Drawing.Size(183, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_login.Location = new System.Drawing.Point(89, 227);
            this.button_login.Name = "button_login";
            this.button_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(197, 227);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Facebook";
            // 
            // checkBox_save
            // 
            this.checkBox_save.AutoSize = true;
            this.checkBox_save.Location = new System.Drawing.Point(89, 132);
            this.checkBox_save.Name = "checkBox_save";
            this.checkBox_save.Size = new System.Drawing.Size(122, 17);
            this.checkBox_save.TabIndex = 5;
            this.checkBox_save.Text = "Save your password";
            this.checkBox_save.UseVisualStyleBackColor = true;
            // 
            // Form_loginfacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.DoubleBuffered = true;
            this.Name = "Form_loginfacebook";
            this.Text = "Login to facebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_save;
    }
}

