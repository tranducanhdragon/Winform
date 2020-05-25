namespace Calculator
{
    partial class Calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBang = new System.Windows.Forms.Button();
            this.buttonChia = new System.Windows.Forms.Button();
            this.buttonNhan = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonPhay = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCong = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonTru = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(259, 24);
            this.textBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.buttonBang);
            this.panel1.Controls.Add(this.buttonChia);
            this.panel1.Controls.Add(this.buttonNhan);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonDelete1);
            this.panel1.Controls.Add(this.buttonPhay);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonCong);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.buttonTru);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 182);
            this.panel1.TabIndex = 1;
            // 
            // buttonBang
            // 
            this.buttonBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBang.Location = new System.Drawing.Point(194, 143);
            this.buttonBang.Name = "buttonBang";
            this.buttonBang.Size = new System.Drawing.Size(51, 23);
            this.buttonBang.TabIndex = 0;
            this.buttonBang.Text = "=";
            this.buttonBang.UseVisualStyleBackColor = true;
            this.buttonBang.Click += new System.EventHandler(this.ButtonResult);
            // 
            // buttonChia
            // 
            this.buttonChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChia.Location = new System.Drawing.Point(194, 105);
            this.buttonChia.Name = "buttonChia";
            this.buttonChia.Size = new System.Drawing.Size(51, 23);
            this.buttonChia.TabIndex = 0;
            this.buttonChia.Text = "/";
            this.buttonChia.UseVisualStyleBackColor = true;
            this.buttonChia.Click += new System.EventHandler(this.ButtonOperator);
            // 
            // buttonNhan
            // 
            this.buttonNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhan.Location = new System.Drawing.Point(194, 76);
            this.buttonNhan.Name = "buttonNhan";
            this.buttonNhan.Size = new System.Drawing.Size(51, 23);
            this.buttonNhan.TabIndex = 0;
            this.buttonNhan.Text = "*";
            this.buttonNhan.UseVisualStyleBackColor = true;
            this.buttonNhan.Click += new System.EventHandler(this.ButtonOperator);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(125, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(68, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(68, 105);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(51, 23);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(11, 143);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(51, 23);
            this.buttonDelete1.TabIndex = 0;
            this.buttonDelete1.Text = "<-";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // buttonPhay
            // 
            this.buttonPhay.Location = new System.Drawing.Point(125, 143);
            this.buttonPhay.Name = "buttonPhay";
            this.buttonPhay.Size = new System.Drawing.Size(51, 23);
            this.buttonPhay.TabIndex = 0;
            this.buttonPhay.Text = ".";
            this.buttonPhay.UseVisualStyleBackColor = true;
            this.buttonPhay.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(68, 143);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(51, 23);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCong
            // 
            this.buttonCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCong.Location = new System.Drawing.Point(194, 18);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(51, 23);
            this.buttonCong.TabIndex = 0;
            this.buttonCong.Text = "+";
            this.buttonCong.UseVisualStyleBackColor = true;
            this.buttonCong.Click += new System.EventHandler(this.ButtonOperator);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonTru
            // 
            this.buttonTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTru.Location = new System.Drawing.Point(194, 47);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(51, 23);
            this.buttonTru.TabIndex = 0;
            this.buttonTru.Text = "-";
            this.buttonTru.UseVisualStyleBackColor = true;
            this.buttonTru.Click += new System.EventHandler(this.ButtonOperator);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(125, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // labelKetQua
            // 
            this.labelKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKetQua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKetQua.Location = new System.Drawing.Point(13, 40);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(259, 25);
            this.labelKetQua.TabIndex = 2;
            this.labelKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBang;
        private System.Windows.Forms.Button buttonChia;
        private System.Windows.Forms.Button buttonNhan;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonTru;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPhay;
    }
}

