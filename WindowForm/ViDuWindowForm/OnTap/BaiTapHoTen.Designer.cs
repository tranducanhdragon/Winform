namespace OnTap
{
    partial class BaiTapHoTen
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelTen = new System.Windows.Forms.Label();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.labelHo = new System.Windows.Forms.Label();
            this.textBox_ho = new System.Windows.Forms.TextBox();
            this.button_ho = new System.Windows.Forms.Button();
            this.button_ten = new System.Windows.Forms.Button();
            this.button_hovaten = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.label_full = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_red = new System.Windows.Forms.RadioButton();
            this.rbtn_blue = new System.Windows.Forms.RadioButton();
            this.rbtn_green = new System.Windows.Forms.RadioButton();
            this.rbtn_black = new System.Windows.Forms.RadioButton();
            this.ckb_bold = new System.Windows.Forms.CheckBox();
            this.ckb_italic = new System.Windows.Forms.CheckBox();
            this.ckb_underline = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_full);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(484, 462);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.textBox_ho);
            this.splitContainer2.Panel1.Controls.Add(this.labelHo);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_ten);
            this.splitContainer2.Panel1.Controls.Add(this.labelTen);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.button_thoat);
            this.splitContainer2.Panel2.Controls.Add(this.button_hovaten);
            this.splitContainer2.Panel2.Controls.Add(this.button_ten);
            this.splitContainer2.Panel2.Controls.Add(this.button_ho);
            this.splitContainer2.Size = new System.Drawing.Size(275, 462);
            this.splitContainer2.SplitterDistance = 96;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(3, 55);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(35, 13);
            this.labelTen.TabIndex = 2;
            this.labelTen.Text = "Name";
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(58, 52);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(209, 20);
            this.textBox_ten.TabIndex = 3;
            // 
            // labelHo
            // 
            this.labelHo.AutoSize = true;
            this.labelHo.Location = new System.Drawing.Point(3, 16);
            this.labelHo.Name = "labelHo";
            this.labelHo.Size = new System.Drawing.Size(49, 13);
            this.labelHo.TabIndex = 0;
            this.labelHo.Text = "Surname";
            // 
            // textBox_ho
            // 
            this.textBox_ho.Location = new System.Drawing.Point(58, 13);
            this.textBox_ho.Name = "textBox_ho";
            this.textBox_ho.Size = new System.Drawing.Size(209, 20);
            this.textBox_ho.TabIndex = 1;
            // 
            // button_ho
            // 
            this.button_ho.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ho.Location = new System.Drawing.Point(0, 0);
            this.button_ho.Name = "button_ho";
            this.button_ho.Size = new System.Drawing.Size(275, 23);
            this.button_ho.TabIndex = 0;
            this.button_ho.Text = "Surname";
            this.button_ho.UseVisualStyleBackColor = true;
            this.button_ho.Click += new System.EventHandler(this.button_ho_Click);
            // 
            // button_ten
            // 
            this.button_ten.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ten.Location = new System.Drawing.Point(0, 23);
            this.button_ten.Name = "button_ten";
            this.button_ten.Size = new System.Drawing.Size(275, 23);
            this.button_ten.TabIndex = 1;
            this.button_ten.Text = "Name";
            this.button_ten.UseVisualStyleBackColor = true;
            this.button_ten.Click += new System.EventHandler(this.button_ten_Click);
            // 
            // button_hovaten
            // 
            this.button_hovaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hovaten.Location = new System.Drawing.Point(0, 46);
            this.button_hovaten.Name = "button_hovaten";
            this.button_hovaten.Size = new System.Drawing.Size(275, 23);
            this.button_hovaten.TabIndex = 2;
            this.button_hovaten.Text = "Fullname";
            this.button_hovaten.UseVisualStyleBackColor = true;
            this.button_hovaten.Click += new System.EventHandler(this.button_hovaten_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_thoat.Location = new System.Drawing.Point(192, 323);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(75, 23);
            this.button_thoat.TabIndex = 3;
            this.button_thoat.Text = "Exit";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // label_full
            // 
            this.label_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_full.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_full.Location = new System.Drawing.Point(0, 0);
            this.label_full.Name = "label_full";
            this.label_full.Size = new System.Drawing.Size(199, 462);
            this.label_full.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_black);
            this.groupBox1.Controls.Add(this.rbtn_green);
            this.groupBox1.Controls.Add(this.rbtn_blue);
            this.groupBox1.Controls.Add(this.rbtn_red);
            this.groupBox1.Location = new System.Drawing.Point(6, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_underline);
            this.groupBox2.Controls.Add(this.ckb_italic);
            this.groupBox2.Controls.Add(this.ckb_bold);
            this.groupBox2.Location = new System.Drawing.Point(6, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbtn_red
            // 
            this.rbtn_red.AutoSize = true;
            this.rbtn_red.ForeColor = System.Drawing.Color.Red;
            this.rbtn_red.Location = new System.Drawing.Point(23, 30);
            this.rbtn_red.Name = "rbtn_red";
            this.rbtn_red.Size = new System.Drawing.Size(45, 17);
            this.rbtn_red.TabIndex = 0;
            this.rbtn_red.TabStop = true;
            this.rbtn_red.Text = "Red";
            this.rbtn_red.UseVisualStyleBackColor = true;
            this.rbtn_red.CheckedChanged += new System.EventHandler(this.rbtn_red_CheckedChanged);
            // 
            // rbtn_blue
            // 
            this.rbtn_blue.AutoSize = true;
            this.rbtn_blue.ForeColor = System.Drawing.Color.Blue;
            this.rbtn_blue.Location = new System.Drawing.Point(23, 63);
            this.rbtn_blue.Name = "rbtn_blue";
            this.rbtn_blue.Size = new System.Drawing.Size(46, 17);
            this.rbtn_blue.TabIndex = 0;
            this.rbtn_blue.TabStop = true;
            this.rbtn_blue.Text = "Blue";
            this.rbtn_blue.UseVisualStyleBackColor = true;
            this.rbtn_blue.CheckedChanged += new System.EventHandler(this.rbtn_blue_CheckedChanged);
            // 
            // rbtn_green
            // 
            this.rbtn_green.AutoSize = true;
            this.rbtn_green.ForeColor = System.Drawing.Color.Green;
            this.rbtn_green.Location = new System.Drawing.Point(146, 30);
            this.rbtn_green.Name = "rbtn_green";
            this.rbtn_green.Size = new System.Drawing.Size(54, 17);
            this.rbtn_green.TabIndex = 0;
            this.rbtn_green.TabStop = true;
            this.rbtn_green.Text = "Green";
            this.rbtn_green.UseVisualStyleBackColor = true;
            this.rbtn_green.CheckedChanged += new System.EventHandler(this.rbtn_green_CheckedChanged);
            // 
            // rbtn_black
            // 
            this.rbtn_black.AutoSize = true;
            this.rbtn_black.Location = new System.Drawing.Point(146, 63);
            this.rbtn_black.Name = "rbtn_black";
            this.rbtn_black.Size = new System.Drawing.Size(52, 17);
            this.rbtn_black.TabIndex = 0;
            this.rbtn_black.TabStop = true;
            this.rbtn_black.Text = "Black";
            this.rbtn_black.UseVisualStyleBackColor = true;
            this.rbtn_black.CheckedChanged += new System.EventHandler(this.rbtn_black_CheckedChanged);
            // 
            // ckb_bold
            // 
            this.ckb_bold.AutoSize = true;
            this.ckb_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_bold.Location = new System.Drawing.Point(23, 30);
            this.ckb_bold.Name = "ckb_bold";
            this.ckb_bold.Size = new System.Drawing.Size(51, 17);
            this.ckb_bold.TabIndex = 0;
            this.ckb_bold.Text = "Bold";
            this.ckb_bold.UseVisualStyleBackColor = true;
            this.ckb_bold.CheckedChanged += new System.EventHandler(this.ckb_bold_CheckedChanged);
            // 
            // ckb_italic
            // 
            this.ckb_italic.AutoSize = true;
            this.ckb_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_italic.Location = new System.Drawing.Point(151, 30);
            this.ckb_italic.Name = "ckb_italic";
            this.ckb_italic.Size = new System.Drawing.Size(48, 17);
            this.ckb_italic.TabIndex = 0;
            this.ckb_italic.Text = "Italic";
            this.ckb_italic.UseVisualStyleBackColor = true;
            this.ckb_italic.CheckedChanged += new System.EventHandler(this.ckb_italic_CheckedChanged);
            // 
            // ckb_underline
            // 
            this.ckb_underline.AutoSize = true;
            this.ckb_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_underline.Location = new System.Drawing.Point(23, 72);
            this.ckb_underline.Name = "ckb_underline";
            this.ckb_underline.Size = new System.Drawing.Size(71, 17);
            this.ckb_underline.TabIndex = 0;
            this.ckb_underline.Text = "Underline";
            this.ckb_underline.UseVisualStyleBackColor = true;
            this.ckb_underline.CheckedChanged += new System.EventHandler(this.ckb_underline_CheckedChanged);
            // 
            // BaiTapHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_thoat;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BaiTapHoTen";
            this.Text = "BaiTapHoTen";
            this.Load += new System.EventHandler(this.BaiTapHoTen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox textBox_ho;
        private System.Windows.Forms.Label labelHo;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_hovaten;
        private System.Windows.Forms.Button button_ten;
        private System.Windows.Forms.Button button_ho;
        private System.Windows.Forms.Label label_full;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckb_underline;
        private System.Windows.Forms.CheckBox ckb_italic;
        private System.Windows.Forms.CheckBox ckb_bold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_black;
        private System.Windows.Forms.RadioButton rbtn_green;
        private System.Windows.Forms.RadioButton rbtn_blue;
        private System.Windows.Forms.RadioButton rbtn_red;
    }
}