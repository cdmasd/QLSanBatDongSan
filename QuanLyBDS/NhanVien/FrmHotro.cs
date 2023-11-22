using MongoDB.Bson;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.NhanVien
{
    public partial class FrmHotro : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        public FrmHotro()
        {
            InitializeComponent();
        }
        private void LoadBaiDang()
        {
            dtView.ClearAll();
            List<BsonDocument> hotro = nv.Chuahotro();
            if (hotro.Count > 0)
            {
                // Load header name
                foreach (var header in hotro[0].Names)
                {

                    if (header != "TrangThai")
                    {
                        dtView.Columns.Add(header, header);
                    }
                    else
                    {
                        continue;
                    }
                }
                // Đổ dữ liệu vào từng dòng của DataGridView
                foreach (var doc in hotro)
                {
                    List<object> values = new List<object>();
                    foreach (var key in doc.Names)
                    {
                        values.Add(doc[key]);
                    }
                    dtView.Rows.Add(values.ToArray());
                }
                dtView.Columns[0].HeaderText = "Mã ticket";
                dtView.Columns[1].HeaderText = "Số điện thoại";
                dtView.Columns[2].HeaderText = "Vấn đề";
                dtView.Columns[3].HeaderText = "Chi tiết";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void FrmHotro_Load(object sender, EventArgs e)
        {
            LoadBaiDang();
        }

        private void dtView_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu có tồn tại trên 1 dòng
                if (dtView.Rows.Count > 0)
                {
                    // hiện dữ liệu khi dòng được chọn
                    txtId.Text = dtView.CurrentRow.Cells[0].Value.ToString();
                    txtHotro.Text = dtView.CurrentRow.Cells[2].Value.ToString();
                    txtChitiethotro.Text = dtView.CurrentRow.Cells[3].Value.ToString();
                    txtSodt.Text = dtView.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi phát sinh");
            }
        }
        void resetValues()
        {
            txtHotro.Text = "";
            txtChitiethotro.Text = "";
            txtSodt.Text = "";
        }

        private void btnDahotro_Click(object sender, EventArgs e)
        {
            if (nv.Hotro(txtId.Text, FrmMain.mail))
            {
                ShowSuccessNotifier("Thành công");
                resetValues();
            }
            else
            {
                ShowErrorNotifier("Thất bại");
            }
            LoadBaiDang();
        }
    }
}
