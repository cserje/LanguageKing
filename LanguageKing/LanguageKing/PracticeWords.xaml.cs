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
    public partial class PracticeWords : ContentPage
    {
        int firstLanguage, secondLanguage;
        public PracticeWords(int first, int second)
        {
            firstLanguage = first;
            secondLanguage = second;
            InitializeComponent();
        }
    }
}
