using TextSpeaker.Model;
using Xamarin.Forms;

namespace TextSpeaker.ViewModels
{
    public class TextSpeachPageViewModel
    {
        public string Text { get; set; } = "Hello, World.";

        public void Speach()
        {
            var service = DependencyService.Get<ITextToSpeachService>();
            service.Speach(Text);
        }
    }
}