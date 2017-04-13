﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LanguageKing.ViewModels
{
    class LearnWordsViewModel : INotifyPropertyChanged
    {

        private string[] nextButtonText = { "Next", "Plus", "Weiter", "Tovább", "Ulteriormente" };
        private string[] backButtonText = { "Back", "Dos", "Zurück", "Vissza", "Indietro" };
        private string questionText = "Question1";
        private string answerText = "Answer1";
        public string QuestionText
        {
            get
            {
                return questionText;
            }
            set
            {
                questionText = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(AnswerText));
            }
        }
        public string AnswerText
        {
            get { return answerText; }
            set
            {
                answerText = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(QuestionText));
            }
        }
        public string NextButtonText
        {
            get { return nextButtonText[ChooseLanguagePage.FirstLanguage]; }
        }
        public string BackButtonText
        {
            get { return backButtonText[ChooseLanguagePage.FirstLanguage]; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
