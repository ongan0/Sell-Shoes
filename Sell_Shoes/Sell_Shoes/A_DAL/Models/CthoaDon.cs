using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class CthoaDon
    {
        public int MaCthoadon { get; set; }
        public int MaSanpham { get; set; }
        public int MaHoadon { get; set; }
        public decimal? Dongiaban { get; set; }
        public int? Soluongmua { get; set; }
        public decimal? Tongtien { get; set; }

        public virtual SanPham MaSanpham1 { get; set; } = null!;
        public virtual HoaDon MaSanphamNavigation { get; set; } = null!;
    }
}
