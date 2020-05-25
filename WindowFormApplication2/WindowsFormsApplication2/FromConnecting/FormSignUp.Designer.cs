namespace FromConnecting
{
    partial class FormSignUp
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSMS = new System.Windows.Forms.CheckBox();
            this.checkBoxReport = new System.Windows.Forms.CheckBox();
            this.checkBoxTransaction = new System.Windows.Forms.CheckBox();
            this.labelSMS = new System.Windows.Forms.Label();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelReport = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(91, 21);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(304, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(91, 65);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(304, 20);
            this.textBoxLastName.TabIndex = 0;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(91, 110);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(304, 20);
            this.textBoxEmailAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSignUp);
            this.groupBox1.Controls.Add(this.labelTransaction);
            this.groupBox1.Controls.Add(this.labelReport);
            this.groupBox1.Controls.Add(this.labelSMS);
            this.groupBox1.Controls.Add(this.checkBoxTransaction);
            this.groupBox1.Controls.Add(this.checkBoxReport);
            this.groupBox1.Controls.Add(this.checkBoxSMS);
            this.groupBox1.Location = new System.Drawing.Point(16, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // checkBoxSMS
            // 
            this.checkBoxSMS.AutoSize = true;
            this.checkBoxSMS.Location = new System.Drawing.Point(15, 19);
            this.checkBoxSMS.Name = "checkBoxSMS";
            this.checkBoxSMS.Size = new System.Drawing.Size(110, 17);
            this.checkBoxSMS.TabIndex = 0;
            this.checkBoxSMS.Text = "SMS Notifications";
            this.checkBoxSMS.UseVisualStyleBackColor = true;
            this.checkBoxSMS.CheckedChanged += new System.EventHandler(this.checkBoxSMS_CheckedChanged);
            // 
            // checkBoxReport
            // 
            this.checkBoxReport.AutoSize = true;
            this.checkBoxReport.Location = new System.Drawing.Point(15, 42);
            this.checkBoxReport.Name = "checkBoxReport";
            this.checkBoxReport.Size = new System.Drawing.Size(63, 17);
            this.checkBoxReport.TabIndex = 0;
            this.checkBoxReport.Text = "Reports";
            this.checkBoxReport.UseVisualStyleBackColor = true;
            this.checkBoxReport.CheckedChanged += new System.EventHandler(this.checkBoxReport_CheckedChanged);
            // 
            // checkBoxTransaction
            // 
            this.checkBoxTransaction.AutoSize = true;
            this.checkBoxTransaction.Location = new System.Drawing.Point(15, 65);
            this.checkBoxTransaction.Name = "checkBoxTransaction";
            this.checkBoxTransaction.Size = new System.Drawing.Size(117, 17);
            this.checkBoxTransaction.TabIndex = 0;
            this.checkBoxTransaction.Text = "Transaction Report";
            this.checkBoxTransaction.UseVisualStyleBackColor = true;
            this.checkBoxTransaction.CheckedChanged += new System.EventHandler(this.checkBoxTransaction_CheckedChanged);
            // 
            // labelSMS
            // 
            this.labelSMS.AutoSize = true;
            this.labelSMS.ForeColor = System.Drawing.Color.Chocolate;
            this.labelSMS.Location = new System.Drawing.Point(140, 20);
            this.labelSMS.Name = "labelSMS";
            this.labelSMS.Size = new System.Drawing.Size(19, 13);
            this.labelSMS.TabIndex = 1;
            this.labelSMS.Text = "....";
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Location = new System.Drawing.Point(140, 66);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(19, 13);
            this.labelTransaction.TabIndex = 1;
            this.labelTransaction.Text = "....";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(299, 71);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 2;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.ForeColor = System.Drawing.Color.Chocolate;
            this.labelReport.Location = new System.Drawing.Point(140, 43);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(19, 13);
            this.labelReport.TabIndex = 1;
            this.labelReport.Text = "....";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.MaximizeBox = false;
            this.Name = "FormSignUp";
            this.Text = "Sign Up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.Label labelSMS;
        private System.Windows.Forms.CheckBox checkBoxTransaction;
        private System.Windows.Forms.CheckBox checkBoxReport;
        private System.Windows.Forms.CheckBox checkBoxSMS;
        private System.Windows.Forms.Label labelReport;
    }
}

