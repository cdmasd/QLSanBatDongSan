﻿using QuanLyBDS.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.Admin
{
    public partial class FrmDaduyet_Admin : FrmDaduyet
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        public FrmDaduyet_Admin()
        {
            InitializeComponent();
        }

        private void FrmDaduyet_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
