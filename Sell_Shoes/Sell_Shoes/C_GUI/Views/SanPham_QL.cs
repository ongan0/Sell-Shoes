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

namespace Sell_Shoes.Views
{
    
    public partial class SanPham_QL : Form
{
        int count = 0;
        SanPhamSV sanPhamSV = new SanPhamSV();


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

            foreach(var item in sanPhams)
            {
                dtg_Show.Rows.Add( item.MaSanpham,item.Ten, item.Dongianhap,item.Dongiaban, item.Soluongcon, item.Tenhang);
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
                dtg_Show.DataSource = null;
                dtg_Show.Rows.Clear();
                count++;
            }
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = tbt_Ten.Text;
                decimal dongianhap = Convert.ToDecimal(tbt_DonGiaNhap.Text);
                decimal dongiaban = Convert.ToDecimal(tbt_DonGiaBan.Text);
                int soluongcon = Convert.ToInt32(tbt_Soluong.Text);
                string tenhang = tbt_TenHang.Text;
                if (isNumber(tenhang) == false) 
                {
                    MessageBox.Show(sanPhamSV.CreateNewSanPham(ten, dongianhap, dongiaban, soluongcon, tenhang));
                    LoadDataToGridView(sanPhamSV.ShowAllSanPham());
                }
                else
                {
                    MessageBox.Show("tên hãng không đc ghi số ");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("đơn giá không được nhập chữ");
            }

         }
        
        public bool isNumber(string pText)
        {
            Regex regex = new Regex(@"^[a-zA-Z]$");
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
            // lấy ra thứ tứ của hàng trong bảng là gì 
            try 
            {
                int masanpham = Convert.ToInt32(dtg_Show.CurrentRow.Cells[0].Value.ToString());
                string ten = tbt_Ten.Text;
                decimal dongianhap = Convert.ToDecimal(tbt_DonGiaNhap.Text);
                decimal dongiaban = Convert.ToDecimal(tbt_DonGiaBan.Text);
                int soluongcon = Convert.ToInt32(tbt_Soluong.Text);
                string tenhang = tbt_TenHang.Text;
                if (isNumber(tenhang) == false)
                {
                    MessageBox.Show(sanPhamSV.CreateNewSanPham(ten, dongianhap, dongiaban, soluongcon, tenhang));
                    LoadDataToGridView(sanPhamSV.ShowAllSanPham());
                }
                else
                {
                    MessageBox.Show("tên hãng không đc ghi số ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("đơn giá không được nhập chữ");
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int masanpham = Convert.ToInt32(dtg_Show.CurrentRow.Cells[0].Value);
            MessageBox.Show(sanPhamSV.DeleteSanPham(masanpham));
            LoadDataToGridView(sanPhamSV.ShowAllSanPham());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            TongHopCN_QL tongHopCN_QL = new TongHopCN_QL();
            Dispose(true);
            tongHopCN_QL.ShowDialog();
        }
    }
}
