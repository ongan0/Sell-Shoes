﻿namespace Sell_Shoes.Views
{
    partial class TongHopCN_NV
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
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Hoadon = new System.Windows.Forms.Button();
            this.btn_Doanhthu = new System.Windows.Forms.Button();
            this.btn_Support = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Order.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Order.Location = new System.Drawing.Point(86, 133);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(121, 48);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Hoadon
            // 
            this.btn_Hoadon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Hoadon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Hoadon.Location = new System.Drawing.Point(327, 133);
            this.btn_Hoadon.Name = "btn_Hoadon";
            this.btn_Hoadon.Size = new System.Drawing.Size(121, 48);
            this.btn_Hoadon.TabIndex = 2;
            this.btn_Hoadon.Text = "Hóa đơn";
            this.btn_Hoadon.UseVisualStyleBackColor = false;
            this.btn_Hoadon.Click += new System.EventHandler(this.btn_Hoadon_Click);
            // 
            // btn_Doanhthu
            // 
            this.btn_Doanhthu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Doanhthu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Doanhthu.Location = new System.Drawing.Point(570, 133);
            this.btn_Doanhthu.Name = "btn_Doanhthu";
            this.btn_Doanhthu.Size = new System.Drawing.Size(121, 48);
            this.btn_Doanhthu.TabIndex = 3;
            this.btn_Doanhthu.Text = "Doanh thu";
            this.btn_Doanhthu.UseVisualStyleBackColor = false;
            this.btn_Doanhthu.Click += new System.EventHandler(this.btn_Doanhthu_Click);
            // 
            // btn_Support
            // 
            this.btn_Support.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Support.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Support.Location = new System.Drawing.Point(206, 255);
            this.btn_Support.Name = "btn_Support";
            this.btn_Support.Size = new System.Drawing.Size(121, 48);
            this.btn_Support.TabIndex = 5;
            this.btn_Support.Text = "Support";
            this.btn_Support.UseVisualStyleBackColor = false;
            this.btn_Support.Click += new System.EventHandler(this.btn_Support_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.Location = new System.Drawing.Point(432, 255);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(121, 48);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // TongHopCN_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(787, 440);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Support);
            this.Controls.Add(this.btn_Doanhthu);
            this.Controls.Add(this.btn_Hoadon);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.label1);
            this.Name = "TongHopCN_NV";
            this.Text = "TongHopCN_NV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Order;
        private Button btn_Hoadon;
        private Button btn_Doanhthu;
        private Button btn_Support;
        private Button btn_Logout;
    }
}