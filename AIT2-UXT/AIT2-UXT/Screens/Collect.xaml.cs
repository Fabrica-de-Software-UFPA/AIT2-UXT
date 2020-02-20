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
    /// Interaction logic for Collect.xaml
    /// </summary>
    public partial class Collect : Window
    {
        public Collect()
        {
            InitializeComponent();
        }

        private void Win_collect_Loaded(object sender, RoutedEventArgs e)
        {   
            //STOP 255,25,25
            //START 25,255,90
            Cmd_fire.IsSmall = true;
            Cmd_fire.SetBackground(Color.FromRgb(255, 25, 25));
            Cmd_fire.Caption = "STOP";

            Cmd_panel.IsSmall = true;
            Cmd_panel.Caption = "Panel";

            Cmd_apacheExplore.IsSmall = true;
            Cmd_apacheExplore.Caption = "Explore";

            Cmd_firePhp.IsSmall = true;
            Cmd_firePhp.SetBackground(Color.FromRgb(255, 25, 25));
            Cmd_firePhp.Caption = "STOP";

            Cmd_panelPhp.IsSmall = true;
            Cmd_panelPhp.Caption = "php.ini";

            Cmd_phpExplore.IsSmall = true;
            Cmd_phpExplore.Caption = "Explore";

            Cmd_appOpen.IsSmall = true;
            Cmd_appOpen.Caption = "UNINSTALL";
            Cmd_appOpen.SetBackground(Color.FromRgb(255, 25, 25));

            Cmd_appModify.IsSmall = true;
            Cmd_appModify.Caption = "Modify";

            Cmd_appExplore.IsSmall = true;
            Cmd_appExplore.Caption = "Explore";

            /*--------------*/
            Cmd_fireChrome .IsSmall = true;
            Cmd_fireChrome.SetBackground(Color.FromRgb(255, 25, 25));
            Cmd_fireChrome.Caption = "STOP";

            Cmd_clear.IsSmall = true;
            Cmd_clear.Caption = "Clear";

            Cmd_chromeExplore.IsSmall = true;
            Cmd_chromeExplore.Caption = "Explore";

            Cmd_fireCalibra.IsSmall = true;
            Cmd_fireCalibra.SetBackground(Color.FromRgb(25, 255, 90));
            Cmd_fireCalibra.Caption = "INSTALL";

            Cmd_calibraModify.IsSmall = true;
            Cmd_calibraModify.Caption = "Modify";

            Cmd_calibraExplore.IsSmall = true;
            Cmd_calibraExplore.Caption = "Explore";

            Cmd_fireClient.IsSmall = true;
            Cmd_fireClient.SetBackground(Color.FromRgb(255, 25, 25));
            Cmd_fireClient.Caption = "UNISTALL";

            Cmd_clientModify .IsSmall = true;
            Cmd_clientModify.Caption = "Modify";

            Cmd_clientExplore.IsSmall = true;
            Cmd_clientExplore.Caption = "Explore";

            Cmd_done.IsSmall = true;
            Cmd_done.Caption = "DONE!";
            Cmd_done.SetBackground(Color.FromRgb(25, 143, 255));

                        Cmd_explore.IsSmall = true;
            Cmd_explore.Caption = "Explore";

            Cmd_move.IsSmall = true;
            Cmd_move.Caption = "Move";
            Cmd_move.IsEnabled = false;

            Cmd_cancel.IsSmall = true;
            Cmd_cancel.Caption = "Cancel";
            Cmd_cancel.SetBackground(Color.FromRgb(255, 25, 25));
        }
    }
}
