namespace BaiKiemTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxChonPhim = new System.Windows.Forms.ComboBox();
            this.comBoxThoiGian = new System.Windows.Forms.ComboBox();
            this.comBoxPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTenKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CGV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chon phim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thoi Gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phong:";
            // 
            // comBoxChonPhim
            // 
            this.comBoxChonPhim.FormattingEnabled = true;
            this.comBoxChonPhim.Items.AddRange(new object[] {
            "Iron man",
            "Anh thay ngoi sao",
            "Gone with the wind"});
            this.comBoxChonPhim.Location = new System.Drawing.Point(136, 55);
            this.comBoxChonPhim.Name = "comBoxChonPhim";
            this.comBoxChonPhim.Size = new System.Drawing.Size(243, 24);
            this.comBoxChonPhim.TabIndex = 4;
            this.comBoxChonPhim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comBoxThoiGian
            // 
            this.comBoxThoiGian.FormattingEnabled = true;
            this.comBoxThoiGian.Location = new System.Drawing.Point(136, 102);
            this.comBoxThoiGian.Name = "comBoxThoiGian";
            this.comBoxThoiGian.Size = new System.Drawing.Size(243, 24);
            this.comBoxThoiGian.TabIndex = 5;
            // 
            // comBoxPhong
            // 
            this.comBoxPhong.FormattingEnabled = true;
            this.comBoxPhong.Location = new System.Drawing.Point(136, 154);
            this.comBoxPhong.Name = "comBoxPhong";
            this.comBoxPhong.Size = new System.Drawing.Size(243, 24);
            this.comBoxPhong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gia ve: 70000 vnđ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ten khach hang:";
            // 
            // txbTenKhach
            // 
            this.txbTenKhach.Location = new System.Drawing.Point(147, 214);
            this.txbTenKhach.Name = "txbTenKhach";
            this.txbTenKhach.Size = new System.Drawing.Size(243, 22);
            this.txbTenKhach.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "SDT";
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(488, 212);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(100, 22);
            this.txbSDT.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dat ve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbTenKhach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxPhong);
            this.Controls.Add(this.comBoxThoiGian);
            this.Controls.Add(this.comBoxChonPhim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxChonPhim;
        private System.Windows.Forms.ComboBox comBoxThoiGian;
        private System.Windows.Forms.ComboBox comBoxPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTenKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Button button1;
    }
}

