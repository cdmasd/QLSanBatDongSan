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
    public partial class FrmDuyetbai : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien(); 
        public FrmDuyetbai()
        {
            InitializeComponent();
            if (dtView == null)
            {
                dtView = new UIDataGridView();
                this.Controls.Add(dtView);
            }
            
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            
        }
        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtView.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string tieuDe = selectedRow.Cells["TieuDe"].Value.ToString();
                string loaiNha = selectedRow.Cells["LoaiNha"].Value.ToString();
                string dienTich = selectedRow.Cells["DienTich"].Value.ToString();
                string soPhong = selectedRow.Cells["SoPhong"].Value.ToString();
                string gia = selectedRow.Cells["Gia"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();

                // Hiển thị dữ liệu lên các controls
                txtTieude.Text = tieuDe;
                cbLoainha.Text = loaiNha;
                txtDientich.Text = dienTich;
                txtSophong.Text = soPhong;
                txtGia.Text = gia;
                txtDiachi.Text = diaChi;
                txtHinhanh.Text = hinhAnh;
            }
        }

        private void LoaDataNhanVien_KhachHang()
        {
            try
            {
                List<BsonDocument> dataBaiDang = nv.getDuyetbaiDang();

                if (dataBaiDang != null && dataBaiDang.Count > 0)
                {
                    if (dtView == null)
                    {
                        dtView = new UIDataGridView();
                        this.Controls.Add(dtView);
                    }

                    // Xóa các cột hiện tại trong DataGridView
                    dtView.Columns.Clear();

                    // Tạo các cột mới cho DataGridView
                    foreach (var key in dataBaiDang[0].Names)
                    {
                        dtView.Columns.Add(key, key);
                    }

                    // Đổ dữ liệu vào từng dòng của DataGridView
                    foreach (var doc in dataBaiDang)
                    {
                        List<object> values = new List<object>();
                        foreach (var key in doc.Names)
                        {
                            values.Add(doc[key]);
                        }
                        dtView.Rows.Add(values.ToArray());
                    }

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
    }
}
