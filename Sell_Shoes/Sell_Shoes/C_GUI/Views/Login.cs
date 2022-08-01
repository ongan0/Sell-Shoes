using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sell_Shoes.B_BUS.Utilities;
using Sell_Shoes;

namespace Sell_Shoes.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        List<Account> accounts = new List<Account>()
        {
            new Account("manage","manage"),
            new Account("staff","staff")
            
        };
        private Account? account;
        private void btt_Login_Click(object sender, EventArgs e)
        {
       
            // toi da sua code 
        
            if (tbt_TenDangNhap.Text.Trim() == String.Empty || tbt_MatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ tên đăng nhập và mật khẩu");
            }
            else
            {
                Account? account = accounts.FirstOrDefault(a => a.username == tbt_TenDangNhap.Text.Trim() && a.password == tbt_MatKhau.Text.Trim());
                if (account == null)
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu");
                }
                else if(tbt_TenDangNhap.Text.Trim() == "manage" && tbt_MatKhau.Text.Trim() =="manage")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    TongHopCN_QL tongHopCN_QL = new TongHopCN_QL();
                    tongHopCN_QL.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    TongHopCN_NV tongHopCN_NV = new TongHopCN_NV();
                    tongHopCN_NV.ShowDialog();
                }
            }
        }

        
    }
}
