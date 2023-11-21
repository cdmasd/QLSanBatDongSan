using DTO_QuanLyBDS;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public class Admin : Context
    {
        private IMongoCollection<NhanVienDTO> NhanVienCollection()
        {
            var db = client.GetDatabase("QLBatDongSan");
            return db.GetCollection<NhanVienDTO>("NhanVien");
        }

        private IMongoCollection<TaiKhoanDTO> TaiKhoanCollection()
        {
            var db = client.GetDatabase("QLBatDongSan");
            return db.GetCollection<TaiKhoanDTO>("TaiKhoan");
        }

        public List<NhanVienDTO> DanhSachNhanVien()
        {
            try
            {
                return NhanVienCollection().Find(new BsonDocument()).ToList();
            }
            catch
            {
                return new List<NhanVienDTO>();
            }
        }

        public List<int> DanhSachSoId()
        {
            try
            {
                var coll = NhanVienCollection();
                var filter = Builders<NhanVienDTO>.Filter.Regex("_id", new BsonRegularExpression("NV"));
                var projection = Builders<NhanVienDTO>.Projection.Include("_id");

                var idList = coll.Find(filter).Project(projection).ToList().Select(doc => doc["_id"].AsString);

                return idList.Select(id => int.Parse(id.Substring(2))).ToList();
            }
            catch
            {
                return null;
            }
        }

        public string ThemNhanVien(NhanVienDTO nhanVien, TaiKhoanDTO taiKhoan)
        {
            try
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                if (string.IsNullOrWhiteSpace(nhanVien.Email) || string.IsNullOrWhiteSpace(nhanVien.Hoten) || string.IsNullOrWhiteSpace(nhanVien.Diachi) || string.IsNullOrWhiteSpace(nhanVien.Sodienthoai))
                {
                    return "Không thể thêm nhân viên xin hãy kiểm tra lại";
                }
                var nvColl = NhanVienCollection();
                var tkColl = TaiKhoanCollection();
                nvColl.InsertOne(nhanVien);
                tkColl.InsertOne(new TaiKhoanDTO
                {
                    Email = tk.Email,
                    Matkhau = tk.Matkhau,
                    Vaitro = "nhanvien"
                });
                return "Thêm nhân viên thành công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nhanVien.Email) || string.IsNullOrWhiteSpace(nhanVien.Hoten) || string.IsNullOrWhiteSpace(nhanVien.Diachi) || string.IsNullOrWhiteSpace(nhanVien.Sodienthoai))
                {
                    return "Không thể cập nhật nhân viên xin hãy kiểm tra lại";
                }
                var nvcol = NhanVienCollection();
                var filter = Builders<NhanVienDTO>.Filter.Eq("Email", nhanVien.Email); // Thay "_id" bằng tên trường ID thực tế của bạn
                var update = Builders<NhanVienDTO>.Update
                    .Set("Hoten", nhanVien.Hoten)
                    .Set("Diachi", nhanVien.Diachi)
                    .Set("Sodienthoai", nhanVien.Sodienthoai)
                    .Set("Ngaybatbau", nhanVien.Ngaybatdau);

                NhanVienCollection().UpdateOne(filter, update);
                return "Cập nhật nhân viên thành công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string XoaNhanVien(string Email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Email))
                {
                    return "Xoá Nhân Viên Không Thành Công Hãy Kiểm Tra Lại";
                }
                var nvColl = NhanVienCollection();
                var tkColl = TaiKhoanCollection();
                var nvfilter = Builders<NhanVienDTO>.Filter.Eq("Email", Email);
                var tkfilter = Builders<TaiKhoanDTO>.Filter.Eq("Email", Email);
                nvColl.DeleteOne(nvfilter);
                tkColl.DeleteOne(tkfilter);
                return "Xóa Nhân Viên Thành Công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<NhanVienDTO> TimKiemNhanVienTheoId(string Id)
        {
            try
            {
                var filter = Builders<NhanVienDTO>.Filter.Eq("_id", Id);
                return NhanVienCollection().Find(filter).ToList();
            }
            catch
            {
                return new List<NhanVienDTO>();
            }
        }

        public string DoiMatKhau(string email, string matkhauhientai, string matkhaumoi)
        {
            try
            {
                var tkColl = TaiKhoanCollection();
                var tkTonTai = tkColl.Find(new BsonDocument
                {
                    { "Email", email },
                    { "Matkhau", matkhauhientai }
                }).ToList();

                if (tkTonTai != null)
                {
                    var updateFilter = Builders<TaiKhoanDTO>.Filter.Eq("Email", email);
                    var update = Builders<TaiKhoanDTO>.Update.Set("Matkhau", matkhaumoi);

                    var result = tkColl.UpdateOne(updateFilter, update);

                    if (result.IsAcknowledged && result.ModifiedCount > 0)
                    {
                        return "Đổi mật khẩu thành công";
                    }
                    else
                    {
                        return "Có lỗi xảy ra khi cập nhật mật khẩu mới.";
                    }
                }
                else
                {
                    return "Sai mật khẩu hiện tại";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
