using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismPluginPopupSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand DisplayPopupCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            DisplayPopupCommand = new DelegateCommand(DisplayPopup);
        }

        private void DisplayPopup()
        {
            NavigationService.NavigateAsync("PopupPage");
        }
    }
}
