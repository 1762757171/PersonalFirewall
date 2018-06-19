using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;

namespace PersonalFirewall
{
    /// <summary>
    /// AddRuleWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddRuleWindow : Window
    {
        private MainWindow mainWindow;
        public AddRuleWindow(MainWindow window)
        {
            InitializeComponent();
            mainWindow = window;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!IsValidIPAddress(tbIP.Text))
            {
                MessageBox.Show("请输入合法IP地址！");
                return;
            }
            if (!IsValidPort(tbPortTargetStart.Text) || !IsValidPort(tbPortTargetEnd.Text))
            {
                MessageBox.Show("请输入合法端口！");
                return;
            }
            FilterRule filterRule = new FilterRule(tbIP.Text, int.Parse(tbPortTargetStart.Text), int.Parse(tbPortTargetEnd.Text), int.Parse(tbPortSelfStart.Text), int.Parse(tbPortSelfEnd.Text), cbProtocol.Text, cbDirection.Text);
            mainWindow.AddRule(filterRule);
            this.Close();
            return;
        }

        private bool IsValidIPAddress(string ipstr)
        {
            try
            {
                IPAddress.Parse(ipstr);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private bool IsValidPort(string portstr)
        {
            try
            {
                int.Parse(portstr);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
