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
    public partial class Order_NV : Form
    {

        SanPhamSV spSV = new SanPhamSV();
        HoaDonSv hdSV = new HoaDonSv();
        QLBG_HTContext context = new QLBG_HTContext();
        public Order_NV()
        {
            InitializeComponent();
        }
        public void LoadMenu(List<SanPham> sanPhams)
        {
            dtg_Menu.DataSource = null;
            dtg_Menu.Rows.Clear();
            dtg_Menu.ColumnCount = 5;
            dtg_Menu.Columns[0].Name = "ID";
            dtg_Menu.Columns[1].Name = "Tên";
            dtg_Menu.Columns[2].Name = "Hãng";
            dtg_Menu.Columns[3].Name = "Giá";
            dtg_Menu.Columns[4].Name = "Số lượng còn";
            dtg_Menu.Columns[0].Visible = false;
            foreach (var item in sanPhams)
            {
                dtg_Menu.Rows.Add(item.MaSanpham, item.Ten, item.Tenhang, item.Dongiaban, item.Soluongcon);
            }
        }
        public void AddHangHoa()
        {

        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_NV_Load(object sender, EventArgs e)
        {
            LoadMenu(spSV.ShowAllSanPham());
            dtg_GioHang.Rows.Clear();
            dtg_GioHang.ColumnCount = 5;
            dtg_GioHang.Columns[0].Name = "ID";
            dtg_GioHang.Columns[1].Name = "Tên";
            dtg_GioHang.Columns[2].Name = "Hãng";
            dtg_GioHang.Columns[4].Name = "Giá";
            dtg_GioHang.Columns[3].Name = "Số lượng";
            dtg_GioHang.Columns[0].Visible = false;
        }

        private void dtg_Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dem = 0;
            if (dtg_Menu.CurrentRow.Index == (dtg_Menu.Rows.Count-1 ))
            {

            }
            else
            {
                var id = dtg_Menu.CurrentRow.Cells[0].Value.ToString();
                var ten = dtg_Menu.CurrentRow.Cells[1].Value.ToString();
                var giaban = dtg_Menu.CurrentRow.Cells[3].Value.ToString();
                var hang = dtg_Menu.CurrentRow.Cells[2].Value.ToString();

                if (dtg_GioHang.Rows.Count <= 1)
                {
                    dtg_GioHang.Rows.Add(id, ten, hang, "1", giaban);

                }
                else
                {
                    for (int i = 0; i < dtg_GioHang.Rows.Count - 1; i++)
                    {
                        if (id == dtg_GioHang.Rows[i].Cells[0].Value.ToString())
                        {
                            dem++;
                        }
                    }
                    if (dem == 0)
                    {
                        dtg_GioHang.Rows.Add(id, ten, hang, "1", giaban);
                    }
                }
            }
        }
        string idgh;

        private void tbt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            int slCon=0;
            for (int i = 0; i < dtg_Menu.Rows.Count - 1; i++)
            {
                if (dtg_GioHang.CurrentRow.Cells[0].Value.ToString() == dtg_Menu.Rows[i].Cells[0].Value.ToString())
                {
                    slCon=(int)dtg_Menu.Rows[i].Cells[4].Value;
                    break;
                }
            }
            bool sl = int.TryParse(tbt_SoLuong.Text,out int a);
            if (sl && a<=slCon)
            {
                dtg_GioHang.CurrentRow.Cells[3].Value = tbt_SoLuong.Text;
            }else if(a>slCon) MessageBox.Show("Không đủ số lượng");
        }

        private void btt_XoaSP_Click(object sender, EventArgs e)
        {
            if (dtg_GioHang.CurrentRow == null || dtg_GioHang.CurrentRow.Index == (dtg_GioHang.Rows.Count - 1))
            {
                
            }
            else dtg_GioHang.Rows.RemoveAt(dtg_GioHang.CurrentRow.Index);
        }

        private void btn_Huydon_Click(object sender, EventArgs e)
        {
            dtg_GioHang.Rows.Clear();
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            if (dtg_GioHang.Rows.Count > 1)
            {
                HoaDon hoaDon = new HoaDon();
                
                decimal tien = 0;
                for(int i = 0; i < dtg_GioHang.Rows.Count - 1; i++)
                {
                    decimal x = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[4].Value);
                    decimal y = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[3].Value);
                    tien += (x * y);
                }
                hoaDon.Thanhtien = tien;
                context.HoaDons.Add(hoaDon);
                context.SaveChanges();
                var m = hdSV.ShowHoaDon().LastOrDefault(p => p.Thanhtien == tien);
                int mahd = m.MaHoadon;
                for(int i = 0; i < dtg_GioHang.Rows.Count - 1; i++)
                {
                    CthoaDon cthoaDon = new CthoaDon();
                    cthoaDon.MaHoadon = mahd;
                    int masp= Convert.ToInt32(dtg_GioHang.Rows[i].Cells[0].Value);
                    int slmua = Convert.ToInt32(dtg_GioHang.Rows[i].Cells[3].Value);
                    cthoaDon.MaSanpham = masp;
                    cthoaDon.Soluongmua = slmua;
                    context.CthoaDons.Add(cthoaDon);
                    context.SaveChanges();
                }
                dtg_GioHang.Rows.Clear();
                LoadMenu(spSV.ShowAllSanPham());
            }
        }

        private void dtg_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_GioHang.CurrentRow.Index == (dtg_GioHang.Rows.Count - 1))
            {

            }
            else
            {
                idgh = dtg_GioHang.CurrentRow.Cells[0].Value.ToString();
                tbt_SoLuong.Text = dtg_GioHang.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dtg_GioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal tien = 0;
            for (int i = 0; i < dtg_GioHang.Rows.Count - 1; i++)
            {
                decimal x = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[4].Value);
                decimal y = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[3].Value);
                tien += (x * y);
            }
            tbt_Tien.Text = tien.ToString();
        }

        private void dtg_GioHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal tien = 0;
            for (int i = 0; i < dtg_GioHang.Rows.Count - 1; i++)
            {
                decimal x = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[4].Value);
                decimal y = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[3].Value);
                tien += (x * y);
            }
            tbt_Tien.Text = tien.ToString();
        }

        private void dtg_GioHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            decimal tien = 0;
            for (int i = 0; i < dtg_GioHang.Rows.Count - 1; i++)
            {
                decimal x = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[4].Value);
                decimal y = Convert.ToDecimal(dtg_GioHang.Rows[i].Cells[3].Value);
                tien += (x * y);
            }
            tbt_Tien.Text = tien.ToString();
        }
    }
}
