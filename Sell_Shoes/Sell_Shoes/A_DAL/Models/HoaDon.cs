using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class HoaDon
    {
<<<<<<< HEAD
        public int MaHoadon { get; set; }
        public DateTime? Ngaylap { get; set; }
=======
        public HoaDon()
        {
            CthoaDons = new HashSet<CthoaDon>();
        }

        public int MaHoadon { get; set; }
        public DateTime Ngaylap { get; set; }
>>>>>>> Dev
        public decimal? Thanhtien { get; set; }
    }
}
