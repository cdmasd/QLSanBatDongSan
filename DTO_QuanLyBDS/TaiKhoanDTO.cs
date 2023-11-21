using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBDS
{
    public class TaiKhoanDTO
    {
        public ObjectId _id { get; set; }
        public string Email { get; set; }
        public string Matkhau { get; set; }
        public string Vaitro { get; set; }
    }
}
