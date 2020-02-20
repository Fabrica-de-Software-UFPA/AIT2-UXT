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

namespace AIT2_UXT.Screens
{
    /// <summary>
    /// Interaction logic for OpenProject.xaml
    /// </summary>
    public partial class OpenProject : Window
    {
        public OpenProject()
        {
            InitializeComponent();
        }

        private void Cmd_collect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Collect collect = new Collect();
            collect.Show();
            this.Close();
        }

        private void Win_openProject_Loaded(object sender, RoutedEventArgs e)
        {
            Cmd_collect.Caption = "Collect";
            Cmd_analyze.Caption = "Analyze";
            Cmd_export.Caption = "Export";
            Cmd_view.Caption = "Explore";
            this.Title = Txb_projectName.Text = App.currentProject.Name;
            Txb_projectDescription.Text = App.currentProject.Description;
            Txb_projectId.Text = App.currentProject.Id;
            Txt_path.Text = App.currentProjectPath;
            System.IO.FileInfo fileinfo = new System.IO.FileInfo(App.currentProjectPath);
            Txb_dateCreated.Text = "Creation: " + fileinfo.CreationTime.ToString("dd/MM/yyyy HH:mm:ss");
            Txb_dateModified.Text = "Modified: " + fileinfo.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss");
            Txb_samples.Text = App.currentProject.Samples.Count + " samples";
        }
    }
}
