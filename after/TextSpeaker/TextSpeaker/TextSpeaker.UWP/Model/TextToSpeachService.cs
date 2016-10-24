using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using TextSpeaker.Model;
using TextSpeaker.UWP.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeachService))]
namespace TextSpeaker.UWP.Model
{
    public class TextToSpeachService : ITextToSpeachService
    {
        public async void Speach(string text)
        {
            var mediaElement = new MediaElement();
            var synth = new SpeechSynthesizer();
            var stream = await synth.SynthesizeTextToStreamAsync(text);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
