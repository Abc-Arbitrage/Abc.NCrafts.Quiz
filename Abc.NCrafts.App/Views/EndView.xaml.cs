﻿using System.Windows;
using System.Windows.Controls;

namespace Abc.NCrafts.App.Views
{
    /// <summary>
    /// Interaction logic for EndView.xaml
    /// </summary>
    public partial class EndView : UserControl
    {
        public EndView()
        {
            InitializeComponent();
        }

        private void EndViewOnLoaded(object sender, RoutedEventArgs e)
        {
            EmailTextBox.Focus();
            EmailTextBox.SelectAll();
        }
    }
}
