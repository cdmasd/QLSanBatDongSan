using Sunny.UI;

namespace QuanLyBDS
{
    public partial class FrmMain : UIForm
    {
        public static bool session = false;
        public static string role;
        public FrmMain()
        {
            InitializeComponent();
            FrmDangNhap login = new FrmDangNhap();
            login.TopLevel = false;
            PanelMain.Controls.Add(login);
            login.Show();
        }
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
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
    }
}
