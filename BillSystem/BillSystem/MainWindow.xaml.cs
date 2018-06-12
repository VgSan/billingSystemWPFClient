using MahApps.Metro.Controls;
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

namespace BillSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            BillWindow bill = new BillWindow();
            bill.Show();
            this.Close();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            BowserWindow bowser = new BowserWindow();
            bowser.Show();
            this.Close();

        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
