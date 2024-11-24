using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace changeBatteryStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string powerCfg
        {
            get { return "powercfg.exe"; }
        }
        private void Eco_Click(object sender, EventArgs e)
        {
            Change(powerCfg, "/setactive a1841308-3541-4fab-bc81-f71556f20b4a");
        }
        private void Balance_Click(object sender, EventArgs e)
        {
            Change(powerCfg, "/setactive 381b4222-f694-41f0-9685-ff5bb260df2e");
        }
        private void Extreme_Click(object sender, EventArgs e)
        {
            Change(powerCfg, "/setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
        }
        private void Change(string powercfg, string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = powercfg,
                Arguments = command,
                UseShellExecute = true,
                Verb = "runas"
            };
            Process.Start(processInfo);
        }
    }
}


