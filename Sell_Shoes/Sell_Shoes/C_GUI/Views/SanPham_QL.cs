using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sell_Shoes.A_DAL.Models;
using Sell_Shoes.B_BUS.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sell_Shoes.Views
{

    public partial class SanPham_QL : Form
    {

        SanPhamSV sanPhamSV = new SanPhamSV();
        QLBG_HTContext context = new QLBG_HTContext();
        public SanPham_QL()
        {
            InitializeComponent();
            LoadDataToGridView(sanPhamSV.ShowAllSanPham());
        }
        public void LoadDataToGridView(List<SanPham> sanPhams)
        {
            dtg_Show.DataSource = null;
            dtg_Show.Rows.Clear();

            dtg_Show.ColumnCount = 6;
            dtg_Show.Columns[0].Name = "ID";
            dtg_Show.Columns[1].Name = "tên";
            dtg_Show.Columns[2].Name = "đơn giá nhập";
            dtg_Show.Columns[3].Name = "đơn giá bán";
            dtg_Show.Columns[4].Name = "số lượng còn";
            dtg_Show.Columns[5].Name = "tên hãng";

            dtg_Show.Columns[0].Visible = false;

            foreach (var item in sanPhams)
            {
                dtg_Show.Rows.Add(item.MaSanpham, item.Ten, item.Dongianhap, item.Dongiaban, item.Soluongcon, item.Tenhang);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            decimal dongianhap = 0;
            decimal dongiaban = 0;
            int soluongcon = 0;
            string ten = tbt_Ten.Text;
            string tenhang = tbt_TenHang.Text;
            bool m = Decimal.TryParse(tbt_DonGiaNhap.Text, out decimal x);
            bool n = Decimal.TryParse(tbt_DonGiaBan.Text, out decimal y);
            bool p = int.TryParse(tbt_Soluong.Text, out int z);
            if (ten == "" || tenhang == "")
                MessageBox.Show("Bạn không được để trống thông tin");
            else if (!m || !n || !p) MessageBox.Show("Số lượng và giá phải được nhập số");
            else if (m & n & p)
            {
                dongianhap = x;
                dongiaban = y;
                soluongcon = z;
                if (dongiaban <= 0 || dongianhap <= 0 || soluongcon <= 0) MessageBox.Show("Số lượng và giá phải lớn hơn 0");
                else
                    MessageBox.Show(sanPhamSV.CreateNewSanPham(ten, dongianhap, dongiaban, soluongcon, tenhang));
            }

            LoadDataToGridView(sanPhamSV.ShowAllSanPham());
        }

        public bool isNumber(string pText)
        {
            Regex regex = new Regex(@"\d");
            return regex.IsMatch(pText);
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbt_Ten.Text = dtg_Show.CurrentRow.Cells[1].Value.ToString();
            tbt_DonGiaNhap.Text = dtg_Show.CurrentRow.Cells[2].Value.ToString();
            tbt_DonGiaBan.Text = dtg_Show.CurrentRow.Cells[3].Value.ToString();
            tbt_Soluong.Text = dtg_Show.CurrentRow.Cells[4].Value.ToString();
            tbt_TenHang.Text = dtg_Show.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (sanPhamSV.ShowAllSanPham().Count == 0)
            {
                MessageBox.Show("danh sách trống");
            }
            else
            {
                int id = Convert.ToInt32(dtg_Show.CurrentRow.Cells[0].Value);
                decimal dongianhap = 0;
                decimal dongiaban = 0;
                int soluongcon = 0;
                string ten = tbt_Ten.Text;
                string tenhang = tbt_TenHang.Text;
                bool m = Decimal.TryParse(tbt_DonGiaNhap.Text, out decimal x);
                bool n = Decimal.TryParse(tbt_DonGiaBan.Text, out decimal y);
                bool p = int.TryParse(tbt_Soluong.Text, out int z);
                if (ten == "" || tenhang == "")
                    MessageBox.Show("Bạn không được để trống thông tin");
                else if (!m || !n || !p) MessageBox.Show("Số lượng và giá phải được nhập số");
                else if (m & n & p)
                {
                    dongianhap = x;
                    dongiaban = y;
                    soluongcon = z;
                    if (dongiaban <= 0 || dongianhap <= 0 || soluongcon <= 0) MessageBox.Show("Số lượng và giá phải lớn hơn 0");
                    else
                        MessageBox.Show(sanPhamSV.Updatesanpham(id, ten, dongianhap, dongiaban, soluongcon, tenhang));
                }
                LoadDataToGridView(sanPhamSV.ShowAllSanPham());
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int masanpham = Convert.ToInt32(dtg_Show.CurrentRow.Cells[0].Value);
            var list = context.CthoaDons.FirstOrDefault(p => p.MaSanpham == masanpham);
            if (list == null)
                MessageBox.Show(sanPhamSV.DeleteSanPham(masanpham));
            else MessageBox.Show("Sản phẩm này bạn không thể xóa. Hãy liên hệ ADMIN để được hỗ trợ");
            LoadDataToGridView(sanPhamSV.ShowAllSanPham());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
