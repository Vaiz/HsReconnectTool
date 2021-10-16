using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFirewallHelper;

namespace UtilLib
{
    public class Firewall
    {
        static readonly string RuleName = "HsReconnectTool";
        IFirewall inst;
        IFirewallRule rule;

        private Firewall(IFirewall _inst, IFirewallRule _rule)
        {
            inst = _inst;
            rule = _rule;
            Console.WriteLine("Firewall instance has been created");
        }
        public void EnableRule()
        {
            Console.WriteLine("Turning firewall rule On");
            rule.IsEnable = true;
        }
        public void DisableRule()
        {
            Console.WriteLine("Turning firewall rule Off");
            rule.IsEnable = false;
        }

        public static Firewall TryCreate(string exePath)
        {
            if (!FirewallManager.IsServiceRunning)
            {
                MessageBox.Show(String.Format("Windows firewall service is not running"));
                return null;
            }

            IFirewall inst;
            if (!FirewallManager.TryGetInstance(out inst))
            {
                MessageBox.Show(String.Format("Cannot get windows firewall service instance"));
                return null;
            }

            var rule = inst.Rules.FirstOrDefault(r => r.Name == RuleName);
            if (rule == null)
            {
                rule = CreateRule(inst, exePath);
                Console.WriteLine("Firewall rule has been created: {0}", rule);
            }
            else
            {
                Console.WriteLine("Firewall rule already exists: {0}", rule);
            }

            return new Firewall(inst, rule);
        }
        static IFirewallRule CreateRule(IFirewall inst, string path)
        {
            var rule = inst.CreateApplicationRule(RuleName, FirewallAction.Block, path);
            rule.Direction = FirewallDirection.Outbound;
            rule.IsEnable = false;
            inst.Rules.Add(rule);
            return rule;
        }

    }
}
