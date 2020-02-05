using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LA
{
    class ViewModel : BindableObject
    {
        private string _LabelText;
        public string LabelText
        {
            get => _LabelText;
            set
            {
                _LabelText = value;
                OnPropertyChanged();
            }
        }
    }
}
