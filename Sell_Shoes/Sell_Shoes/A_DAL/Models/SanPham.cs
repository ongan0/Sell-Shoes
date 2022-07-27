using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string IdSanPham { get; set; } = null!;
        public string? IdNhanHang { get; set; }
        public string? Name { get; set; }
        public DateTime? Ngaynhap { get; set; }
        public int? Soluong { get; set; }
        public decimal? Dongia { get; set; }

        public virtual NhanHang? IdNhanHangNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
