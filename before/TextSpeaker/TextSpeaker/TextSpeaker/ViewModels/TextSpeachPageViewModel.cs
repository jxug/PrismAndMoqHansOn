using System.Windows.Input;
using Prism.Commands;
using TextSpeaker.Model;
using Xamarin.Forms;

namespace TextSpeaker.ViewModels
{
    public class TextSpeachPageViewModel
    {
        public string Text { get; set; } = "Hello, World.";

        public ICommand SpeachCommand => new DelegateCommand(Speach);

        public TextSpeachPageViewModel()
        {
        }

        public void Speach()
        {
            var service = DependencyService.Get<ITextToSpeachService>();
            service.Speach(Text);
        }
    }
}