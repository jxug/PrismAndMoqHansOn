using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TextSpeaker.Model;
using Xamarin.Forms;
using TextSpeaker.Droid.Model;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace TextSpeaker.Droid.Model
{
    public class TextToSpeechService :ITextToSpeechService
    {
        public void Speech(string text)
        {
        }
    }
}