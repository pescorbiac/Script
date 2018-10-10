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
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Reflection;


namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public string Com = @"Powershell\dfs-access.ps1 ";

        String currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        


        public static int RunPowershellScript(string ps,string ar)
        {
            int errorLevel;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("powershell.exe", "-File " + ps +ar);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            errorLevel = process.ExitCode;
            process.Close();

            return errorLevel;
        }
        public MainWindow()
        {
            InitializeComponent();
        }


        private void OpenR_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(currentPath.Replace(@"bin\Debug", @"Powershell\AccessR.txt"));

        }

        private void OpenRW_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(currentPath.Replace(@"bin\Debug", @"Powershell\AccessRW.txt"));
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ListR.Items.Clear();
            ListRW.Items.Clear();

            //RunPowershellScript(Com,Dfsin.Text);
            String DFS = '"' + Dfsin.Text + '"';
            RunPowershellScript(currentPath.Replace(@"bin\Debug", Com),DFS);
            string UserR = System.IO.File.ReadAllText(currentPath.Replace(@"bin\Debug", @"Powershell\AccessR.txt"));
            string UserRW = System.IO.File.ReadAllText(currentPath.Replace(@"bin\Debug", @"Powershell\AccessRW.txt"));
            ListR.Items.Add(UserR);
            ListRW.Items.Add(UserRW);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ListR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
