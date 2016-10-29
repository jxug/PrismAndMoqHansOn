using AVFoundation;
using TextSpeaker.iOS.Model;
using TextSpeaker.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace TextSpeaker.iOS.Model
{
    public class TextToSpeechService : ITextToSpeechService
    {
        public void Speech(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 2,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}