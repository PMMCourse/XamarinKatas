using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LA
{
    public class BaseViewModel : BindableObject
    {
        private string _nombre;

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged();
            }
        }
    }
}
