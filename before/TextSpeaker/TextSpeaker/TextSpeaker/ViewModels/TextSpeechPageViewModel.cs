using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using TextSpeaker.Model;
using Xamarin.Forms;

namespace TextSpeaker.ViewModels
{
    public class TextSpeechPageViewModel
    {
        public string Text { get; set; } = "Hello, World.";

        public ICommand SpeechCommand => new Command(Speech);

        public TextSpeechPageViewModel()
        {
        }

        public void Speech()
        {
            var service = DependencyService.Get<ITextToSpeechService>();
            service.Speech(Text);
        }
    }
}