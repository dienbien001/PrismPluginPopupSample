using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;

namespace PrismPluginPopupSample.ViewModels
{
    public class MainMasterPageViewModel : ViewModelBase
    {
        public DelegateCommand DisplayPopupCommand { get; set; }
        public MainMasterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            DisplayPopupCommand = new DelegateCommand(DisplayPopup);
        }

        private void DisplayPopup()
        {
            NavigationService.NavigateAsync("PopupPage");
        }
    }
}
