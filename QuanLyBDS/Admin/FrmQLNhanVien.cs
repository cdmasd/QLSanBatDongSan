using BUS_QuanLyBDS.BUS_Admin;
using Sunny.UI;
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
    public partial class FrmQLNhanVien : UIForm
    {
        private BUS_Admin bus_Admin;

        public FrmQLNhanVien()
        {
            InitializeComponent();
            bus_Admin = new BUS_Admin();
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtView.DataSource = bus_Admin.DanhSachNhanVien();
        }
    }
}
