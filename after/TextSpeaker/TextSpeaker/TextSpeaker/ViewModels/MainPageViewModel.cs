using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Services;
using Xamarin.Forms;

namespace TextSpeaker.ViewModels
{
    public class MainPageViewModel : IConfirmNavigationAsync
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        public DelegateCommand<string> NavigationCommand => new DelegateCommand<string>(Navigate);
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        private void Navigate(string navigationPage)
        {
            _navigationService.NavigateAsync(navigationPage);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public async Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            return await _pageDialogService.DisplayAlertAsync("確認", "Text Speech画面へ遷移しますか？", "OK", "Cancel");
        }
    }
}
