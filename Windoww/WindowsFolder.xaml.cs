using System;
using System.Collections.Generic;
using System.IO;
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

namespace Windoww
{
    /// <summary>
    /// Interaction logic for WindowsFolder.xaml
    /// </summary>
    public partial class WindowsFolder : Window
    {
        public WindowsFolder()
        {
            InitializeComponent();
        }

        string nameOfFolder = @"C:\Windows";

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            foreach (var file in Directory.EnumerateDirectories(nameOfFolder))
            {
                TreeViewItem viewItem = new TreeViewItem();
                viewItem.Header = file.Substring(file.LastIndexOf('\\') + 1);
                viewItem.Tag = file;
                FillTreeViews(viewItem, file);
                treeViewItem.Items.Add(viewItem);
            }
        }
        private void FillTreeViews(TreeViewItem parentItem, string path)
        {
            try
            {
                foreach (var str in Directory.EnumerateDirectories(path))
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Header = str.Substring(str.LastIndexOf('\\') + 1);
                    item.Tag = str;
                    item.FontWeight = FontWeights.Normal;
                    parentItem.Items.Add(item);
                    FillTreeViews(item, str);
                }
            }
            catch { }
        }
    }
}
