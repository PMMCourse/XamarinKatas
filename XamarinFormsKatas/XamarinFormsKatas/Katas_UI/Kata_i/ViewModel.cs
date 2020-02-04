using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_i
{
    public class ViewModel : BindableObject
    {
        private string _entry;

        public string entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged();
            }
        }
    }
}
