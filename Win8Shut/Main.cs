using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win8Shut
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            RegistryKey UserSwitch = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\UserSwitch", true);
            UserSwitch.SetValue("Enabled", "1", RegistryValueKind.DWord);
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
