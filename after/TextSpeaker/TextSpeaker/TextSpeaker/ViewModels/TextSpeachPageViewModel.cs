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

        private readonly ITextToSpeachService _textToSpeachService;
        public TextSpeachPageViewModel(ITextToSpeachService textToSpeachService)
        {
            _textToSpeachService = textToSpeachService;
        }

        public void Speach()
        {
            _textToSpeachService.Speach(Text);
        }
    }
}