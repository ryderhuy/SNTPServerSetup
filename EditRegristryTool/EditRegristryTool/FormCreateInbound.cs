using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditRegristryTool
{
    public partial class FormCreateInbound : Form
    {
        private const string firewallid = "{304CE942-6E39-40D8-943A-B913C40C9CD4}";
        private string hostName = Dns.GetHostName(); // Retrive the Name of HOST  

        public FormCreateInbound()
        {
            InitializeComponent();
            lblFirewallStatus.Text = "FirewallStatus:" + firewallstatus();
            txtTypeRules.Text = "Inbound";
            txtTypeRules.Enabled = false;
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            txtIP.Text = myIP;
            txtIP.Enabled = false;
            AddRule();
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
        private static NetFwTypeLib.INetFwMgr FirewallManager()
        {
            Type objectType = Type.GetTypeFromCLSID(new Guid(firewallid));
            return Activator.CreateInstance(objectType) as NetFwTypeLib.INetFwMgr;
        }
        private INetFwRule fwInstance()
        {
            try
            {
                INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                return firewallRule;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.ToString());
                return null;
            }
        }

        private void btnAddFilter_Click_1(object sender, EventArgs e)
        {
            try
            {
                INetFwRule firewallRule = fwInstance();

                firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                firewallRule.Name = txtName.Text.ToString();
                firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                firewallRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                firewallRule.RemotePorts = txtPort.Text;
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                firewallRule.RemoteAddresses = myIP;
                firewallRule.Enabled = true;
                firewallRule.InterfaceTypes = "All";
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(firewallRule);

                cmdRules.Items.Add(txtName.Text);
                cmdRules.SelectedIndex = 0;

                using (FileStream fs = new FileStream("firewallrule.txt", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(txtName.Text + "|");
                }


                MessageBox.Show("Rule Added Sucessfully ...");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.ToString());
            }
        }

        private void AddRule()
        {
            //try
            //{
            //    string snamelist = File.ReadAllText("firewallrule.txt");
            //    string[] sFwrule = snamelist.Split('|');
            //    if (sFwrule[0] != String.Empty)
            //    {
            //        for (int i = 0; i < sFwrule.Length; i++)
            //        {
            //            cmdRules.Items.Add(sFwrule[i]);
            //        }
            //    }
            //    cmdRules.SelectedIndex = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Exception:" + ex.ToString());
            //}
        }
    }
}
