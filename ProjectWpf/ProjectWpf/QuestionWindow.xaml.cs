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
            //fill the grid with players items from the database
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "select name, colour, turns from Players where active = 1";
            SqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string colour = reader["colour"].ToString();
                    int turns = Convert.ToInt32(reader["turns"]);
                    var row = new { Name = name, Colour = colour, Turns = turns };
                    LbPlayers.Items.Add(row);
                }
            }
            SqlConnection.Close();
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
