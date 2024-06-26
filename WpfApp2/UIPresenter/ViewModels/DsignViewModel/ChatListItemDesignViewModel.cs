﻿using CommonLibs.Data;
using System;

namespace UI.UIPresenter.ViewModels
{
    public class ChatListItemDesignViewModel : ChatListItemViewModel
    {
        #region Singleton

        public static ChatListItemDesignViewModel Instance => new ChatListItemDesignViewModel();

        #endregion

        #region Constructor

        public ChatListItemDesignViewModel()
        {

            //var user = new Contact("Vidzhel", "myemail.com", "somthing there");
            var message = new Message(10, 20, DataType.Text, DateTime.Now, "Hello there, thenks for the pressent, i very", MessageStatus.Sended);

            LastMessage = message;
            //GroupData = user;
        }

        #endregion
    }
}
