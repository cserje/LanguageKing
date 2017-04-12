using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LanguageKing.ViewModels
{
    class ChooseLanguagePageViewModel :INotifyPropertyChanged
    { 
        private string[] titles= {"Select your language!", "Choisissez votre langue!",  "Wählen Sie Ihre Sprache!", "Válassza ki a nyelveket!", "Seleziona la tua lingua!"};
        private string[] nextButtonText= {"Next", "Plus", "Weiter", "Tovább", "Ulteriormente" };
        private int firstLanguageSelectedIndex=0;
        string title;
        public int FirstLanguageSelectedIndex
        {
            get { return firstLanguageSelectedIndex; }
            set { firstLanguageSelectedIndex = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(NextText));
            }
        }

        public string Title
        {
            get {
                return titles[firstLanguageSelectedIndex];
            }
            set {
                             
            }
        }
        public string NextText
        {
            get { return nextButtonText[firstLanguageSelectedIndex]; }
            
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
