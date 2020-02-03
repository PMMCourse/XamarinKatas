using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class VentanaDosViewModel : BaseViewModel
    {
        private string _texto;
        public string Texto 
        {
            get => _texto;
            set
            {
                _texto = value;
                OnPropertyChanged();
            }
        }

        public VentanaDosViewModel(string texto)
        {
            Texto = texto;
        }
    }
}
