using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileWatcherUI
{
    /// <summary>
    /// Interaction logic for SelectDirectory.xaml
    /// </summary>
    public partial class SelectDirectory : Page
    {
        private string path = "";
        public SelectDirectory()
        {
            InitializeComponent();
        }

        private void StartMonitoring(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Inside Start to Monitor!");
            //string path = (string)SelectedDirectory.Content;
            //Console.WriteLine("Path forwarded:" + path.Substring(path.IndexOf(":")+ 1 ));
            Console.WriteLine("TBF:"  + path );
           MonitorDetails mDetails = new MonitorDetails(path);
           this.NavigationService.Navigate(mDetails);
        }

        private void ChooseDirectory(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            Console.WriteLine("Inside Choose Directory!");
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = "C:\\";

            DialogResult result = folderDialog.ShowDialog();
            if (result.ToString() == "OK")
            {
                SelectedDirectory.Content = "Selected Directory is :" + folderDialog.SelectedPath;
                path = folderDialog.SelectedPath;
            }

        }
    }
}
