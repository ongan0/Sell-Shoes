using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class HoaDon
    {
        public string IdHoaDon { get; set; } = null!;
        public string? IdSanPham { get; set; }
        public DateTime? Ngayxuat { get; set; }
        public int? Soluong { get; set; }

        public virtual SanPham? IdSanPhamNavigation { get; set; }
    }
}
