using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using PrismModule1.Notifications;
using System;

namespace PrismModule1.ViewModels
{
    public class LoginInfoViewModel : BindableBase, IInteractionRequestAware
    {
        private LoginInfoNotification LiNotification;
        public Action FinishInteraction { get; set; }
        public INotification Notification
        {
            get { return LiNotification; }
            set { SetProperty(ref LiNotification, (LoginInfoNotification)value); }
        }
        
        public LoginInfoViewModel()
        {

        }
    }
}
