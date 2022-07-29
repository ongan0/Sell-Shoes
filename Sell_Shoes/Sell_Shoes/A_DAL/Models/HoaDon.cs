using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            CthoaDons = new HashSet<CthoaDon>();
        }

        public string MaHoadon { get; set; } = null!;
        public DateTime? Ngaylap { get; set; }
        public decimal? Thanhtien { get; set; }

        public virtual ICollection<CthoaDon> CthoaDons { get; set; }
    }
}
