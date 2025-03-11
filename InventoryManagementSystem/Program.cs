using System;
using System.Windows.Forms;

namespace InventoryManagementSystem // Match your namespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main()); // Starts with MainForm
        }
    }
}