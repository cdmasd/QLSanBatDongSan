namespace QuanLyBDS.KhachHang
{
    partial class FrmHoTro
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
            txtHotro = new Sunny.UI.UITextBox();
            btnGuiyeucau = new Sunny.UI.UIButton();
            txtSodt = new Sunny.UI.UITextBox();
            label3 = new Label();
            txtChitiethotro = new Sunny.UI.UITextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 0;
            label1.Text = "Vấn đề cần hỗ trợ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(238, 19);
            label2.TabIndex = 1;
            label2.Text = "Mô tả chi tiết về vấn đề cần hỗ trợ :";
            // 
            // txtHotro
            // 
            txtHotro.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHotro.Location = new Point(16, 38);
            txtHotro.Margin = new Padding(4, 5, 4, 5);
            txtHotro.MinimumSize = new Size(1, 16);
            txtHotro.Name = "txtHotro";
            txtHotro.Padding = new Padding(5);
            txtHotro.ShowText = false;
            txtHotro.Size = new Size(238, 29);
            txtHotro.TabIndex = 2;
            txtHotro.TextAlignment = ContentAlignment.MiddleLeft;
            txtHotro.Watermark = "";
            // 
            // btnGuiyeucau
            // 
            btnGuiyeucau.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuiyeucau.Location = new Point(610, 518);
            btnGuiyeucau.MinimumSize = new Size(1, 1);
            btnGuiyeucau.Name = "btnGuiyeucau";
            btnGuiyeucau.Size = new Size(100, 35);
            btnGuiyeucau.TabIndex = 4;
            btnGuiyeucau.Text = "Gửi yêu cầu";
            btnGuiyeucau.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtSodt
            // 
            txtSodt.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodt.Location = new Point(471, 38);
            txtSodt.Margin = new Padding(4, 5, 4, 5);
            txtSodt.MinimumSize = new Size(1, 16);
            txtSodt.Name = "txtSodt";
            txtSodt.Padding = new Padding(5);
            txtSodt.ShowText = false;
            txtSodt.Size = new Size(238, 29);
            txtSodt.TabIndex = 4;
            txtSodt.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodt.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(471, 9);
            label3.Name = "label3";
            label3.Size = new Size(192, 19);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại liên hệ hỗ trợ :";
            // 
            // txtChitiethotro
            // 
            txtChitiethotro.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChitiethotro.Location = new Point(16, 101);
            txtChitiethotro.Margin = new Padding(4, 5, 4, 5);
            txtChitiethotro.MinimumSize = new Size(1, 16);
            txtChitiethotro.Multiline = true;
            txtChitiethotro.Name = "txtChitiethotro";
            txtChitiethotro.Padding = new Padding(5);
            txtChitiethotro.ShowText = false;
            txtChitiethotro.Size = new Size(693, 409);
            txtChitiethotro.TabIndex = 5;
            txtChitiethotro.TextAlignment = ContentAlignment.MiddleLeft;
            txtChitiethotro.Watermark = "";
            // 
            // FrmHoTro
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(722, 565);
            Controls.Add(txtChitiethotro);
            Controls.Add(txtSodt);
            Controls.Add(label3);
            Controls.Add(btnGuiyeucau);
            Controls.Add(txtHotro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmHoTro";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmHoTro";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Sunny.UI.UITextBox txtHotro;
        private Sunny.UI.UIButton btnGuiyeucau;
        private Sunny.UI.UITextBox txtSodt;
        private Label label3;
        private Sunny.UI.UITextBox txtChitiethotro;
    }
}