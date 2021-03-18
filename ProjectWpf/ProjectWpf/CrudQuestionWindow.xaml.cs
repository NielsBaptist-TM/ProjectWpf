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
    /// Interaction logic for CrudQuestionWindow.xaml
    /// </summary>
    public partial class CrudQuestionWindow : Window
    {
        Question q;
        public CrudQuestionWindow()
        {
            InitializeComponent();
        }

        private void LvQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ManageQuestionWindow manageQuestionWindow= new ManageQuestionWindow();
            manageQuestionWindow.Show();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Question q = new Question();
                foreach (Question x in q.questionList)
                {
                    var row = new { Question = x.question, Category = x.category };
                    LvQuestions.Items.Add(row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("De vragenlijst is leeg, gelieve eerst een vraag toe te voegen in het vorige venster");
                throw;
            }
        }
    }
}
