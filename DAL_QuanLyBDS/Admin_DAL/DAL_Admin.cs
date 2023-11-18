using DTO_QuanLyBDS.Admin_DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS.Admin
{
    public class DAL_Admin : Context
    {
        private IMongoCollection<NhanVien> _NhanVienCollection;

        public DataTable DanhSachNhanVien()
        {
            try
            {
                var db = client.GetDatabase("QLBatDongSan");
                _NhanVienCollection = db.GetCollection<NhanVien>("NhanVien");
                /*var projection = Builders<NhanVien>.Projection.Exclude(nv => nv.N)*/
                var listNhanVien = _NhanVienCollection.Find(new BsonDocument()).ToList();
                return BangNhanVien(listNhanVien);
            }
            catch
            {
                return new DataTable();
            }
        }

        private DataTable BangNhanVien(List<NhanVien> listNhanVien)
        {
            DataTable dt = new DataTable();

            foreach (var prop in typeof(NhanVien).GetProperties())
            {
                dt.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var nhanVien in listNhanVien)
            {
                DataRow row = dt.NewRow();
                foreach (var prop in typeof(NhanVien).GetProperties())
                {
                    row[prop.Name] = prop.GetValue(nhanVien);
                }
                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
