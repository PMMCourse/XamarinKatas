using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
    public class MainViewModel: BindableObject
    {
        private Command<Persona> _searchCommand;
        public ICommand SearchCommand => _searchCommand;
        private List<Persona> _listaPersonas= new List<Persona>();
        private string _busqueda;
        public MainViewModel() {
            insertOnList();
            _searchCommand = new Command<Persona>(PerformSearch);
        }

        private void PerformSearch(Persona person)
        {
            Persona prueba = new Persona();
            prueba.nombre=_busqueda;
            //_listaPersonas = _listaPersonas.Where(x => x.nombre.Equals(prueba.nombre));
           /* foreach (Persona a in listaPersonas) {
                if (a.Where(x=>x.nombre!=busqueda)) {

                }
            }*/
        }
        private void insertOnList()
        {
            Persona paco = new Persona("Paco", 35);
            Persona dani = new Persona("Dani", 21);
            _listaPersonas.Add(paco);
            _listaPersonas.Add(dani);
        }

        public List<Persona> listaPersonas
        {
            get => _listaPersonas;
            set
            {
                OnPropertyChanged();
                _listaPersonas = value;
            }
        }
        public string busqueda
        {
            get => _busqueda;
            set
            {
                OnPropertyChanged();
                _busqueda = value;
            }
        }
    }
}
