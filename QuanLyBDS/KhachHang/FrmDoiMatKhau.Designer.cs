namespace QuanLyBDS.KhachHang
{
    partial class FrmDoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new Sunny.UI.UITextBox();
            txtMatkhauhientai = new Sunny.UI.UITextBox();
            txtMatkhaumoi = new Sunny.UI.UITextBox();
            btnDoimatkhau = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 150);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(234, 220);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(234, 290);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(234, 174);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(241, 29);
            txtEmail.TabIndex = 3;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // txtMatkhauhientai
            // 
            txtMatkhauhientai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhauhientai.Location = new Point(234, 244);
            txtMatkhauhientai.Margin = new Padding(4, 5, 4, 5);
            txtMatkhauhientai.MinimumSize = new Size(1, 16);
            txtMatkhauhientai.Name = "txtMatkhauhientai";
            txtMatkhauhientai.Padding = new Padding(5);
            txtMatkhauhientai.ShowText = false;
            txtMatkhauhientai.Size = new Size(241, 29);
            txtMatkhauhientai.TabIndex = 4;
            txtMatkhauhientai.TextAlignment = ContentAlignment.MiddleLeft;
            txtMatkhauhientai.Watermark = "";
            // 
            // txtMatkhaumoi
            // 
            txtMatkhaumoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhaumoi.Location = new Point(234, 314);
            txtMatkhaumoi.Margin = new Padding(4, 5, 4, 5);
            txtMatkhaumoi.MinimumSize = new Size(1, 16);
            txtMatkhaumoi.Name = "txtMatkhaumoi";
            txtMatkhaumoi.Padding = new Padding(5);
            txtMatkhaumoi.ShowText = false;
            txtMatkhaumoi.Size = new Size(241, 29);
            txtMatkhaumoi.TabIndex = 5;
            txtMatkhaumoi.TextAlignment = ContentAlignment.MiddleLeft;
            txtMatkhaumoi.Watermark = "";
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoimatkhau.Location = new Point(304, 354);
            btnDoimatkhau.MinimumSize = new Size(1, 1);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(100, 35);
            btnDoimatkhau.TabIndex = 6;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoimatkhau.Click += btnDoimatkhau_Click;
            // 
            // FrmDoiMatKhau
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(722, 565);
            Controls.Add(btnDoimatkhau);
            Controls.Add(txtMatkhaumoi);
            Controls.Add(txtMatkhauhientai);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDoiMatKhau";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmDoiMatKhau";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtMatkhauhientai;
        private Sunny.UI.UITextBox txtMatkhaumoi;
        private Sunny.UI.UIButton btnDoimatkhau;
    }
}