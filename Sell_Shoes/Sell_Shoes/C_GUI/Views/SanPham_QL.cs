using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sell_Shoes.A_DAL.Models;
using Sell_Shoes.B_BUS.Services;

namespace Sell_Shoes.Views
{
    
    public partial class SanPham_QL : Form
{
        int count = 0;
        SanPhamSV sanPhamSV = new SanPhamSV();


        public SanPham_QL()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(List<SanPham> sanPhams)
        {
            dtg_Show.DataSource = null;
            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 5;
            dtg_Show.Columns[0].Name = "tên";
            dtg_Show.Columns[1].Name = "đơn giá nhập";
            dtg_Show.Columns[2].Name = "đơn giá bán";
            dtg_Show.Columns[3].Name = "số lượng còn";
            dtg_Show.Columns[4].Name = "tên hãng";

            foreach(var item in sanPhams)
            {
                dtg_Show.Rows.Add( item.Ten, item.Dongianhap,item.Dongiaban, item.Soluongcon, item.Tenhang);
            }
        }
        private void btn_ShowAll_Click(object sender, EventArgs e)
        { 
            if(count % 2 == 0)
            {
                LoadDataToGridView(sanPhamSV.ShowAllSanPham()); 
                count++;
            }
            else
            {
                dtg_Show.Rows.Clear();
                count++;
            }
        }

      // xóa sự kiện click
      // sửa phần thêm 

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //int masanpham = Convert.ToInt32(tbt_Ma.Text);
            //string ten = tbt_Ten.Text;
            //decimal dongianhap = Convert.ToDecimal(tbt_Gia.Text);
            //int soluongcon = Convert.ToInt32(tbt_Soluong.Text);
            //string tenhang = tbt_Ten.Text;
           
                string ten = tbt_Ten.Text;
                decimal dongianhap = Convert.ToDecimal(tbt_DonGiaBan.Text);
                decimal dongiaban = Convert.ToDecimal(tbt_DonGiaBan.Text);
                int soluongcon = Convert.ToInt32(tbt_Soluong.Text);
                string tenhang = tbt_DonGiaNhap.Text;
                MessageBox.Show(sanPhamSV.CreateNewSanPham(ten, dongianhap,dongiaban,  soluongcon, tenhang));
                LoadDataToGridView(sanPhamSV.ShowAllSanPham());

          
          
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                tbt_Ten.Text = dtg_Show.CurrentRow.Cells[0].Value.ToString();
                tbt_DonGiaNhap.Text = dtg_Show.CurrentRow.Cells[1].Value.ToString();
                tbt_DonGiaBan.Text = dtg_Show.CurrentRow.Cells[2].Value.ToString();
                tbt_Soluong.Text = dtg_Show.CurrentRow.Cells[3].Value.ToString();
                tbt_TenHang.Text = dtg_Show.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int masanpham = Convert.ToInt32(dtg_Show.CurrentRow.Cells[0].Value.ToString());
            string ten = tbt_Ten.Text;
            decimal dongianhap = Convert.ToDecimal(tbt_DonGiaBan.Text);
            decimal dongiaban = Convert.ToDecimal(tbt_DonGiaBan.Text);
            int soluongcon = Convert.ToInt32(tbt_Soluong.Text);
            string tenhang = tbt_DonGiaNhap.Text;
            MessageBox.Show(sanPhamSV.Updatesanpham(masanpham,ten, dongianhap, dongiaban ,soluongcon, tenhang));
            LoadDataToGridView(sanPhamSV.ShowAllSanPham());
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string ten = tbt_Ten.Text;
            MessageBox.Show(sanPhamSV.DeleteSanPham(ten));
            LoadDataToGridView(sanPhamSV.ShowAllSanPham());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            TongHopCN_QL tongHopCN_QL = new TongHopCN_QL();
            tongHopCN_QL.ShowDialog();
        }
    }
}
