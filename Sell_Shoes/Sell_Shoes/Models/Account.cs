using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell_Shoes.Models
{
    public class Account
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public Account()
        {
        }

        public Account(string tenDangNhap, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }
    }
}
