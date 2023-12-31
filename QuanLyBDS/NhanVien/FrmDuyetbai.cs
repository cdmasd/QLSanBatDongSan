﻿using MongoDB.Bson;
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
            UiSettings();
        }
        public void UiSettings()
        {
            UIStyles.DPIScale = true;
            UIStyles.GlobalFont = true;
            UIStyles.GlobalFontName = "Tahoma";
            UIStyles.SetDPIScale();
            UILocalize.OK = "Ok";
            UILocalize.Cancel = "Cancel";
            UILocalize.SuccessTitle = "Success";
            UILocalize.ErrorTitle = "Error";
        }
        private void FrmDuyetbai_Load(object sender, EventArgs e)
        {
            LoadBaiDang();

        }
        private void LoadBaiDang()
        {
            dtView.ClearAll();
            List<BsonDocument> dataBaiDang = nv.Chuaduyet();
            if (dataBaiDang.Count > 0)
            {
                // Load header name
                foreach (var header in dataBaiDang[0].Names)
                {
                    if (header != "ThoiGianDang")
                    {
                        if (header != "TrangThai")
                        {
                            dtView.Columns.Add(header, header);
                        }
                    }
                    else
                    {
                        continue;
                    }
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
                dtView.Columns[0].HeaderText = "ID";
                dtView.Columns[1].HeaderText = "Tiêu đề";
                dtView.Columns[2].HeaderText = "Loại nhà";
                dtView.Columns[3].HeaderText = "Diện tích";
                dtView.Columns[4].HeaderText = "Số phòng";
                dtView.Columns[5].HeaderText = "Giá";
                dtView.Columns[6].HeaderText = "Địa chỉ";
                dtView.Columns[7].HeaderText = "Hình ảnh";
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HinhAnh ha = new HinhAnh(txtHinhanh.Text);
            ha.Show();
        }

        private void btnTuchoi_Click(object sender, EventArgs e)
        {
            if (txtTieude.Text != "")
            {
                if (nv.DeleteBaiDang(txtId.Text))
                {
                    resetValues();
                    ShowSuccessNotifier("Thành công");
                }
                else
                {
                    ShowErrorNotifier("Thất bại");
                }
            }
            else
            {
                ShowErrorNotifier("Vui lòng chọn bài đăng trước");
            }
            LoadBaiDang();
        }

        private void dtView_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu có tồn tại trên 1 dòng
                if (dtView.Rows.Count > 1)
                {
                    // hiện dữ liệu khi dòng được chọn
                    txtId.Text = dtView.CurrentRow.Cells[0].Value.ToString();
                    txtTieude.Text = dtView.CurrentRow.Cells[1].Value.ToString();
                    cbLoainha.Text = dtView.CurrentRow.Cells[2].Value.ToString();
                    txtDientich.Text = dtView.CurrentRow.Cells[3].Value.ToString();
                    txtSophong.Text = dtView.CurrentRow.Cells[4].Value.ToString();
                    txtHinhanh.Text = dtView.CurrentRow.Cells[7].Value.ToString();
                    txtDiachi.Text = dtView.CurrentRow.Cells[6].Value.ToString();
                    txtGia.Text = dtView.CurrentRow.Cells[5].Value.ToString();
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

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (txtTieude.Text != "")
            {
                if (nv.Duyetbai(txtId.Text,FrmMain.mail))
                {
                    ShowSuccessNotifier("Thành công");
                    resetValues();
                }
                else
                {
                    ShowErrorNotifier("Thất bại");
                }
            }
            else
            {
                ShowErrorNotifier("Vui lòng chọn bài đăng trước");
            }
            LoadBaiDang();
        }
        void resetValues()
        {
            txtId.Text = "";
            txtTieude.Text = "";
            cbLoainha.Text = "";
            txtDientich.Text = "";
            txtSophong.Text = "";
            txtHinhanh.Text = "";
            txtDiachi.Text = "";
            txtGia.Text = "";
        }
    }
}
