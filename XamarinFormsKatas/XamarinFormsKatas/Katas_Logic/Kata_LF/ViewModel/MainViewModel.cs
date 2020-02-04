using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LF.Model;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF.ViewModel
{
    public class MainViewModel : BindableObject
    {
        
        public MainViewModel()
        {

        }
        private Deportista _item = new Deportista(10,"paco",21,"Futbol");

        public Deportista Item
        {
            get => _item;
            set {
                OnPropertyChanged();
                _item = value;
            }
        }
    }
}
