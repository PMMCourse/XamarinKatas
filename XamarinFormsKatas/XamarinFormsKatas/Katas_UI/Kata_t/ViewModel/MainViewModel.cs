using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_UI.Kata_t.Model;
using XamarinFormsKatas.ViewModel;
using XamarinFormsKatas.Katas_UI.Kata_t.ViewModel.BaseViewModel;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_t.ViewModel
{
    public class MainViewModel : BindableObject
    {
        private Deportista _items = new Deportista("Paco", "basket", 120, 22);

        public MainViewModel()
        {
        }

        public Deportista Items
        {
            get => _items;
            set
            {
                OnPropertyChanged();
                _items = value;
            }
        }
    }
}
