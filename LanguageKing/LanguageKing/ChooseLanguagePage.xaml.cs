using LanguageKing.ViewModels;
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
    public partial class ChooseLanguagePage : ContentPage
    {
        enum languages{english=0,french=1,german=2,hungarian=3,italian=4}
        
        private int selectedFirst=-1;
        private int selectedSecond=-1;
        public static int FirstLanguage=0;
        
        public ChooseLanguagePage(String s)
        {
           
            InitializeComponent();
    
            BindingContext = new ChooseLanguagePageViewModel();
          
        }

        void OnFirstLanguageChanged(object sender, EventArgs e)
        {
          
            selectedFirst = firstLanguagePicker.SelectedIndex;
            FirstLanguage = selectedFirst;
            
            
        }
        void OnSecondLanguageChanged(object sender, EventArgs e)
        {
           
            selectedSecond = secondLanguagePicker.SelectedIndex;
        }

        async void OnSelectLanguagesAsync(object sender, EventArgs e)
        {
            if ((selectedFirst == -1 || selectedSecond == -1) || selectedFirst == selectedSecond)
            {
                switch(selectedFirst)
                {
                    case (int) languages.english:
                        await DisplayAlert("Warning", "Choose two different languages!", "Cancel");
                        break;
                    case (int) languages.french:
                        await DisplayAlert("Avertissement", "Choisissez deux langues différentes!", "Annuler");
                        break;
                    case (int) languages.german:
                        await DisplayAlert("Warnung", "Wähle zwei verschiedene Sprachen!", "Stornieren");
                        break;
                    case (int)languages.hungarian:
                        await DisplayAlert("Figyelmeztetés", "Válassz két különböző nyelvet!", "Vissza");
                        break;
                    case (int)languages.italian:
                        await DisplayAlert("Avvertimento", "Scegli due lingue diverse!", "Annulla");
                        break;
            }
        }
            else
            {
           
                await Navigation.PushAsync(new MainMenuPage(selectedFirst,selectedSecond));

            }
        }
    }
}
