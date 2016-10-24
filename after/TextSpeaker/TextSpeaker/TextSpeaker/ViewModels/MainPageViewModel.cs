using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Services;

namespace TextSpeaker.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        public ICommand NavigationCommand => DelegateCommand.FromAsyncHandler(Navigate);
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        private async Task Navigate()
        {
            var result = await _pageDialogService.DisplayAlertAsync("確認", "Text Speach画面へ遷移しますか？", "OK", "Cancel");
            if (result)
            {
                await _navigationService.NavigateAsync("TextSpeachPage");
            }

        }
    }
}
