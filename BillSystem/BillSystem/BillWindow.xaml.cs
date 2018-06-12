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
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BillSystem
{
    /// <summary>
    /// Interaction logic for BillWindow.xaml
    /// </summary>
    public partial class BillWindow : MetroWindow
    {
        public BillWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:54978/");



            client.DefaultRequestHeaders.Accept.Add(

               new MediaTypeWithQualityHeaderValue("application/json"));

           
           

           


        }

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
                mw.Show();
        }
    }
}
