using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class PaginaNuevaViewModel : BaseViewModel
    {
        private string _texto;
        public string texto
        {
            get => _texto;
            set
            {
                _texto = value;
                OnPropertyChanged();
            }
        }
        public PaginaNuevaViewModel(string text)
        {
            texto = text;
        }

    }
}
