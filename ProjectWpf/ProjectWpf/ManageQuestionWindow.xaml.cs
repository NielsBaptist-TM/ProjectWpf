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
    /// Interaction logic for ManageQuestionWindow.xaml
    /// </summary>
    public partial class ManageQuestionWindow : Window
    {
        public ManageQuestionWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            if (!(String.IsNullOrEmpty(TxtAnswer.Text) || String.IsNullOrEmpty(TxtVraag1.Text)
                || String.IsNullOrEmpty(TxtWrong1.Text) || String.IsNullOrEmpty(TxtWrong2.Text) ||
                String.IsNullOrEmpty(TxtWrong3.Text)))
            {
                try
                {
                    MessageBox.Show("Uw vraag is met succes toegevoegd");
                    int categorie = CbCategorie.SelectedIndex + 1;
                    Question question = new Question(Convert.ToInt32(categorie),
                    TxtVraag1.Text, TxtAnswer.Text, TxtWrong1.Text, TxtWrong2.Text, TxtWrong3.Text);
                    //clear text fields
                    TxtAnswer.Text = string.Empty;
                    TxtVraag1.Text = string.Empty;
                    TxtWrong1.Text = string.Empty;
                    TxtWrong2.Text = string.Empty;
                    TxtWrong3.Text = string.Empty;
                    }
                catch (Exception)
                {
                    MessageBox.Show("Er ging iets mis met het toevoegen van uw vraag.");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("gelieve alle velden in te vullen");
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            CrudQuestionWindow crudQuestionWindow = new CrudQuestionWindow();
            crudQuestionWindow.Show();
            this.Hide();
        }
    }
}
