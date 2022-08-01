namespace Sell_Shoes.Views
{
    partial class DoanhThu
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_DoanhThu = new System.Windows.Forms.Button();
            this.dtg_ShowDT = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(569, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 27);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // btn_DoanhThu
            // 
            this.btn_DoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DoanhThu.Location = new System.Drawing.Point(345, 460);
            this.btn_DoanhThu.Name = "btn_DoanhThu";
            this.btn_DoanhThu.Size = new System.Drawing.Size(184, 37);
            this.btn_DoanhThu.TabIndex = 4;
            this.btn_DoanhThu.Text = "Doanh Thu";
            this.btn_DoanhThu.UseVisualStyleBackColor = true;
            this.btn_DoanhThu.Click += new System.EventHandler(this.btn_DoanhThu_Click);
            // 
            // dtg_ShowDT
            // 
            this.dtg_ShowDT.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtg_ShowDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowDT.Location = new System.Drawing.Point(45, 86);
            this.dtg_ShowDT.Name = "dtg_ShowDT";
            this.dtg_ShowDT.RowHeadersWidth = 51;
            this.dtg_ShowDT.RowTemplate.Height = 29;
            this.dtg_ShowDT.Size = new System.Drawing.Size(756, 336);
            this.dtg_ShowDT.TabIndex = 5;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(783, 515);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(121, 48);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 584);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dtg_ShowDT);
            this.Controls.Add(this.btn_DoanhThu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btn_DoanhThu;
        private DataGridView dtg_ShowDT;
        private Button btn_Thoat;
    }
}