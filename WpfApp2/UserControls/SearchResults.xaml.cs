﻿using System.Windows.Controls;
using UI.UIPresenter.ViewModels;

namespace UI.UserControls
{
    /// <summary>
    /// Interaction logic for SearchResults.xaml
    /// </summary>
    public partial class SearchResults : UserControl
    {
        public SearchResults()
        {
            InitializeComponent();

            //Set datacontext
            DataContext = new SearchResultsViewModel();
        }
    }
}
