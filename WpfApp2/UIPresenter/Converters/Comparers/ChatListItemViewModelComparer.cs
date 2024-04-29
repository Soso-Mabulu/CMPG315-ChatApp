using System.Collections.Generic;

namespace UI.UIPresenter.ViewModels
{
    public class ChatListItemViewModelComparer : IComparer<ChatListItemViewModel>
    {
        public int Compare(ChatListItemViewModel x, ChatListItemViewModel y)
        {
            return x.LastMessageTime.CompareTo(y.LastMessageTime);
        }
    }
}
