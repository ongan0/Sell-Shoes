﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sell_Shoes.Views
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            TongHopCN_QL tongHopCN_QL = new TongHopCN_QL();
            Dispose(true);
            tongHopCN_QL.ShowDialog();
        }
    }
}
