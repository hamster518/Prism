using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using PrismModule1.Notifications;
using System;

namespace PrismModule1.ViewModels
{
    public class CustomPopupViewModel : BindableBase, IInteractionRequestAware
    {
        private Notification CpNotification;
        public Action FinishInteraction { get; set; }
        public INotification Notification
        {
            get { return CpNotification; }
            set { SetProperty(ref CpNotification, (Notification)value); }
        }
        
        public CustomPopupViewModel()
        {
        }
        
    }
}
