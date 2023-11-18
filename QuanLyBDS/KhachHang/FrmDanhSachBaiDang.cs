using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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

namespace QuanLyBDS.KhachHang
{
    public partial class FrmDanhSachBaiDang : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        string checkUrlImage;
        string fileName;
        string filSavePath;
        string fileAddress;
        public FrmDanhSachBaiDang()
        {
            InitializeComponent();
            Loainha();
            // Load dữ liệu từ MongoDB và hiển thị trên DataGridView
            LoadDataKhachHang();

        }
        private void Loainha()
        {
            cbLoainha.Items.Add("Nhà c3");
            cbLoainha.Items.Add("Nhà c4");
            cbLoainha.Items.Add("Biệt thự");
            cbLoainha.Items.Add("Vincome");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTieude.Text;
                string home = cbLoainha.Text;
                string dientich = txtDientich.Text;
                string sophong = txtSophong.Text;
                string gia = txtGia.Text;
                string diaChi = txtDiachi.Text;
                string hinhAnh = txtHinhanh.Text;

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(home) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(hinhAnh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                bool result = kh.UpdateBaiDang(title, home, dientich, sophong, gia, diaChi, hinhAnh);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadDataKhachHang();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void dtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlopen = new OpenFileDialog();
            dlopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*.gif)|*.gif|ALL file(*.*)|*.*";
            dlopen.FilterIndex = 2;
            dlopen.Title = "Chọn hình ảnh sản phẩm";
            if (dlopen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlopen.FileName;
                fileName = Path.GetFileName(dlopen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                filSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinhanh.Text = "\\Images\\" + fileName;

            }

        }
        private void LoadDataKhachHang()
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


        private void FrmDanhSachBaiDang_Load(object sender, EventArgs e)
        {

        }

    }
}
     

