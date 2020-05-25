namespace DangKy
{
    partial class Form1
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
            this.label_DangKy = new System.Windows.Forms.Label();
            this.labelHoten = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.textBoxHoten = new System.Windows.Forms.TextBox();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.textBoxDiachi = new System.Windows.Forms.TextBox();
            this.buttonHoantat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DangKy
            // 
            this.label_DangKy.AutoSize = true;
            this.label_DangKy.Location = new System.Drawing.Point(115, 9);
            this.label_DangKy.Name = "label_DangKy";
            this.label_DangKy.Size = new System.Drawing.Size(48, 13);
            this.label_DangKy.TabIndex = 0;
            this.label_DangKy.Text = "Dang Ky";
            // 
            // labelHoten
            // 
            this.labelHoten.AutoSize = true;
            this.labelHoten.Location = new System.Drawing.Point(13, 51);
            this.labelHoten.Name = "labelHoten";
            this.labelHoten.Size = new System.Drawing.Size(54, 13);
            this.labelHoten.TabIndex = 1;
            this.labelHoten.Text = "Ho va ten";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Location = new System.Drawing.Point(12, 78);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(25, 13);
            this.labelLop.TabIndex = 2;
            this.labelLop.Text = "Lop";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(13, 105);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(40, 13);
            this.labelDiaChi.TabIndex = 3;
            this.labelDiaChi.Text = "Dia chi";
            // 
            // textBoxHoten
            // 
            this.textBoxHoten.Location = new System.Drawing.Point(88, 48);
            this.textBoxHoten.Name = "textBoxHoten";
            this.textBoxHoten.Size = new System.Drawing.Size(184, 20);
            this.textBoxHoten.TabIndex = 1;
            // 
            // textBoxLop
            // 
            this.textBoxLop.Location = new System.Drawing.Point(88, 75);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(184, 20);
            this.textBoxLop.TabIndex = 2;
            // 
            // textBoxDiachi
            // 
            this.textBoxDiachi.Location = new System.Drawing.Point(88, 102);
            this.textBoxDiachi.Name = "textBoxDiachi";
            this.textBoxDiachi.Size = new System.Drawing.Size(184, 20);
            this.textBoxDiachi.TabIndex = 3;
            // 
            // buttonHoantat
            // 
            this.buttonHoantat.Location = new System.Drawing.Point(104, 166);
            this.buttonHoantat.Name = "buttonHoantat";
            this.buttonHoantat.Size = new System.Drawing.Size(75, 23);
            this.buttonHoantat.TabIndex = 4;
            this.buttonHoantat.Text = "Hoan tat";
            this.buttonHoantat.UseVisualStyleBackColor = true;
            this.buttonHoantat.Click += new System.EventHandler(this.buttonHoantat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonHoantat);
            this.Controls.Add(this.textBoxDiachi);
            this.Controls.Add(this.textBoxLop);
            this.Controls.Add(this.textBoxHoten);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelLop);
            this.Controls.Add(this.labelHoten);
            this.Controls.Add(this.label_DangKy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DangKy;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox textBoxHoten;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.TextBox textBoxDiachi;
        private System.Windows.Forms.Button buttonHoantat;
    }
}

