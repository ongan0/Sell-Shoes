﻿using System;
using System.Collections.Generic;

namespace Sell_Shoes.A_DAL.Models
{
    public partial class SanPham
    {
        public int MaSanpham { get; set; }
        public string? Ten { get; set; }
        public decimal? Dongianhap { get; set; }
        public int? Soluongcon { get; set; }
        public string? Tenhang { get; set; }
    }
}
