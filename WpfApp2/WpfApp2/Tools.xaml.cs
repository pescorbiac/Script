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
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour Tools.xaml
    /// </summary>
 
    public partial class Tools : Window
    {
   
        
        public Tools()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new WpfApp2.MainWindow();
            window.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
