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
        List<Player> players = new List<Player>();
        Player player;
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
            MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            MainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TxtUsername1.Text != null || TxtUsername2.Text != null || TxtUsername3.Text != null)
            {
                if (!String.IsNullOrEmpty(TxtUsername1.Text))
                {
                    string username1 = TxtUsername1.Text;
                    Player player1 = new Player(TxtUsername1.Text, CbUser1.SelectedValue.ToString(), 0);
                    players.Add(player1);
                }
                if (!String.IsNullOrEmpty(TxtUsername2.Text))
                {
                    string username2 = TxtUsername2.Text;
                    Player player2 = new Player(TxtUsername2.Text, CbUser2.SelectedValue.ToString(), 0);
                    players.Add(player2);
                }
                if (!String.IsNullOrEmpty(TxtUsername3.Text))
                {
                    string username3 = TxtUsername3.Text; 
                    Player player3 = new Player(TxtUsername3.Text, CbUser3.SelectedValue.ToString(), 0);
                    players.Add(player3);
                }
            }

            if (players.Count > 0)
            {
                QuestionWindow QuestionWindow = new QuestionWindow();
                QuestionWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                QuestionWindow.DataContext = this;
                QuestionWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gelieve eerst minstens 1 speler te kiezen");
            }
        }
    }
}
