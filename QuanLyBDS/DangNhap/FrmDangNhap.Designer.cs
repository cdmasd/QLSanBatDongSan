namespace QuanLyBDS
{
    partial class FrmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UIPanel = new Sunny.UI.UIPanel();
            picBackground = new PictureBox();
            PanelDangNhap = new Sunny.UI.UIPanel();
            label3 = new Label();
            btnLayma = new Sunny.UI.UIButton();
            txtXacthuc = new Sunny.UI.UITextBox();
            btnKhach = new Sunny.UI.UIButton();
            btnDangNhapre = new Sunny.UI.UILinkLabel();
            lb6re = new Sunny.UI.UILabel();
            btnRegister = new Sunny.UI.UIButton();
            txtPasswordre = new Sunny.UI.UITextBox();
            lb5re = new Label();
            txtSoDTre = new Sunny.UI.UITextBox();
            lb4re = new Label();
            txtHoTenre = new Sunny.UI.UITextBox();
            lb3re = new Label();
            txtEmailre = new Sunny.UI.UITextBox();
            lb2re = new Label();
            lb1re = new Sunny.UI.UILabel();
            btnTaoTaiKhoan = new Sunny.UI.UILinkLabel();
            uiLabel2 = new Sunny.UI.UILabel();
            btnLogin = new Sunny.UI.UIButton();
            btnForgotPassword = new Sunny.UI.UILinkLabel();
            chkRemember = new Sunny.UI.UICheckBox();
            txtPassword = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            label2 = new Label();
            label1 = new Label();
            uiLabel1 = new Sunny.UI.UILabel();
            UIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            PanelDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // UIPanel
            // 
            UIPanel.Controls.Add(picBackground);
            UIPanel.Dock = DockStyle.Left;
            UIPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UIPanel.Location = new Point(0, 0);
            UIPanel.Margin = new Padding(4, 5, 4, 5);
            UIPanel.MinimumSize = new Size(1, 1);
            UIPanel.Name = "UIPanel";
            UIPanel.Radius = 0;
            UIPanel.Size = new Size(484, 565);
            UIPanel.TabIndex = 0;
            UIPanel.Text = null;
            UIPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Image = Properties.Resources.building;
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(484, 565);
            picBackground.SizeMode = PictureBoxSizeMode.AutoSize;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // PanelDangNhap
            // 
            PanelDangNhap.Controls.Add(label3);
            PanelDangNhap.Controls.Add(btnLayma);
            PanelDangNhap.Controls.Add(txtXacthuc);
            PanelDangNhap.Controls.Add(btnKhach);
            PanelDangNhap.Controls.Add(btnDangNhapre);
            PanelDangNhap.Controls.Add(lb6re);
            PanelDangNhap.Controls.Add(btnRegister);
            PanelDangNhap.Controls.Add(txtPasswordre);
            PanelDangNhap.Controls.Add(lb5re);
            PanelDangNhap.Controls.Add(txtSoDTre);
            PanelDangNhap.Controls.Add(lb4re);
            PanelDangNhap.Controls.Add(txtHoTenre);
            PanelDangNhap.Controls.Add(lb3re);
            PanelDangNhap.Controls.Add(txtEmailre);
            PanelDangNhap.Controls.Add(lb2re);
            PanelDangNhap.Controls.Add(lb1re);
            PanelDangNhap.Controls.Add(btnTaoTaiKhoan);
            PanelDangNhap.Controls.Add(uiLabel2);
            PanelDangNhap.Controls.Add(btnLogin);
            PanelDangNhap.Controls.Add(btnForgotPassword);
            PanelDangNhap.Controls.Add(chkRemember);
            PanelDangNhap.Controls.Add(txtPassword);
            PanelDangNhap.Controls.Add(txtEmail);
            PanelDangNhap.Controls.Add(label2);
            PanelDangNhap.Controls.Add(label1);
            PanelDangNhap.Controls.Add(uiLabel1);
            PanelDangNhap.Dock = DockStyle.Fill;
            PanelDangNhap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PanelDangNhap.Location = new Point(484, 0);
            PanelDangNhap.Margin = new Padding(4, 5, 4, 5);
            PanelDangNhap.MinimumSize = new Size(1, 1);
            PanelDangNhap.Name = "PanelDangNhap";
            PanelDangNhap.Radius = 0;
            PanelDangNhap.Size = new Size(416, 565);
            PanelDangNhap.TabIndex = 1;
            PanelDangNhap.Text = null;
            PanelDangNhap.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 342);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 50;
            label3.Text = "Mã xác nhận :";
            // 
            // btnLayma
            // 
            btnLayma.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLayma.Location = new Point(260, 367);
            btnLayma.MinimumSize = new Size(1, 1);
            btnLayma.Name = "btnLayma";
            btnLayma.Size = new Size(100, 29);
            btnLayma.TabIndex = 49;
            btnLayma.Text = "Lấy mã";
            btnLayma.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtXacthuc
            // 
            txtXacthuc.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtXacthuc.Location = new Point(72, 367);
            txtXacthuc.Margin = new Padding(4, 5, 4, 5);
            txtXacthuc.MinimumSize = new Size(1, 16);
            txtXacthuc.Name = "txtXacthuc";
            txtXacthuc.Padding = new Padding(5);
            txtXacthuc.ShowText = false;
            txtXacthuc.Size = new Size(187, 29);
            txtXacthuc.TabIndex = 40;
            txtXacthuc.TextAlignment = ContentAlignment.MiddleLeft;
            txtXacthuc.Watermark = "";
            // 
            // btnKhach
            // 
            btnKhach.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhach.Location = new Point(159, 439);
            btnKhach.MinimumSize = new Size(1, 1);
            btnKhach.Name = "btnKhach";
            btnKhach.Size = new Size(116, 35);
            btnKhach.TabIndex = 46;
            btnKhach.Text = "Khách truy cập";
            btnKhach.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // btnDangNhapre
            // 
            btnDangNhapre.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            btnDangNhapre.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhapre.LinkBehavior = LinkBehavior.AlwaysUnderline;
            btnDangNhapre.Location = new Point(227, 497);
            btnDangNhapre.Name = "btnDangNhapre";
            btnDangNhapre.Size = new Size(96, 26);
            btnDangNhapre.TabIndex = 45;
            btnDangNhapre.TabStop = true;
            btnDangNhapre.Text = "Đăng nhập";
            btnDangNhapre.TextAlign = ContentAlignment.MiddleCenter;
            btnDangNhapre.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            btnDangNhapre.Click += btnDangNhapre_Click;
            // 
            // lb6re
            // 
            lb6re.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb6re.Location = new Point(102, 499);
            lb6re.Name = "lb6re";
            lb6re.Size = new Size(131, 23);
            lb6re.TabIndex = 44;
            lb6re.Text = "Đã có tài khoản ?";
            lb6re.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(159, 431);
            btnRegister.MinimumSize = new Size(1, 1);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 43;
            btnRegister.Text = "Đăng ký";
            btnRegister.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPasswordre
            // 
            txtPasswordre.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordre.Location = new Point(66, 307);
            txtPasswordre.Margin = new Padding(4, 5, 4, 5);
            txtPasswordre.MinimumSize = new Size(1, 16);
            txtPasswordre.Name = "txtPasswordre";
            txtPasswordre.Padding = new Padding(5);
            txtPasswordre.ShowText = false;
            txtPasswordre.Size = new Size(295, 29);
            txtPasswordre.TabIndex = 39;
            txtPasswordre.TextAlignment = ContentAlignment.MiddleLeft;
            txtPasswordre.Watermark = "";
            // 
            // lb5re
            // 
            lb5re.AutoSize = true;
            lb5re.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb5re.Location = new Point(66, 282);
            lb5re.Name = "lb5re";
            lb5re.Size = new Size(77, 19);
            lb5re.TabIndex = 41;
            lb5re.Text = "Mật khẩu :";
            // 
            // txtSoDTre
            // 
            txtSoDTre.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDTre.Location = new Point(66, 247);
            txtSoDTre.Margin = new Padding(4, 5, 4, 5);
            txtSoDTre.MinimumSize = new Size(1, 16);
            txtSoDTre.Name = "txtSoDTre";
            txtSoDTre.Padding = new Padding(5);
            txtSoDTre.ShowText = false;
            txtSoDTre.Size = new Size(295, 29);
            txtSoDTre.TabIndex = 38;
            txtSoDTre.TextAlignment = ContentAlignment.MiddleLeft;
            txtSoDTre.Watermark = "";
            // 
            // lb4re
            // 
            lb4re.AutoSize = true;
            lb4re.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb4re.Location = new Point(66, 223);
            lb4re.Name = "lb4re";
            lb4re.Size = new Size(102, 19);
            lb4re.TabIndex = 37;
            lb4re.Text = "Số điện thoại :";
            // 
            // txtHoTenre
            // 
            txtHoTenre.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTenre.Location = new Point(66, 187);
            txtHoTenre.Margin = new Padding(4, 5, 4, 5);
            txtHoTenre.MinimumSize = new Size(1, 16);
            txtHoTenre.Name = "txtHoTenre";
            txtHoTenre.Padding = new Padding(5);
            txtHoTenre.ShowText = false;
            txtHoTenre.Size = new Size(295, 29);
            txtHoTenre.TabIndex = 37;
            txtHoTenre.TextAlignment = ContentAlignment.MiddleLeft;
            txtHoTenre.Watermark = "";
            // 
            // lb3re
            // 
            lb3re.AutoSize = true;
            lb3re.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb3re.Location = new Point(66, 162);
            lb3re.Name = "lb3re";
            lb3re.Size = new Size(79, 19);
            lb3re.TabIndex = 38;
            lb3re.Text = "Họ và tên :";
            // 
            // txtEmailre
            // 
            txtEmailre.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailre.Location = new Point(66, 127);
            txtEmailre.Margin = new Padding(4, 5, 4, 5);
            txtEmailre.MinimumSize = new Size(1, 16);
            txtEmailre.Name = "txtEmailre";
            txtEmailre.Padding = new Padding(5);
            txtEmailre.ShowText = false;
            txtEmailre.Size = new Size(295, 29);
            txtEmailre.TabIndex = 36;
            txtEmailre.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmailre.Watermark = "";
            // 
            // lb2re
            // 
            lb2re.AutoSize = true;
            lb2re.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb2re.Location = new Point(66, 102);
            lb2re.Name = "lb2re";
            lb2re.Size = new Size(53, 19);
            lb2re.TabIndex = 35;
            lb2re.Text = "Email :";
            // 
            // lb1re
            // 
            lb1re.Font = new Font("Roboto Condensed", 23F, FontStyle.Bold, GraphicsUnit.Point);
            lb1re.Location = new Point(136, 38);
            lb1re.Name = "lb1re";
            lb1re.Size = new Size(171, 33);
            lb1re.TabIndex = 34;
            lb1re.Text = "Register";
            lb1re.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            btnTaoTaiKhoan.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaoTaiKhoan.LinkBehavior = LinkBehavior.AlwaysUnderline;
            btnTaoTaiKhoan.Location = new Point(239, 396);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(96, 26);
            btnTaoTaiKhoan.TabIndex = 33;
            btnTaoTaiKhoan.TabStop = true;
            btnTaoTaiKhoan.Text = "Tạo tài khoản";
            btnTaoTaiKhoan.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(102, 394);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(140, 23);
            uiLabel2.TabIndex = 32;
            uiLabel2.Text = "Chưa có tài khoản ?";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(167, 342);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 31;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            btnForgotPassword.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnForgotPassword.LinkBehavior = LinkBehavior.AlwaysUnderline;
            btnForgotPassword.Location = new Point(240, 291);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(121, 26);
            btnForgotPassword.TabIndex = 30;
            btnForgotPassword.TabStop = true;
            btnForgotPassword.Text = "Quên mật khẩu ?";
            btnForgotPassword.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            // 
            // chkRemember
            // 
            chkRemember.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkRemember.Location = new Point(66, 288);
            chkRemember.MinimumSize = new Size(1, 1);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(150, 29);
            chkRemember.TabIndex = 29;
            chkRemember.Text = "Ghi nhớ tài khoản";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(66, 247);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(295, 29);
            txtPassword.TabIndex = 28;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(67, 178);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(295, 29);
            txtEmail.TabIndex = 27;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 223);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 26;
            label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 154);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 25;
            label1.Text = "Email :";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Roboto Condensed", 23F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel1.Location = new Point(108, 48);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(227, 33);
            uiLabel1.TabIndex = 24;
            uiLabel1.Text = "Login To System";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmDangNhap
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(900, 565);
            Controls.Add(PanelDangNhap);
            Controls.Add(UIPanel);
            Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmDangNhap";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmDangNhap";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            UIPanel.ResumeLayout(false);
            UIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            PanelDangNhap.ResumeLayout(false);
            PanelDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel UIPanel;
        private PictureBox picBackground;
        private Sunny.UI.UIPanel PanelDangNhap;
        private Sunny.UI.UILinkLabel btnTaoTaiKhoan;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UILinkLabel btnForgotPassword;
        private Sunny.UI.UICheckBox chkRemember;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtEmail;
        private Label label2;
        private Label label1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILinkLabel btnDangNhapre;
        private Sunny.UI.UILabel lb6re;
        private Sunny.UI.UIButton btnRegister;
        private Sunny.UI.UITextBox txtPasswordre;
        private Label lb5re;
        private Sunny.UI.UITextBox txtSoDTre;
        private Label lb4re;
        private Sunny.UI.UITextBox txtHoTenre;
        private Label lb3re;
        private Sunny.UI.UITextBox txtEmailre;
        private Label lb2re;
        private Sunny.UI.UILabel lb1re;
        private Sunny.UI.UIButton btnKhach;
        private Sunny.UI.UIButton btnLayma;
        private Sunny.UI.UITextBox txtXacthuc;
        private Label label3;
    }
}