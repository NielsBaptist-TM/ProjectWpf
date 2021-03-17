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

namespace ProjectWpf
{
    /// <summary>
    /// Interaction logic for Highscores.xaml
    /// </summary>
    public partial class Highscores : Window
    {
        public Highscores()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {


            //fill the grid with players items from the database
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "select distinct(name), turns from Players order by turns";
            SqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    int turns = Convert.ToInt32(reader["turns"]);
                    var row = new { Name = name, Turns = turns };
                    LbHighscores.Items.Add(row);
                }
            }
            SqlConnection.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            MainWindow.Show();
            this.Close();
        }

        private void LbHighscores_SelectionChanged()
        {

        }
    }
}
