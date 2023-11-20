using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public class NhanVien
    {
        DAL_QuanLyBDS.NhanVien nv = new DAL_QuanLyBDS.NhanVien();
        public List<BsonDocument> Chuaduyet()
        {
            return nv.Chuaduyet();
        }
        public bool Duyetbai(string id, string email)
        {
            return nv.Duyetbai(id, email);
        }
        public bool DeleteBaiDang(string id)
        {
            return nv.DeleteBaiDang(id);
        }
    }
}
