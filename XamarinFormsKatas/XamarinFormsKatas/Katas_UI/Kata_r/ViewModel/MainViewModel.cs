using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_UI.Kata_r.Model;
using XamarinFormsKatas.ViewModel;

namespace XamarinFormsKatas.Katas_UI.Kata_r.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        Cliente cli = new Cliente("Paco", "20063079h");
        Proveedor prov = new Proveedor("Alejandro", "Arrucutua");

        private List<Persona> _items = new List<Persona>();

        public MainViewModel(){
            _items.Add(cli);
            _items.Add(prov);
        }

        public List<Persona> Items
        {
            get => _items;
            set => SetChanged(ref _items, value);
        }
    }
}
