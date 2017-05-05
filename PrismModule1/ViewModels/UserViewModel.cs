using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using PrismModule1.Notifications;

namespace PrismModule1.ViewModels
{
    public class UserViewModel : BindableBase
    {
        public string txtUsername { get; set; }
        public string txtPassword { get; set; }
        public DelegateCommand LoginCommand { get; private set; }
        public InteractionRequest<LoginInfoNotification> LoginInfoRequest { get; private set; }

        public UserViewModel()
        {
            this.LoginCommand = new DelegateCommand(Login);
            this.LoginInfoRequest = new InteractionRequest<LoginInfoNotification>();
        }

        private void Login()
        {
            LoginInfoNotification LINotification = new LoginInfoNotification();
            LINotification.Title = "Login Information";

            LINotification.UserName = txtUsername;
            LINotification.Password = txtPassword;

            LoginInfoRequest.Raise(LINotification);
        }
    }
}
