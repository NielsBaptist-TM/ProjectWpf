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
using System.Data.SqlClient;
using System.IO;

namespace ProjectWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inactiveUsers();
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            ReadyPlayers ReadyPlayers = new ReadyPlayers();
            ReadyPlayers.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ReadyPlayers.Show();
            this.Close();
        }

        private void BtnHighscores_Click(object sender, RoutedEventArgs e)
        {
            Highscores Highscores = new Highscores();
            Highscores.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Highscores.Show();
            this.Close();
        }

        public void inactiveUsers()
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=r0793266.database.windows.net; Initial Catalog = SQLDBWPF; Persist Security Info = True; User ID = admin2ITF; Password = Password2ITF");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlConnection;
            cmd.CommandText = "update Players " +
                "set active = '" + 0 + "' where active = '" + 1 + "'";
            SqlConnection.Open();
            cmd.ExecuteNonQuery();
            SqlConnection.Close();
        }

        private void BtnQuestions_Click(object sender, RoutedEventArgs e)
        {
            ManageQuestionWindow ManageQuestionWindow = new ManageQuestionWindow();
            ManageQuestionWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ManageQuestionWindow.Show();
            this.Close();
        }
    }
}
