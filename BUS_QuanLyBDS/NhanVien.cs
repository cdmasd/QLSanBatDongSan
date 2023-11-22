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
    public partial class NhanVien
    {
        DAL_QuanLyBDS.NhanVien nv = new DAL_QuanLyBDS.NhanVien();
        public List<BsonDocument> Chuaduyet()
        {
            return nv.Chuaduyet();
        }
        public List<BsonDocument> Daduyet()
        {
            return nv.Daduyet();
        }
        public bool Duyetbai(string id, string email)
        {
            return nv.Duyetbai(id, email);
        }
        public bool DeleteBaiDang(string id)
        {
            return nv.DeleteBaiDang(id);
        }
        public List<BsonDocument> Chuahotro()
        {
            return nv.Chuahotro();
        }
        public bool Hotro(string id, string email)
        {
            return nv.Hotro(id, email);
        }
        // khách hàng
        public List<BsonDocument> Getkhachhang()
        {
            return nv.Getkhachhang();
        }
        public bool UpdateKhachhang(string id, string email, string hoten, string sdt, double sodu)
        {
            return nv.UpdataKhachhang(id, email, hoten, sdt, sodu);
        }
    }
}
