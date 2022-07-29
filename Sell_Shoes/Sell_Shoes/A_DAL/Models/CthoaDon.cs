using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class CthoaDon
    {
        public int MaCthoadon { get; set; }
        public string MaSanpham { get; set; } = null!;
        public string MaHoadon { get; set; } = null!;
        public int? Soluongmua { get; set; }
        public decimal? Dongiaban { get; set; }
        public decimal? Tongtien { get; set; }

        public virtual HoaDon MaHoadonNavigation { get; set; } = null!;
        public virtual SanPham MaSanphamNavigation { get; set; } = null!;
    }
}
