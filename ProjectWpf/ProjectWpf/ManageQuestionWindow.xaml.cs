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
            /*if (!(String.IsNullOrEmpty(TxtAnswer.Text) || String.IsNullOrEmpty(TxtVraag1.Text) 
                || String.IsNullOrEmpty(TxtWrong1.Text) || String.IsNullOrEmpty(TxtWrong2.Text) ||
                String.IsNullOrEmpty(TxtWrong3.Text)))
            {
                string gekozencat=   CbCategorie.SelectedItem.ToString();
                gekozencat.Reverse();
                int categorie = Convert.ToInt32(gekozencat.Substring(gekozencat.Length - 1, gekozencat.Length));
                Question question = new Question(Convert.ToInt32(categorie), 
                    TxtVraag1.Text, TxtAnswer.Text, TxtWrong1.Text, TxtWrong2.Text, TxtWrong3.Text);
            }
            else
            {
                MessageBox.Show("gelieve alle velden in te vullen");
            }*/
        }
    }
}
