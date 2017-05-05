using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismModule2.ViewModels
{
    public class AdministratorViewModel : BindableBase
    {
        public class userAccount
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        private List<userAccount> userList;

        public List<userAccount> UserList
        {
            get { return userList; }
            set { userList = value; }
        }

        public AdministratorViewModel()
        {
            UserList = new List<userAccount>()
            {
                new userAccount() { UserName = "Apple", Password = "123" }
                ,new userAccount() { UserName = "Banana", Password = "456" }
                ,new userAccount() { UserName = "Cat", Password = "789" }
            };
        }
    }
}
