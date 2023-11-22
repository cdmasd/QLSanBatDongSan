namespace QuanLyBDS
{
    partial class FrmMain
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
            PanelMain = new Sunny.UI.UIPanel();
            SuspendLayout();
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PanelMain.Location = new Point(0, 35);
            PanelMain.Margin = new Padding(4, 5, 4, 5);
            PanelMain.MinimumSize = new Size(1, 1);
            PanelMain.Name = "PanelMain";
            PanelMain.Radius = 0;
            PanelMain.Size = new Size(1000, 565);
            PanelMain.Style = Sunny.UI.UIStyle.Custom;
            PanelMain.TabIndex = 0;
            PanelMain.Text = null;
            PanelMain.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 600);
            Controls.Add(PanelMain);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 600);
            Name = "FrmMain";
            ShowRadius = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "Quản Lý Sàn Bất Động Sản";
            TitleColor = SystemColors.Highlight;
            TitleFont = new Font("Roboto Condensed", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel PanelMain;
    }
}