﻿using Android.Speech.Tts;
using Xamarin.Forms;
using System.Collections.Generic;
using DependencyServiceSample.Droid;
using Java.Util;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechAndroid))]
namespace DependencyServiceSample.Droid
{

    public class TextToSpeechAndroid : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public TextToSpeechAndroid() { }

        public void Speak(string text, int lang)
        {
            try
            {
                //sorrend: angol, francia, német, magyar, olasz
                switch (lang)
                {
                    case 1:
                        speaker.SetLanguage(Locale.English);
                        break;
                    case 2:
                        speaker.SetLanguage(Locale.French);
                        break;
                    case 3:
                        speaker.SetLanguage(Locale.German);
                        break;
                    case 4:
                        speaker.SetLanguage(Locale.English);
                        break;
                    case 5:
                        speaker.SetLanguage(Locale.Italian);
                        break;
                    default:
                        speaker.SetLanguage(Locale.English);
                        break;
                }
            }
            catch (Exception e)
            {
                
            }
            var ctx = Forms.Context; // useful for many Android SDK features
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(ctx, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }
        #endregion
    }
}