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
using System.Diagnostics;

namespace ProgramsPanel
{
    /// <summary>
    /// Interaction logic for Panel.xaml
    /// </summary>
    public partial class Panel : UserControl
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void visualStudio_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("D:/Archivos de Programa/Visual Studio/Common7/IDE/devenv.exe");
            App.Current.Shutdown();
        }

        private void androidStudio_Click(object sender, RoutedEventArgs e)
        {            
            Process.Start("D:/Archivos de Programa/Android Studio/bin/studio64.exe");
            App.Current.Shutdown();
        }

        private void VMware_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("D:/Archivos de Programa/VMware Workstation Pro/vmware.exe");
            App.Current.Shutdown();
        }        
    }
}
