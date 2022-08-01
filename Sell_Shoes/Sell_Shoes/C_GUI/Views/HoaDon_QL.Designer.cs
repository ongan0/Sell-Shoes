namespace Sell_Shoes.Views
{
    partial class HoaDon_QL
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
            this.dtp_DateStop = new System.Windows.Forms.DateTimePicker();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Hienthi = new System.Windows.Forms.Button();
            this.dtp_DateStart = new System.Windows.Forms.DateTimePicker();
            this.dtg_ShowHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_Delete = new System.Windows.Forms.Button();
            this.tbt_Id = new System.Windows.Forms.TextBox();
            this.dtg_ShowCT = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowCT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_DateStop
            // 
            this.dtp_DateStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateStop.Location = new System.Drawing.Point(348, 47);
            this.dtp_DateStop.Name = "dtp_DateStop";
            this.dtp_DateStop.Size = new System.Drawing.Size(126, 27);
            this.dtp_DateStop.TabIndex = 17;
            this.dtp_DateStop.ValueChanged += new System.EventHandler(this.dtp_DateStop_ValueChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(657, 551);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(121, 48);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Hienthi
            // 
            this.btn_Hienthi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Hienthi.Location = new System.Drawing.Point(26, 31);
            this.btn_Hienthi.Name = "btn_Hienthi";
            this.btn_Hienthi.Size = new System.Drawing.Size(122, 43);
            this.btn_Hienthi.TabIndex = 14;
            this.btn_Hienthi.Text = "Hiển thị";
            this.btn_Hienthi.UseVisualStyleBackColor = true;
            this.btn_Hienthi.Click += new System.EventHandler(this.btn_Hienthi_Click);
            // 
            // dtp_DateStart
            // 
            this.dtp_DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateStart.Location = new System.Drawing.Point(167, 47);
            this.dtp_DateStart.Name = "dtp_DateStart";
            this.dtp_DateStart.Size = new System.Drawing.Size(126, 27);
            this.dtp_DateStart.TabIndex = 12;
            this.dtp_DateStart.ValueChanged += new System.EventHandler(this.dtp_DateStart_ValueChanged);
            // 
            // dtg_ShowHD
            // 
            this.dtg_ShowHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ShowHD.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_ShowHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowHD.Location = new System.Drawing.Point(12, 93);
            this.dtg_ShowHD.Name = "dtg_ShowHD";
            this.dtg_ShowHD.RowHeadersWidth = 51;
            this.dtg_ShowHD.RowTemplate.Height = 29;
            this.dtg_ShowHD.Size = new System.Drawing.Size(462, 389);
            this.dtg_ShowHD.TabIndex = 11;
            this.dtg_ShowHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowHD_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(594, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã";
            // 
            // btt_Delete
            // 
            this.btt_Delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btt_Delete.Location = new System.Drawing.Point(990, 373);
            this.btt_Delete.Name = "btt_Delete";
            this.btt_Delete.Size = new System.Drawing.Size(158, 47);
            this.btt_Delete.TabIndex = 21;
            this.btt_Delete.Text = "Xóa hóa đơn";
            this.btt_Delete.UseVisualStyleBackColor = true;
            this.btt_Delete.Click += new System.EventHandler(this.btt_Delete_Click);
            // 
            // tbt_Id
            // 
            this.tbt_Id.Location = new System.Drawing.Point(706, 393);
            this.tbt_Id.Name = "tbt_Id";
            this.tbt_Id.Size = new System.Drawing.Size(168, 27);
            this.tbt_Id.TabIndex = 22;
            // 
            // dtg_ShowCT
            // 
            this.dtg_ShowCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowCT.Location = new System.Drawing.Point(594, 93);
            this.dtg_ShowCT.Name = "dtg_ShowCT";
            this.dtg_ShowCT.RowHeadersWidth = 51;
            this.dtg_ShowCT.RowTemplate.Height = 29;
            this.dtg_ShowCT.Size = new System.Drawing.Size(554, 219);
            this.dtg_ShowCT.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chi tiết hóa đơn";
            // 
            // btt_out
            // 
            this.btt_out.Location = new System.Drawing.Point(1054, 453);
            this.btt_out.Name = "btt_out";
            this.btt_out.Size = new System.Drawing.Size(94, 29);
            this.btt_out.TabIndex = 27;
            this.btt_out.Text = "Thoát";
            this.btt_out.UseVisualStyleBackColor = true;
            this.btt_out.Click += new System.EventHandler(this.btt_out_Click);
            // 
            // HoaDon_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1188, 525);
            this.Controls.Add(this.btt_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_ShowCT);
            this.Controls.Add(this.tbt_Id);
            this.Controls.Add(this.btt_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_DateStop);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Hienthi);
            this.Controls.Add(this.dtp_DateStart);
            this.Controls.Add(this.dtg_ShowHD);
            this.Name = "HoaDon_QL";
            this.Text = "HoaDon_QL";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_DateStop;
        private Button btn_Thoat;
        private Button btn_Hienthi;
        private DateTimePicker dtp_DateStart;
        private DataGridView dtg_ShowHD;
        private Label label1;
        private Button btt_Delete;
        private TextBox tbt_Id;
        private DataGridView dtg_ShowCT;
        private Label label2;
        private Button btt_out;
    }
}