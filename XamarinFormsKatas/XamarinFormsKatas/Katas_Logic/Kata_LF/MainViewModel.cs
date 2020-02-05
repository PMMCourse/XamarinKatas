using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
    public class MainViewModel:BindableObject
    {
        public MainViewModel()
        {

        }
        private Deportista _deport = new Deportista(25, 48, "Francisco", "Baloncesto");
        public Deportista deport
        {
            get => _deport;
            set
            {
                _deport = value;
                OnPropertyChanged();
            }
        }
    }
}
