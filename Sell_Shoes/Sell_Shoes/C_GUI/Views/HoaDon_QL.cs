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
        public HoaDon_QL()
        {
            InitializeComponent();
        }

        public void LoadDTGShow(List<HoaDon> hoaDons)
        {
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
        private void btn_Hienthi_Click(object sender, EventArgs e)
        {
            if (dtg_ShowHD.Rows.Count > 1)
            {
                dtg_ShowHD.Rows.Clear();
            }
            else
                LoadDTGShow(hdSV.ShowHoaDon());
        }
    }
}
