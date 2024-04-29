using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using UI.Animations;

namespace UI.UserControls
{
    /// <summary>
    /// Interaction logic for ContactsListItem.xaml
    /// </summary>
    public partial class GroupListItem : UserControl
    {
        public GroupListItem()
        {
            InitializeComponent();

            //Starts all page animations
            startAnimationsAsync();
        }

        public float SlideDurationSec { get; private set; } = 0.5F;

        #region Animation Helpers

        private async Task startAnimationsAsync()
        {
            //Wait for Page animation done
            await Task.Delay(TimeSpan.FromMilliseconds((int)SlideDurationSec * 1000));
            //Element Animations
            AnimationPresets.SlideAndFadeFromDown(this, SlideDurationSec, 150);
        }

        #endregion
    }
}
