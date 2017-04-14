﻿
using LanguageKing.ViewModels;
using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LanguageKing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnWords : ContentPage
    {
        private int count=0;
        private List<Word> words=new List<Word>();
       
        public LearnWords()
        {
            InitWords();
            InitializeComponent();
            BindingContext = new LearnWordsViewModel();
        }

        private void Learn()
        {
            
            InitWords();
            
            //questionEntry.BindingContext = words[0].element[ChooseLanguagePage.FirstLanguage];
            //answerEntry.BindingContext = words[0].element[ChooseLanguagePage.SecondLanguage];
            //while (count<words.Count)
            //{
                
            //}
            
        }

        public void nextButtonClicked(object sender, EventArgs e)
        {            
            if (count < words.Count - 1)
            {
                count++;
            }
            GetWord();
        }

        public void backButtonClicked(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            GetWord();
        }

        public void listenButtonClicked(object sender, EventArgs e)
        {
            String text = questionLabel.Text;
            DependencyService.Get<ITextToSpeech>().Speak(text, ChooseLanguagePage.SecondLanguage);
            //CrossTextToSpeech.Current.Speak("Orbán Viktor Magyarország királya");
        }

        private void InitWords()
        {
            //sorrend: angol, francia, német, magyar, olasz
           
            words.Add(new Word("one", "h un, une", "ein", "egy", "uno"));
            words.Add(new Word("two", "deux", "zwei", "kettő", "duo"));
            words.Add(new Word("three", "h trois", "drei", "három", "tre"));
            words.Add(new Word("four", "h quatre", "vier", "négy", "quattro"));
            words.Add(new Word("five", "h cinq", "fünf", "öt", "cinque"));
            
        }

        private void GetWord()
        {
                questionLabel.BindingContext = new { Text = words[count].getWord(ChooseLanguagePage.SecondLanguage) };
                answerLabel.BindingContext = new { Text = words[count].getWord(ChooseLanguagePage.FirstLanguage) };
        }

    }

    
}
