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
using System.Collections;

namespace ProjectWpf
{
    /// <summary>
    /// Interaction logic for ReadyPlayers.xaml
    /// </summary>
    public partial class ReadyPlayers : Window
    {
        public ReadyPlayers()
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //add colours of categories 
            List<Color> Colours = new List<Color>();
            {
                Colours.Add(Color.FromRgb(255, 0, 242));
                Colours.Add(Color.FromRgb(9, 158, 104));
                Colours.Add(Color.FromRgb(12, 230, 237));
                Colours.Add(Color.FromRgb(235, 224, 14));
                Colours.Add(Color.FromRgb(240, 126, 12));
                Colours.Add(Color.FromRgb(177, 22, 219));
            };
            //Setting content of comboboxes
            CbUser1.ItemsSource = typeof(Colors).GetProperties();
            CbUser2.ItemsSource = typeof(Colors).GetProperties();
            CbUser3.ItemsSource = typeof(Colors).GetProperties();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}
