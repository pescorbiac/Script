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


namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string toto = "1234";
        public string Com = @"C:\Users\pescorbiac\source\repos\WpfApp2\WpfApp2\Powershell\test.ps1 ";


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

        }

        private void OpenRW_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ListR.Items.Clear();
            ListRW.Items.Clear();

            RunPowershellScript(Com,Dfsin.Text);

            string UserR = System.IO.File.ReadAllText(@"C:\Temp\Projet\tata.txt");
            string UserRW = System.IO.File.ReadAllText(@"C:\Users\pescorbiac\source\repos\WpfApp2\WpfApp2\Powershell\toto.txt");
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
    }
}
