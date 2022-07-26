﻿using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            CthoaDons = new HashSet<CthoaDon>();
        }

        public int MaSanpham { get; set; }
        public string? Tenhang { get; set; }
        public string? Ten { get; set; }
        public decimal? Dongianhap { get; set; }
        public decimal? Dongiaban { get; set; }
        public int? Soluongcon { get; set; }

        public SanPham(string? tenhang, string? ten, decimal? dongianhap, decimal? dongiaban, int? soluongcon )
        {
            Tenhang = tenhang;
            Ten = ten;
            Dongianhap = dongianhap;
            Dongiaban = dongiaban;
            Soluongcon = soluongcon;
        }

        public virtual ICollection<CthoaDon> CthoaDons { get; set; }
    }
}
