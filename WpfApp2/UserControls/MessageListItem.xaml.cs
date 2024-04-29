using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using UI.Animations;

namespace UI.UserControls
{
    /// <summary>
    /// Interaction logic for MessageListItem.xaml
    /// </summary>
    public partial class MessageListItem : UserControl
    {

        float SlideDurationSec = 0.5F;

        public MessageListItem()
        {
            InitializeComponent();

            //Starts all page animations
            startAnimationsAsync();
        }

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
