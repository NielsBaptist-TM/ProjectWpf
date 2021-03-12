﻿using System;
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
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            ReadyPlayers ReadyPlayers = new ReadyPlayers();
            ReadyPlayers.Show();
            this.Close();
        }

        private void BtnHighscores_Click(object sender, RoutedEventArgs e)
        {
            Highscores Highscores = new Highscores();
            Highscores.Show();
            this.Close();
        }
    }
}
