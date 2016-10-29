using System.Windows.Input;
using Prism.Commands;
using TextSpeaker.Model;
using Xamarin.Forms;

namespace TextSpeaker.ViewModels
{
    public class TextSpeechPageViewModel
    {
        public string Text { get; set; } = "Hello, World.";

        public ICommand SpeechCommand => new DelegateCommand(Speech);

        private readonly ITextToSpeechService _textToSpeechService;
        public TextSpeechPageViewModel(ITextToSpeechService textToSpeechService)
        {
            _textToSpeechService = textToSpeechService;
        }

        public void Speech()
        {
            _textToSpeechService.Speech(Text);
        }
    }
}