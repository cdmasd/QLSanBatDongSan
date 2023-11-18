using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBDS.Admin_DTO
{
    public class NhanVien
    {
        public ObjectId _id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string VaiTro { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgayBatDau { get; set; } = DateTime.Now;
    }
}
