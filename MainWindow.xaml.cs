using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalFirewall
{

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string configPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"\\PersonalFirewall\\v1_1\\Filter.Rules";
        public MainWindow()
        {
            InitializeComponent();
            var view = new GridView();
            view.Columns.Add(new GridViewColumn { Header = "IP地址", Width = lvRules.Width / 5, DisplayMemberBinding = new Binding("IP") });
            view.Columns.Add(new GridViewColumn { Header = "对方端口号", Width = lvRules.Width / 5, DisplayMemberBinding = new Binding("PortTarget") });
            view.Columns.Add(new GridViewColumn { Header = "己方端口号", Width = lvRules.Width / 5, DisplayMemberBinding = new Binding("PortSelf") });
            view.Columns.Add(new GridViewColumn { Header = "协议", Width = lvRules.Width / 5, DisplayMemberBinding = new Binding("Protocol") });
            view.Columns.Add(new GridViewColumn { Header = "传输方向", Width = lvRules.Width / 5, DisplayMemberBinding = new Binding("Direction") });
            lvRules.View = view;
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PersonalFirewall\\v1_1\\");
            FileStream fileStream = new FileStream(configPath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            FilterRule filterRule;
            String line;
            while((line = streamReader.ReadLine()) != null)
            {
                var strs = line.Split('\t');
                filterRule.IP = strs[0];
                filterRule.PortTargetStart = int.Parse(strs[1]);
                filterRule.PortTargetEnd = int.Parse(strs[2]);
                filterRule.PortSelfStart = int.Parse(strs[3]);
                filterRule.PortSelfEnd = int.Parse(strs[4]);
                filterRule.Protocol = strs[5];
                filterRule.Direction = strs[6];
                filterRules.Add(filterRule);
            }
            streamReader.Close();
            fileStream.Close();
            RefreshListViewNFilterFile();
        }

        private List<FilterRule> filterRules = new List<FilterRule>();

        public void AddRule(FilterRule filterRule)
        {
            filterRules.Add(filterRule);
            RefreshListViewNFilterFile();
        }

        private void btnAddRule_Click(object sender, RoutedEventArgs e)
        {
            AddRuleWindow addRuleWindow = new AddRuleWindow(this);
            addRuleWindow.ShowDialog();
        }

        private void RefreshListViewNFilterFile()
        {
            lvRules.Items.Clear();
            FileStream fileStream = new FileStream(configPath, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            foreach(FilterRule rule in filterRules)
            {
                lvRules.Items.Add(new { rule.IP, PortTarget = rule.PortTargetStart.ToString() + "To" + rule.PortTargetEnd.ToString(), PortSelf = rule.PortSelfStart.ToString() + "To" + rule.PortSelfEnd.ToString(), rule.Protocol, rule.Direction });
                streamWriter.WriteLine(rule.IP + "\t" + rule.PortTargetStart.ToString() + "\t" + rule.PortTargetEnd.ToString() + "\t" + rule.PortSelfStart.ToString() + "\t" + rule.PortSelfEnd.ToString() + "\t" + rule.Protocol + "\t" + rule.Direction);
            }
            streamWriter.Close();
            fileStream.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (btnStopFilter.IsEnabled == true)
            {
                FireWall.StopFilter();
            }
        }

        private void btnStartFilter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("第17组开始过滤！");
            FireWall.StartFilter();
            btnAddRule.IsEnabled = false;
            btnDeleteRule.IsEnabled = false;
            btnStartFilter.IsEnabled = false;
            btnStopFilter.IsEnabled = true;
        }

        private void btnStopFilter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("第17组停止过滤！");
            FireWall.StopFilter();
            btnAddRule.IsEnabled = true;
            btnDeleteRule.IsEnabled = true;
            btnStartFilter.IsEnabled = true;
            btnStopFilter.IsEnabled = false;
        }

        private void btnDeleteRule_Click(object sender, RoutedEventArgs e)
        {
            if(lvRules.SelectedIndex == -1)
            {
                return;
            }
            filterRules.RemoveAt(lvRules.SelectedIndex);
            RefreshListViewNFilterFile();
        }
        
    }
}
