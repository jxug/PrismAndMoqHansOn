using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSpeaker.ViewModels;
using Xamarin.Forms;

namespace TextSpeaker.Views
{
    public partial class TextSpeachPage : ContentPage
    {
        public TextSpeachPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("確認", "実行しますか？", "OK", "Cancel");
            if (result)
            {
                var vm = BindingContext as TextSpeachPageViewModel;
                vm?.Speach();
            }
        }
    }
}
