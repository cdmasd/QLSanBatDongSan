using QuanLyBDS.Admin;
using QuanLyBDS.Guest;
using QuanLyBDS.KhachHang;
using QuanLyBDS.NhanVien;

namespace QuanLyBDS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}