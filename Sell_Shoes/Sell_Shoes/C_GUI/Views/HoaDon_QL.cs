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
    public partial class HoaDon_QL : Form
    {
        List<HoaDon> hoaDons = new List<HoaDon>();
        HoaDonSv hdSV = new HoaDonSv();
        SanPham sanPham = new SanPham();
        QLBG_HTContext htContext = new QLBG_HTContext();

        public HoaDon_QL()
        {
            InitializeComponent();
        }

        public void LoadDTGShow(List<HoaDon> hoaDons)
        {
            dtg_ShowHD.DataSource = null;
            dtg_ShowHD.Rows.Clear();
            dtg_ShowHD.ColumnCount = 4;
            dtg_ShowHD.Columns[0].Name = "Id";
            dtg_ShowHD.Columns[1].Name = "Ngày tạo";
            dtg_ShowHD.Columns[2].Name = "thành tiền";
            
            foreach (HoaDon hoaDon in hoaDons)
            {
                dtg_ShowHD.Rows.Add(hoaDon.MaHoadon, hoaDon.Ngaylap, hoaDon.Thanhtien);
            }
        }
        public void LoadDTShowCT(int id, List<CthoaDon> cthoaDons)
        {
            dtg_ShowCT.Rows.Clear();
            dtg_ShowCT.ColumnCount = 4;
            dtg_ShowCT.Columns[0].Name = "Tên Sản phẩm";
            dtg_ShowCT.Columns[1].Name = "Số lượng";
            dtg_ShowCT.Columns[2].Name = "Đơn giá";
            dtg_ShowCT.Columns[3].Name = "Thành tiền";
            foreach(CthoaDon hoaDonCT in cthoaDons)
            {
                if (id == hoaDonCT.MaHoadon) 
                {
                    
                    var name = htContext.SanPhams.FirstOrDefault(p => p.MaSanpham == hoaDonCT.MaSanpham).Ten.ToString();
                    
                    dtg_ShowCT.Rows.Add(name,hoaDonCT.Soluongmua,hoaDonCT.Dongiaban,hoaDonCT.Tongtien); 
                }
            }
        }
        private void btn_Hienthi_Click(object sender, EventArgs e)
        {
            if (dtg_ShowHD.Rows.Count > 1)
            {
                dtg_ShowHD.Rows.Clear();
            }
            else
                LoadDTGShow(hdSV.ShowHoaDon());
        }
        private void dtg_ShowHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbt_Id.Text = dtg_ShowHD.CurrentRow.Cells[0].Value.ToString();
                int id = Convert.ToInt32(tbt_Id.Text);
                LoadDTShowCT(id, hdSV.ShowCTHoaDon());
            }
            catch (Exception)
            {
                tbt_Id.Text = "";
                dtg_ShowCT.Rows.Clear();
            }
            
        }
        private void btt_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbt_Id.Text);
            MessageBox.Show(hdSV.DeleteHD(id));
            LoadDTGShow(hdSV.ShowHoaDon());
        }

        private void dtp_DateStop_ValueChanged(object sender, EventArgs e)
        {
            var start = Convert.ToDateTime(dtp_DateStart.Value);
            var stop = Convert.ToDateTime(dtp_DateStop.Value);
            dtg_ShowHD.DataSource = hdSV.SearchHD(start,stop);
        }
    }
}
