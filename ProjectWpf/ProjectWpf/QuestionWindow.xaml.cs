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

namespace ProjectWpf
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class QuestionWindow : Window
    {
        List<Player> players;
        public QuestionWindow()
        {
            InitializeComponent();
            var ReadyPlayers = this.DataContext;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //fill the grid with players items from the list

            /*for (int i = 0; i < players.Count; i++)
            {
                LbPlayers.Items.Add(players[i].name + " " + players[i].colour);
            }*/

        }
    }
}
