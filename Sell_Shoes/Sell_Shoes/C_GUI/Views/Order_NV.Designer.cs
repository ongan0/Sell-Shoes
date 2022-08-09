namespace Sell_Shoes.Views
{
    partial class Order_NV
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
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.btn_Huydon = new System.Windows.Forms.Button();
            this.dtg_GioHang = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dtg_Menu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_SoLuong = new System.Windows.Forms.TextBox();
            this.btt_XoaSP = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thanhtoan.Location = new System.Drawing.Point(761, 509);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(121, 48);
            this.btn_Thanhtoan.TabIndex = 2;
            this.btn_Thanhtoan.Text = "Thanh toán ";
            this.btn_Thanhtoan.UseVisualStyleBackColor = true;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // btn_Huydon
            // 
            this.btn_Huydon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huydon.Location = new System.Drawing.Point(570, 509);
            this.btn_Huydon.Name = "btn_Huydon";
            this.btn_Huydon.Size = new System.Drawing.Size(121, 48);
            this.btn_Huydon.TabIndex = 4;
            this.btn_Huydon.Text = "Hủy đơn ";
            this.btn_Huydon.UseVisualStyleBackColor = true;
            this.btn_Huydon.Click += new System.EventHandler(this.btn_Huydon_Click);
            // 
            // dtg_GioHang
            // 
            this.dtg_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_GioHang.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_GioHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_GioHang.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_GioHang.Location = new System.Drawing.Point(570, 36);
            this.dtg_GioHang.Name = "dtg_GioHang";
            this.dtg_GioHang.RowHeadersWidth = 51;
            this.dtg_GioHang.RowTemplate.Height = 29;
            this.dtg_GioHang.Size = new System.Drawing.Size(488, 344);
            this.dtg_GioHang.TabIndex = 5;
            this.dtg_GioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_GioHang_CellClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(937, 509);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(121, 48);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dtg_Menu
            // 
            this.dtg_Menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Menu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Menu.Location = new System.Drawing.Point(12, 36);
            this.dtg_Menu.Name = "dtg_Menu";
            this.dtg_Menu.RowHeadersWidth = 51;
            this.dtg_Menu.RowTemplate.Height = 29;
            this.dtg_Menu.Size = new System.Drawing.Size(520, 531);
            this.dtg_Menu.TabIndex = 7;
            this.dtg_Menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Menu_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(603, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số lượng";
            // 
            // tbt_SoLuong
            // 
            this.tbt_SoLuong.Location = new System.Drawing.Point(757, 430);
            this.tbt_SoLuong.Name = "tbt_SoLuong";
            this.tbt_SoLuong.Size = new System.Drawing.Size(125, 27);
            this.tbt_SoLuong.TabIndex = 9;
            this.tbt_SoLuong.TextChanged += new System.EventHandler(this.tbt_SoLuong_TextChanged);
            // 
            // btt_XoaSP
            // 
            this.btt_XoaSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btt_XoaSP.Location = new System.Drawing.Point(937, 421);
            this.btt_XoaSP.Name = "btt_XoaSP";
            this.btt_XoaSP.Size = new System.Drawing.Size(121, 58);
            this.btt_XoaSP.TabIndex = 10;
            this.btt_XoaSP.Text = "Xóa sản phẩm";
            this.btt_XoaSP.UseVisualStyleBackColor = true;
            this.btt_XoaSP.Click += new System.EventHandler(this.btt_XoaSP_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Menu.Location = new System.Drawing.Point(232, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(61, 25);
            this.Menu.TabIndex = 11;
            this.Menu.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(770, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giỏ hàng";
            // 
            // Order_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1070, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btt_XoaSP);
            this.Controls.Add(this.tbt_SoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Menu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dtg_GioHang);
            this.Controls.Add(this.btn_Huydon);
            this.Controls.Add(this.btn_Thanhtoan);
            this.Name = "Order_NV";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_GioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Thanhtoan;
        private Button btn_Huydon;
        private DataGridView dtg_GioHang;
        private Button btn_Thoat;
        private DataGridView dtg_Menu;
        private Label label1;
        private TextBox tbt_SoLuong;
        private Button btt_XoaSP;
        private Label Menu;
        private Label label3;
    }
}