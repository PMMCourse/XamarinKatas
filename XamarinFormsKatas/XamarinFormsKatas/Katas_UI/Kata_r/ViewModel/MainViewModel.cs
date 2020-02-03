using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_UI.Kata_r.ViewModel;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class MainViewModel: BaseViewModel
    {
        Proveedor provee = new Proveedor("paco", "patatas");
        Cliente client = new Cliente("dani", "20063078V");
        public MainViewModel() {
            _items.Add(provee);
            _items.Add(client);
        }
        private List<Persona> _items = new List<Persona>();

        public List<Persona> Items
        {
            get => _items;
            set => SetChanged(ref _items, value);
        }

    }
}
