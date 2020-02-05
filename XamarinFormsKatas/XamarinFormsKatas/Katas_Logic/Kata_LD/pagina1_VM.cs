using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class pagina1_VM:BaseViewModel
    {
        private string _text;
        public string text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }
        public pagina1_VM(string texto)
        {
            text = texto;
        }
    }
}
