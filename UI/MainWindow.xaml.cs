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

namespace UI
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            (new UI.Windows.UserWindow()).Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Pass.Visibility = Visibility.Visible;
            this.OK.Visibility = Visibility.Visible;
            this.enter.Visibility = Visibility.Visible;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (Pass.Text == "1234") {
                mainGrid.Children.Clear();
                mainGrid.Children.Add(new AdminMenu());
            }
        }
    }
}
