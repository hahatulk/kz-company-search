using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace CompanyHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        private void InputClearButton_Click(object sender, RoutedEventArgs e)
        {
            search_input.Text = "";
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.OpenHeadHunter();
            this.OpenDoubleGis();
        }
        
        private void HHRUButton_Click(object sender, RoutedEventArgs e)
        {
            this.OpenHeadHunter();
        }

        private void DoubleGisButton_Click(object sender, RoutedEventArgs e)
        {
            this.OpenDoubleGis();
        }

        private void StatGovButton_Click(object sender, RoutedEventArgs e)
        {
            this.OpenKZGOV();
        }

        private void OpenHeadHunter()
        {
            string text = search_input.Text;
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.kz/search?q=site:hh.kz " + text,
                UseShellExecute = true
            });
        }

        private void OpenDoubleGis()
        {
            string text = search_input.Text;
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.kz/search?q=site:2gis.kz " + text,
                UseShellExecute = true
            });
        }
        
        private void OpenKZGOV()
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://stat.gov.kz/jur-search/bin",
                UseShellExecute = true
            });
        }
    }
}
