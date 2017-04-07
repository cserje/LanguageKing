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
            this.firstLanguage = first;
            this.secondLanguage = second;
            InitializeComponent();
        }
    }
}
