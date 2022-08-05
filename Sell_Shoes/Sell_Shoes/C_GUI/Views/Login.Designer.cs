namespace Sell_Shoes.Views
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
            this.btt_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_MatKhau = new System.Windows.Forms.TextBox();
            this.tbt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_Login
            // 
            this.btt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btt_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btt_Login.Location = new System.Drawing.Point(174, 201);
            this.btt_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(124, 42);
            this.btt_Login.TabIndex = 3;
            this.btt_Login.Text = "Đăng nhập";
            this.btt_Login.UseVisualStyleBackColor = false;
            this.btt_Login.UseWaitCursor = true;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu";
            this.label2.UseWaitCursor = true;
            // 
            // tbt_MatKhau
            // 
            this.tbt_MatKhau.Location = new System.Drawing.Point(237, 122);
            this.tbt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_MatKhau.Name = "tbt_MatKhau";
            this.tbt_MatKhau.Size = new System.Drawing.Size(197, 27);
            this.tbt_MatKhau.TabIndex = 2;
            this.tbt_MatKhau.UseSystemPasswordChar = true;
            this.tbt_MatKhau.UseWaitCursor = true;
            // 
            // tbt_TenDangNhap
            // 
            this.tbt_TenDangNhap.Location = new System.Drawing.Point(237, 58);
            this.tbt_TenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbt_TenDangNhap.Name = "tbt_TenDangNhap";
            this.tbt_TenDangNhap.Size = new System.Drawing.Size(197, 27);
            this.tbt_TenDangNhap.TabIndex = 1;
            this.tbt_TenDangNhap.UseWaitCursor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(396, 268);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 29);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.UseWaitCursor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên đăng nhập";
            this.label1.UseWaitCursor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btt_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbt_MatKhau);
            this.Controls.Add(this.tbt_TenDangNhap);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btt_Login;
        private Label label2;
        private TextBox tbt_MatKhau;
        private TextBox tbt_TenDangNhap;

        private Button btn_Thoat;
        private Label label1;
    }
}