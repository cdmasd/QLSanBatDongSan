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
    public partial class HinhAnh : UIForm
    {
        string imgAddress;
        public HinhAnh(string imgAddress)
        {
            InitializeComponent();
            this.imgAddress = imgAddress;
            string saveDirectory = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
            pic.Image = Image.FromFile(saveDirectory + imgAddress);
        }
    }
}
