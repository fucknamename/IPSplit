using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IPSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> iplist = new List<string>();
            string[] ips = txtsource.Text?.Trim().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (ips == null || ips.Length == 0)
            {
                return;
            }

            foreach (var iipp in ips)
            {
                if (string.IsNullOrEmpty(iipp) || iipp.Trim()?.Length == 0)
                {
                    continue;
                }

                var item = iipp.Trim();

                if (item.Contains("-"))
                {
                    int subip = 0;
                    var pairs = item.Split('-');
                    if (pairs != null && pairs.Length == 2 && ValidateIPAddress(pairs[0]) && ValidateNumber(pairs[1], out subip))
                    {
                        string startip = pairs[0];
                        string[] temp = startip.Split('.');
                        int startIdx = Convert.ToInt32(temp[temp.Length - 1]);
                        if (startIdx < subip)
                        {
                            for (var i = startIdx; i <= subip; i++)
                            {
                                iplist.Add(startip.Substring(0, startip.LastIndexOf('.') + 1) + i);
                            }
                        }
                    }
                }
                else if (ValidateIPAddress(item))
                {
                    iplist.Add(item);
                }
            }

            txtiplist.Text = string.Join("\r\n", iplist.ToArray());
        }

        public static bool ValidateNumber(string subip, out int ip)
        {
            bool result = int.TryParse(subip, out ip);
            return result && ip >= 0;
        }

        public static bool ValidateIPAddress(string ipAddress)
        {
            var items = ipAddress.Split('.');
            if (items.Length != 4)
            {
                return false;
            }

            int t, s = 0;

            for (var i = 0; i <= 3; i++)
            {
                if (int.TryParse(items[i], out t) && t >= 0)
                {
                    s++;
                }
            }

            return s == 4;
        }
    }
}
