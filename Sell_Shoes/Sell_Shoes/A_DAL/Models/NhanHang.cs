using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class NhanHang
    {
        public NhanHang()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string IdNhanHang { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
