using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LA
{
    public class BaseViewModel : BindableObject
    {
        private string _palabra;

        public string palabra 
        {
            get => _palabra;
            set 
            {
                _palabra = value;
                OnPropertyChanged();
            } 
        }

    }
}
