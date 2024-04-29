using System.Windows.Controls;
using UI.UIPresenter.ViewModels;

namespace UI.UserControls
{
    /// <summary>
    /// Interaction logic for InfoGroupControl.xaml
    /// </summary>
    public partial class InfoGroupControl : UserControl
    {
        public InfoGroupControl()
        {
            InitializeComponent();

            //Setup data context
            DataContext = new InfoGroupControlViewModel();
        }
    }
}
