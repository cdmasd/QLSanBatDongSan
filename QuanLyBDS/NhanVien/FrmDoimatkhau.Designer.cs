namespace QuanLyBDS.NhanVien
{
    partial class FrmDoimatkhau
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
            btnDoimatkhau = new Sunny.UI.UIButton();
            txtMatkhaumoi = new Sunny.UI.UITextBox();
            txtMatkhauhientai = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoimatkhau.Location = new Point(311, 367);
            btnDoimatkhau.MinimumSize = new Size(1, 1);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(100, 35);
            btnDoimatkhau.TabIndex = 13;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtMatkhaumoi
            // 
            txtMatkhaumoi.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhaumoi.Location = new Point(241, 327);
            txtMatkhaumoi.Margin = new Padding(4, 5, 4, 5);
            txtMatkhaumoi.MinimumSize = new Size(1, 16);
            txtMatkhaumoi.Name = "txtMatkhaumoi";
            txtMatkhaumoi.Padding = new Padding(5);
            txtMatkhaumoi.ShowText = false;
            txtMatkhaumoi.Size = new Size(241, 29);
            txtMatkhaumoi.TabIndex = 12;
            txtMatkhaumoi.TextAlignment = ContentAlignment.MiddleLeft;
            txtMatkhaumoi.Watermark = "";
            // 
            // txtMatkhauhientai
            // 
            txtMatkhauhientai.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhauhientai.Location = new Point(241, 257);
            txtMatkhauhientai.Margin = new Padding(4, 5, 4, 5);
            txtMatkhauhientai.MinimumSize = new Size(1, 16);
            txtMatkhauhientai.Name = "txtMatkhauhientai";
            txtMatkhauhientai.Padding = new Padding(5);
            txtMatkhauhientai.ShowText = false;
            txtMatkhauhientai.Size = new Size(241, 29);
            txtMatkhauhientai.TabIndex = 11;
            txtMatkhauhientai.TextAlignment = ContentAlignment.MiddleLeft;
            txtMatkhauhientai.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(241, 187);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(241, 29);
            txtEmail.TabIndex = 10;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(241, 303);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(241, 233);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 163);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // FrmDoimatkhau
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
            Name = "FrmDoimatkhau";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmDoimatkhau";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnDoimatkhau;
        private Sunny.UI.UITextBox txtMatkhaumoi;
        private Sunny.UI.UITextBox txtMatkhauhientai;
        private Sunny.UI.UITextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}