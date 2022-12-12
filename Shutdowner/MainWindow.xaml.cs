using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Shutdowner
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Sekundy.Text == string.Empty)
                {
                    int minuty = int.Parse(Minuty.Text);
                    Process.Start("shutdown", $"/s /t {minuty*60}");
                }
                else if (Minuty.Text == string.Empty)
                {
                    int sekundy = int.Parse(Sekundy.Text);
                    Process.Start("shutdown", $"/s /t {sekundy}");
                }
                else
                {
                    int minuty = int.Parse(Minuty.Text);
                    int sekundy = int.Parse(Sekundy.Text);
                    int pocetSekund = sekundy + (minuty * 60);
                    Process.Start("shutdown", $"/s /t {pocetSekund}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/a");
        }
    }
}
