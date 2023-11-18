using DAL_QuanLyBDS.Admin;
using DTO_QuanLyBDS.Admin_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS.BUS_Admin
{
    public class BUS_Admin
    {
        private readonly DAL_Admin dal_Admin;

        public BUS_Admin()
        {
            dal_Admin = new DAL_Admin();
        }

        public DataTable DanhSachNhanVien()
        {
            return dal_Admin.DanhSachNhanVien();
        }

        public string MaNhanVien()
        {
            return null;
        }
    }
}
