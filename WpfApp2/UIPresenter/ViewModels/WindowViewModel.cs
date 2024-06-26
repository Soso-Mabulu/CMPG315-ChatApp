﻿using ClientLibs.Core.DataAccess;
using PropertyChanged;
using System.Windows;
using System.Windows.Input;
using UI.InversionOfControl;

namespace UI.UIPresenter.ViewModels
{

    /// <summary>
    /// View model for msin window
    /// </summary>
    class WindowViewModel : BaseViewModel
    {
        #region private Members

        private readonly Window window;

        private int borderResize = 5;


        #endregion

        #region Public Members


        //Commands for system buttons
        [DoNotNotify]
        public ICommand CloseWindow { get; set; }
        [DoNotNotify]
        public ICommand ColapseWindow { get; set; }
        [DoNotNotify]
        public ICommand MaximazeWindow { get; set; }

        /// <summary>
        /// Set Outher margin for the window
        /// </summary>
        public int OutherMargin { get; set; } = 6;
        public Thickness OutherMarginThickness
        {
            get
            {

                if (window.WindowState == WindowState.Maximized)
                    return new Thickness(0);
                return new Thickness(OutherMargin);
            }
        }

        /// <summary>
        /// Set Resize border thickness
        /// </summary>
        public int BorderResize { get { return borderResize + OutherMargin; } set { borderResize = value; } }
        public Thickness BorderResizeThickness { get { return new Thickness(BorderResize); } }

        /// <summary>
        /// Set Resize border thickness
        /// </summary>
        public int WindowBorderSize { get; set; } = 4;
        public Thickness WindowBorderSizeThickness
        {
            get
            {

                if (window.WindowState == WindowState.Maximized)
                    return new Thickness(0);
                return new Thickness(WindowBorderSize);
            }
        }

        //Min size of the window
        public double MinHeight { get; set; } = 400;
        public double MinWidth { get; set; } = 600;


        /// <summary>
        /// Set Corner Radious
        /// </summary>
        public int Radius { get; set; } = 10;
        public CornerRadius CornerRadius
        {
            get
            {
                if (window.WindowState == WindowState.Maximized)
                    return new CornerRadius(0);
                else
                    return new CornerRadius(Radius);
            }
        }

        /// <summary>
        /// True if server connected to the server
        /// </summary>
        public bool ConnectedToServer { get; set; }

        /// <summary>
        /// Set Height of Caption
        /// </summary>
        public int CaptionHeight { get; set; } = 15;
        public GridLength CaptionHeightGridLeight { get { return new GridLength(CaptionHeight + BorderResize); } }

        public ApplicationViewModel ApplicationViewModel => ApplicationService.GetApplicationViewModel;

        #endregion

        #region Constructor
        public WindowViewModel(Window window)
        {
            this.window = window;

            //On window state change handdler
            window.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(BorderResizeThickness));
                OnPropertyChanged(nameof(CornerRadius));
                OnPropertyChanged(nameof(OutherMarginThickness));
            };

            //Set on connection changed handlers
            UnitOfWork.AddConnectionChangedHandler((s, a) => OnConnectionChanged(s, a));
            ConnectedToServer = UnitOfWork.ServerConnected;

            //commands for buttons
            CloseWindow = new RelayCommand(() =>
            {
                window.Close();
            });
            ColapseWindow = new RelayCommand(() =>
            {
                window.WindowState = WindowState.Minimized;
            });
            MaximazeWindow = new RelayCommand(() =>
            {
                window.WindowState ^= WindowState.Maximized;
            });

            //Fix windew resize Issue
            var resizer = new WindowResizer(window);
        }

        #endregion

        #region Private Handlers

        void OnConnectionChanged(object sender, bool args)
        {
            ConnectedToServer = args;
        }

        #endregion

    }
}
