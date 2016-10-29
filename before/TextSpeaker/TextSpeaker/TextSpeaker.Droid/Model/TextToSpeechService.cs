using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using TextSpeaker.Model;
using Xamarin.Forms;
using TextToSpeechService = TextSpeaker.Droid.Model.TextToSpeechService;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace TextSpeaker.Droid.Model
{
    public class TextToSpeechService : Java.Lang.Object, ITextToSpeechService, TextToSpeech.IOnInitListener
    {
        private string _text;

        private TextToSpeech _speaker;

        public TextToSpeechService()
        {
        }

        public void Speech(string text)
        {
            _text = text;
            if (_speaker == null)
            {
                _speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                _speaker.Speak(_text, QueueMode.Flush, Bundle.Empty, null);
            }
        }

        #region IOnInitListener implementation

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                _speaker.Speak(_text, QueueMode.Flush, Bundle.Empty, null);
            }
        }

        #endregion
    }
}