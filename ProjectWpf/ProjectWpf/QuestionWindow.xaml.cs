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
using System.Data.SqlClient;
using System.IO;


namespace ProjectWpf
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class QuestionWindow : Window
    {
        List<Player> players = new List<Player>();
        public QuestionWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            selectUsers();

        }

        public void selectUsers()
        {
            Player p = new Player();
            foreach (Player player in p.players)
            {
                var row = new { Name = player.name, Colour = player.colour, Turns = player.turns};
                LbPlayers.Items.Add(row);
            }
        }

        public void selectVragen()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //vorige 
            ReadyPlayers readyPlayers = new ReadyPlayers();
            readyPlayers.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            readyPlayers.Show();
            this.Close();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //volgende 
            
        }
    }
}
