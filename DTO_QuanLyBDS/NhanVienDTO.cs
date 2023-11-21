using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBDS
{
    public class NhanVienDTO
    {
        public string _id { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaybatdau { get; set; } = DateTime.Now;
        public string Hoten { get; set; }
    }
}
