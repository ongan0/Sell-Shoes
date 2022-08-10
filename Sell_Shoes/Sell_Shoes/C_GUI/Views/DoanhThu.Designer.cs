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
            this.dtp_DateStart = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateStop = new System.Windows.Forms.DateTimePicker();
            this.dtg_ShowDT = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_DateStart
            // 
            this.dtp_DateStart.Location = new System.Drawing.Point(188, 67);
            this.dtp_DateStart.Name = "dtp_DateStart";
            this.dtp_DateStart.Size = new System.Drawing.Size(261, 27);
            this.dtp_DateStart.TabIndex = 2;
            this.dtp_DateStart.ValueChanged += new System.EventHandler(this.dtp_DateStart_ValueChanged);
            // 
            // dtp_DateStop
            // 
            this.dtp_DateStop.Location = new System.Drawing.Point(472, 67);
            this.dtp_DateStop.Name = "dtp_DateStop";
            this.dtp_DateStop.Size = new System.Drawing.Size(264, 27);
            this.dtp_DateStop.TabIndex = 3;
            this.dtp_DateStop.ValueChanged += new System.EventHandler(this.dtp_DateStop_ValueChanged);
            // 
            // dtg_ShowDT
            // 
            this.dtg_ShowDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ShowDT.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtg_ShowDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowDT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_ShowDT.Location = new System.Drawing.Point(188, 134);
            this.dtg_ShowDT.Name = "dtg_ShowDT";
            this.dtg_ShowDT.RowHeadersWidth = 51;
            this.dtg_ShowDT.RowTemplate.Height = 29;
            this.dtg_ShowDT.Size = new System.Drawing.Size(548, 336);
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
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 584);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dtg_ShowDT);
            this.Controls.Add(this.dtp_DateStop);
            this.Controls.Add(this.dtp_DateStart);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker dtp_DateStart;
        private DateTimePicker dtp_DateStop;
        private DataGridView dtg_ShowDT;
        private Button btn_Thoat;
    }
}