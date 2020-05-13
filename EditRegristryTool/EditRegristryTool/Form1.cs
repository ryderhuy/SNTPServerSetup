using Microsoft.Win32;
using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditRegristryTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (firewallstatus() == "ON")
            {
                btnDisableFirewall.Text = "Disable Firewall";
            }else{
                btnDisableFirewall.Text = "Enable Firewall";
            }
            lblFirewallStatus.Text = "FirewallStatus:" + firewallstatus();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrySecurity rs = new RegistrySecurity(); // it is right string for this code

            string currentUserStr = Environment.UserDomainName + "\\" + Environment.UserName;
            rs.AddAccessRule(new RegistryAccessRule(currentUserStr, RegistryRights.WriteKey | RegistryRights.ReadKey | RegistryRights.Delete | RegistryRights.FullControl, AccessControlType.Allow));
            try
            {
                //HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\W32Time\TimeProviders\NtpServer
                RegistryKey keyLocalMachineNtpServer = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\W32Time\TimeProviders\NtpServer", true);
                //update key LocalMachine NtpServer Enabled =1
                keyLocalMachineNtpServer.SetValue("Enabled", 1);
                keyLocalMachineNtpServer.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            try
            {
                //HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\W32Time\Parameters\Type
                RegistryKey keyLocalMachineParameters = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\w32time\Parameters", true);
                //update key LocalMachine Parameters Type = NTP
                keyLocalMachineParameters.SetValue("Type", "NTP");

                //update key LocalMachine Parameters NtpServer = time.windows.com,0x9
                keyLocalMachineParameters.SetValue("NtpServer", "time.windows.com,0x9");
                keyLocalMachineParameters.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            try
            {
                //HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\W32Time\Config\AnnounceFlags
                RegistryKey keyLocalMachineConfig = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\W32Time\Config", true);
                //update key LocalMachine Config AnnounceFlags =5
                keyLocalMachineConfig.SetValue("AnnounceFlags", 5);
                keyLocalMachineConfig.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            try
            {
                //HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\W32Time\
                RegistryKey keyLocalMachineW32 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\W32Time", true);
                //update key LocalMachine W32time start = 2 //start automatic
                keyLocalMachineW32.SetValue("Start", 2);
                keyLocalMachineW32.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Registry was updated...");
            button1.Enabled = false;
        }
        private static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public void ExecuteCommandSync(object command)
        {
            var proc1 = new ProcessStartInfo();

            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + command;
            proc1.WindowStyle = ProcessWindowStyle.Normal;
            proc1.ErrorDialog = true;
            Process.Start(proc1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stop w32time
            string stopW32timeCommand = "net stop w32time";
            ExecuteCommandSync(stopW32timeCommand);
            DialogResult result = MessageBox.Show("Turned off W32Time. Do you want to restart?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //start w32time
                string startW32timeCommand = "net start w32time";
                ExecuteCommandSync(startW32timeCommand);
                MessageBox.Show("Restart W32Time successfully...");
                button2.Enabled = false;
            }
            else if (result == DialogResult.No)
            {
                //...
            }


        }
        //public void SetDalayedAutoStart(string machineName, string serviceName)
        //{
        //    //machineName = Environment.MachineName.ToString();
        //    //serviceName = "Windows Time";
        //    //using (var regKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName))
        //    //{
        //    //    using (RegistryKey serviceKey = regKey.OpenSubKey(@"System\CurrentControlSet\Services\" + serviceName, true))
        //    //    {
        //    //        serviceKey.SetValue("DelayedAutostart", 1, RegistryValueKind.DWord);
        //    //    }
        //    //}
        //}
        public void SetDalayedAutoStart(string machineName, string serviceName)
        {
            //machineName = Environment.MachineName.ToString();
            //serviceName = "Windows Time";
            //using (var regKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName))
            //{
            //    using (RegistryKey serviceKey = regKey.OpenSubKey(@"System\CurrentControlSet\Services\" + serviceName, true))
            //    {
            //        serviceKey.SetValue("DelayedAutostart", 1, RegistryValueKind.DWord);
            //    }
            //}
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            var machineName = Environment.MachineName.ToString();
            var serviceName = "Windows Time";
            using (var regKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName))
            {
                using (RegistryKey serviceKey = regKey.OpenSubKey(@"System\CurrentControlSet\Services\" + serviceName, true))
                {
                    serviceKey.SetValue("DelayedAutostart", 1, RegistryValueKind.DWord);
                }
            }
        }
        //disable firewall
        private void btnDisableFirewall_Click(object sender, EventArgs e)
        {
            string firewallStatus = firewallstatus();
            if (firewallStatus == "ON")
            {
                ExecuteCommandSync("Netsh advfirewall set allprofile state off");
                btnDisableFirewall.Text = "Enable Firewall";
                MessageBox.Show("Firewall was turn off...");
            }
            else
            {
                ExecuteCommandSync("Netsh advfirewall set allprofile state on");
                btnDisableFirewall.Text = "Disable Firewall";
                MessageBox.Show("Firewall was turn on...");
            }
        }
        public string firewallstatus()
        {
            INetFwMgr manager = FirewallManager();
            bool isFirewallEnabled = manager.LocalPolicy.CurrentProfile.FirewallEnabled;
            if (isFirewallEnabled)
                return "ON";
            else
                return "OFF";
        }
        private const string firewallid = "{304CE942-6E39-40D8-943A-B913C40C9CD4}";
        private static NetFwTypeLib.INetFwMgr FirewallManager()
        {
            Type objectType = Type.GetTypeFromCLSID(new Guid(firewallid));
            return Activator.CreateInstance(objectType) as NetFwTypeLib.INetFwMgr;
        }
        private void btnCreateInbound_Click(object sender, EventArgs e)
        {
            FormCreateInbound formCreateInbound = new FormCreateInbound();
            formCreateInbound.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
