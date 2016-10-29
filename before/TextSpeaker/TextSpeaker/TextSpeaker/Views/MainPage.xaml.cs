using System;
using Xamarin.Forms;

namespace TextSpeaker.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("確認", "Text Speech画面へ遷移しますか？", "OK", "Cancel");
            if (result)
            {
                await Navigation.PushAsync(new TextSpeechPage());
            }
        }
    }
}
