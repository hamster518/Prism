using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Collections;
using Prism.Regions;

namespace PrismApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        
        private ObservableCollection<string> _account;
        public ObservableCollection<string> Account
        {
            get { return _account; }
            set { SetProperty(ref _account, value); }
        }

        private readonly IRegionManager _regionManager;

        private string _selectedAccount;
        public string SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                SetProperty(ref _selectedAccount, value);
                this._regionManager.RequestNavigate("ContentRegion", new Uri(_selectedAccount, UriKind.Relative));

            }
        }

        public DelegateCommand<string> AddCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            Account = new ObservableCollection<string>();
            Account.Add("Administrator");
            Account.Add("User");

            //AddCommand = new DelegateCommand<string>(AddAccount);
            AddCommand = new DelegateCommand<string>((e) => {
                Account.Add(e);
            });
        }
    }
}
