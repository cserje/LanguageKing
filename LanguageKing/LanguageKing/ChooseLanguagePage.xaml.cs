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
        private int selectedFirst=-1;
        private int selectedSecond=-1;
        
        public ChooseLanguagePage(String s)
        {
           
            InitializeComponent();
        }

        void OnFirstLanguageChanged(object sender, EventArgs e)
        {
          
            selectedFirst = firstLanguagePicker.SelectedIndex;
            
        }
        void OnSecondLanguageChanged(object sender, EventArgs e)
        {
           
            selectedSecond = secondLanguagePicker.SelectedIndex;
        }

        async void OnSelectLanguagesAsync(object sender, EventArgs e)
        {
            if ((selectedFirst == -1 || selectedSecond == -1) || selectedFirst == selectedSecond)
            {
                await DisplayAlert("Wrong decision", "Choose two different languages!", "Cancel");
            }
            else
            {
           
                await Navigation.PushAsync(new MainMenuPage(selectedFirst,selectedSecond));

            }
        }
    }
}
