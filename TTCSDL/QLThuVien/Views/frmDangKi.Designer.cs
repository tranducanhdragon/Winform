﻿namespace QLThuVien.Views
{
    partial class frmDangKi
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
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhapLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Appearance.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Appearance.Options.UseFont = true;
            this.btCancel.AutoSize = true;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btCancel.Location = new System.Drawing.Point(319, 312);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(71, 33);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Appearance.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Appearance.Options.UseFont = true;
            this.btOk.AutoSize = true;
            this.btOk.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btOk.Location = new System.Drawing.Point(190, 312);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(80, 33);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Đăng kí";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbNhapLai);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tbMatKhau);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tbTaiKhoan);
            this.groupControl1.Location = new System.Drawing.Point(81, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(417, 247);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Chi tiết tài khoản";
            // 
            // tbNhapLai
            // 
            this.tbNhapLai.Location = new System.Drawing.Point(209, 160);
            this.tbNhapLai.Name = "tbNhapLai";
            this.tbNhapLai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapLai.Properties.Appearance.Options.UseFont = true;
            this.tbNhapLai.Properties.PasswordChar = '*';
            this.tbNhapLai.Size = new System.Drawing.Size(178, 28);
            this.tbNhapLai.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 23);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Nhập lại mật khẩu : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 23);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tài khoản : ";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(209, 101);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Properties.Appearance.Options.UseFont = true;
            this.tbMatKhau.Properties.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(178, 28);
            this.tbMatKhau.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(62, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 23);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu : ";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(209, 48);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.tbTaiKhoan.Size = new System.Drawing.Size(178, 28);
            this.tbTaiKhoan.TabIndex = 1;
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 387);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÍ TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhapLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbTaiKhoan;
        private DevExpress.XtraEditors.TextEdit tbNhapLai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}