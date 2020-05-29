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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace FileWatcherUI
{
    /// <summary>
    /// Interaction logic for MonitorDetails.xaml
    /// </summary>
    public partial class MonitorDetails : Page
    {
        private static string updates = "";
        private string path = "";
        private FileSystemWatcher watcher;

        public MonitorDetails(string path)
        {
            InitializeComponent();
            this.path = path;
           
          

        }

        private void BeginMonitoring(object sender, RoutedEventArgs e)
        {
            startWatching(path);
           
        }

        private void StopMonitoring(object sender, RoutedEventArgs e)
        {
            updates = "Dear User, \nI monitored the following changes " +
                        $"in directory {path.Substring(path.LastIndexOf("\\") + 1)} on {DateTime.Now}\nChanges: \n" + Updates.Text + "\n";
            Console.WriteLine(updates);
            watcher.EnableRaisingEvents = false;
            new Notification().SendMessage("YOUR NUMBER HERE!",updates);
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
        private  void startWatching(string dname)
        {


            Console.WriteLine(dname);
            
            try
            {
                watcher = new FileSystemWatcher(dname, "*.*");
                watcher.IncludeSubdirectories = true;
                watcher.NotifyFilter = NotifyFilters.LastAccess |
                                     NotifyFilters.LastWrite |
                                     NotifyFilters.FileName |
                                     NotifyFilters.DirectoryName |
                                     NotifyFilters.Attributes |
                                     NotifyFilters.Security |
                                     NotifyFilters.Size |
                                     NotifyFilters.CreationTime;

                watcher.Changed += onChanged;
                watcher.Deleted += onDeleted;
                watcher.Created += onCreated;
                watcher.Renamed += onRenamed;
                watcher.Error += onError;

                watcher.EnableRaisingEvents = true;
                Console.WriteLine("Reached here!Start Testing...");
            }
            catch (ArgumentException e)
            {
                throw new FileNotFoundException($"{dname} is not a directory!!", e);
            }
            
            

        }

        private  void onChanged(object src, FileSystemEventArgs e)
        {
            updates = "File: " + e.Name + " changed by " + Environment.UserName + " on " + DateTime.Now + "\n";
            this.Dispatcher.Invoke(() => {
                Updates.Text += updates;
            });
        }

        private  void onCreated(object src, FileSystemEventArgs e)
        {
            updates = "File: " + e.Name + " created by " + Environment.UserName + " on " + DateTime.Now + "\n";
            this.Dispatcher.Invoke(() => {
                Updates.Text += updates;
            });
        }

        private  void onDeleted(object src, FileSystemEventArgs e)
        {
            updates = "File: " + e.Name + " deleted by " + Environment.UserName + " on " + DateTime.Now + "\n";
            this.Dispatcher.Invoke(() => {
                Updates.Text += updates;
            });
        }


        private  void onRenamed(object source, RenamedEventArgs e)
        {
            updates = "File : " + e.OldName + " renamed to " + e.Name + " by " + Environment.UserName + " on " + DateTime.Now + "\n";
            this.Dispatcher.Invoke(() => {
                Updates.Text += updates;
            });

        }

        private  void onError(object source, ErrorEventArgs e)
        {
            Console.WriteLine("The FileSystemWatcher has detected an error while monitoring the current directory!");
            Console.WriteLine(e.GetException().GetType());
        }

      
    }
}
