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
        private int firstLanguageSelectedIndex=1;
        string title;
        public int FirstLanguageSelectedIndex
        {
            get { return firstLanguageSelectedIndex; }
            set { firstLanguageSelectedIndex = value;
                OnPropertyChanged();
               title= titles[firstLanguageSelectedIndex];
            }
        }

        public string Title
        {
            get {
                return title;
               
               
            }
            set {
                title = value;
               
            }
        }

       

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
