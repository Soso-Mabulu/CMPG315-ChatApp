﻿using System.Windows;
using UI.UIPresenter.ViewModels;

namespace WpfApp2
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new WindowViewModel(this);

        }

    }
}
