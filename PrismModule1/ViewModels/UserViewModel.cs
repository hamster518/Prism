using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using PrismModule1.Notifications;

namespace PrismModule1.ViewModels
{
    public class UserViewModel : BindableBase
    {
        private string _data = "User";
        public string data
        {
            get { return _data; }
            set { SetProperty(ref _data, value); }
        }

        public string txtUsername { get; set; }
        public string txtPassword { get; set; }
        public DelegateCommand LoginCommand { get; private set; }
        public DelegateCommand NotificationCommand { get; set; }
        public DelegateCommand ConfirmationCommand { get; set; }
        public DelegateCommand CustomPopupCommand { get; set; }

        public InteractionRequest<LoginInfoNotification> LoginInfoRequest { get; private set; }
        public InteractionRequest<INotification> NotificationRequest { get; set; }
        public InteractionRequest<IConfirmation> ConfirmationRequest { get; set; }
        public InteractionRequest<INotification> CustomPopupRequest { get; set; }

        public UserViewModel()
        {
            LoginCommand = new DelegateCommand(Login);
            NotificationCommand = new DelegateCommand(RaiseNotification);
            ConfirmationCommand = new DelegateCommand(RaiseConfirmation);
            CustomPopupCommand = new DelegateCommand(RaiseCustomPopup);

            NotificationRequest = new InteractionRequest<INotification>();
            ConfirmationRequest = new InteractionRequest<IConfirmation>();
            CustomPopupRequest = new InteractionRequest<INotification>();
            LoginInfoRequest = new InteractionRequest<LoginInfoNotification>();
        }

        private void Login()
        {
            LoginInfoRequest.Raise(new LoginInfoNotification { Title = "Login Information", UserName = txtUsername , Password = txtPassword }, r =>
             data = "Username:" + r.UserName + " Password:" + r.Password);
        }

        void RaiseNotification()
        {
            NotificationRequest.Raise(new Notification { Content = "Notification Message", Title = "Notification" }, r => 
            data = "Notified");
        }

        void RaiseConfirmation()
        {
            ConfirmationRequest.Raise(new Confirmation { Title = "Confirmation", Content = "Confirmation Message" }, r => 
            data = r.Confirmed ? "Confirmed" : "Not Confirmed");
        }

        void RaiseCustomPopup()
        {
            CustomPopupRequest.Raise(new Notification { Title = "Custom Popup", Content = "Custom Popup Message " }, r => 
            data = "Good to go");
        }

    }
}
