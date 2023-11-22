using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.Admin
{
    public partial class FrmMainnAdmin : Form
    {
        public FrmMainnAdmin()
        {
            InitializeComponent();
        }
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnNhanvien.BackColor = SystemColors.ActiveCaption;
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnKhachhang.BackColor = SystemColors.ActiveCaption;
        }

        private void btnDuyetbai_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDuyetbai.BackColor = SystemColors.ActiveCaption;
        }

        private void btnDaduyet_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDaduyet.BackColor = SystemColors.ActiveCaption;
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnHotro.BackColor = SystemColors.ActiveCaption;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnThongke.BackColor = SystemColors.ActiveCaption;
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDoimatkhau.BackColor = SystemColors.ActiveCaption;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {

        }
        #region UI
        void ResetButton()
        {
            btnNhanvien.BackColor = SystemColors.Highlight;
            btnKhachhang.BackColor = SystemColors.Highlight;
            btnDuyetbai.BackColor = SystemColors.Highlight;
            btnDaduyet.BackColor = SystemColors.Highlight;
            btnHotro.BackColor = SystemColors.Highlight;
            btnDoimatkhau.BackColor = SystemColors.Highlight;
            btnThongke.BackColor = SystemColors.Highlight;
        }
        #endregion
    }
}
