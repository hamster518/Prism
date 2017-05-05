using Prism.Interactivity.InteractionRequest;

namespace PrismModule1.Notifications
{
    public class LoginInfoNotification : Confirmation
    {
        public LoginInfoNotification()
        {

        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
