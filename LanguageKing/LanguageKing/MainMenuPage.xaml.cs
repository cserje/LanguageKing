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
    public partial class MainMenuPage : ContentPage
    {
        private int firstLanguage;
        private int secondLanguage;

        public MainMenuPage(int first, int second)
        {
           firstLanguage = first;
            this.secondLanguage = second;
            InitializeComponent();
        }

        private async Task learnButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LearnWords(firstLanguage,secondLanguage));
        }
        
             private async Task practiceButton_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PracticeWords(firstLanguage, secondLanguage));
        }
      
                private async Task CloseApplication(object sender, EventArgs e)
        {
            
        }
    }
}
