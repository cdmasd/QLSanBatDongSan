using MongoDB.Bson;
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

namespace QuanLyBDS.NhanVien
{
    public partial class FrmDaduyet : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        public FrmDaduyet()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tieude = txtTieude.Text;
            if (kh != null)
            {

                bool xoaThanhCong = kh.DetelebaiDang(tieude);

                // Kiểm tra kết quả xóa và thông báo cho người dùng
                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    Loadata(); // Reset data
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }
        public void ResetValue()
        {

        }
        private void Loadata()
        {
            try
            {
                List<BsonDocument> dataBaiDang = kh.GetDataKhachHang();

                if (dataBaiDang != null && dataBaiDang.Count > 0)
                {
                    if (dtView == null)
                    {
                        dtView = new UIDataGridView();
                        this.Controls.Add(dtView);
                    }

                    dtView.DataSource = dataBaiDang;
                    dtView.Columns["TieuDe"].HeaderText = "Tiêu đề";
                    dtView.Columns["LoaiNha"].HeaderText = "Loại nhà";
                    dtView.Columns["DienTich"].HeaderText = "Diện tích";
                    dtView.Columns["SoPhong"].HeaderText = "Số phòng";
                    dtView.Columns["Gia"].HeaderText = "Giá";
                    dtView.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    dtView.Columns["HinhAnh"].HeaderText = "Hình ảnh";
                    dtView.Columns["Duyet"].HeaderText = "Trạng thái";

                    dtView.Refresh();  // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private void dtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
