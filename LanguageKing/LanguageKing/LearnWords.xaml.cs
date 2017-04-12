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
        private int firstLanguage, secondLanguage;
        int count = 0;
        public LearnWords(int first, int second)
        {
            InitializeComponent();
            firstLanguage = first;
            secondLanguage = second;
            //Learn();
        }

        private void Learn()
        {
            List<Word> words = InitWords();
           
            while(count<words.Count)
            {
                DisplayAlert("Limit", "count: " + count.ToString(), "Cancel");
            }
            count = 0;
        }

        public void nextButtonClicked(object sender, EventArgs e)
        {
            count++;
            
        }
        private List<Word> InitWords()
        {
            //sorrend: angol, francia, német, magyar, olasz
            List<Word> words = new List<Word>();
            words.Add(new Word("one", "h un, une", "ein", "egy", "uno"));
            words.Add(new Word("two", "deux", "zwei", "kettő", "duo"));
            words.Add(new Word("three", "h trois", "drei", "három", "tre"));
            words.Add(new Word("four", "h quatre", "vier", "négy", "quattro"));
            words.Add(new Word("five", "h cinq", "fünf", "öt", "cinque"));
            return words;
        }
    }

    
}
