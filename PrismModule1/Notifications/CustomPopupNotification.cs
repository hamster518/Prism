using Prism.Interactivity.InteractionRequest;

namespace PrismModule1.Notifications
{
    public class CustomPopupNotification : Confirmation
    { 
        public CustomPopupNotification()
        {

        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }



        public string Content { get; set; }
    }
}
