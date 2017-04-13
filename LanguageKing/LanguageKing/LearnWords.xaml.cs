
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
            
            count++;
            
        }

        public void listenButtonClicked(object sender, EventArgs e)
        {

            DependencyService.Get<ITextToSpeech>().Speak("Au revoir");
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
    }

    
}
