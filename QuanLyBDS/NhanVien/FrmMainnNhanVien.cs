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
    public partial class FrmMainnNhanVien : Form
    {
        public FrmMainnNhanVien()
        {
            InitializeComponent();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnKhachhang.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmQLKhachHang"))
            {
                FrmQLKhachHang kh = new FrmQLKhachHang();
                kh.TopLevel = false;
                panelNhanVien.Controls.Add(kh);
                kh.Show();
                kh.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmQLKhachHang");
            }
        }

        private void btnDuyetbai_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDuyetbai.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDuyetbai"))
            {
                FrmDuyetbai duyetbai = new FrmDuyetbai();
                duyetbai.TopLevel = false;
                panelNhanVien.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDuyetbai");
            }
        }

        private void btnDaduyet_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDaduyet.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDaduyet"))
            {
                FrmDaduyet daduyet = new FrmDaduyet();
                daduyet.TopLevel = false;
                panelNhanVien.Controls.Add(daduyet);
                daduyet.Show();
                daduyet.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDaduyet");
            }
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnHotro.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmHotro"))
            {
                FrmHotro ht = new FrmHotro();
                ht.TopLevel = false;
                panelNhanVien.Controls.Add(ht);
                ht.Show();
                ht.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmHotro");
            }
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDoimatkhau.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDoimatkhau"))
            {
                FrmDoimatkhau dmk = new FrmDoimatkhau();
                dmk.TopLevel = false;
                panelNhanVien.Controls.Add(dmk);
                dmk.Show();
                dmk.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDoimatkhau");
            }
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Quản lý bất động sản";
            FrmMain.session = 0;
            this.Close();
        }
        #region UI
        void ResetButton()
        {
            btnKhachhang.BackColor = SystemColors.Highlight;
            btnDuyetbai.BackColor = SystemColors.Highlight;
            btnDaduyet.BackColor = SystemColors.Highlight;
            btnHotro.BackColor = SystemColors.Highlight;
            btnDoimatkhau.BackColor = SystemColors.Highlight;
        }
        #endregion
        #region Active form
        // Kiểm tra form đã tồn tại trước khi mở
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // Show form lên trên cùng của form cha
        private void ActiveChildForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
                    break;
                }
            }
        }
        #endregion
    }
}
