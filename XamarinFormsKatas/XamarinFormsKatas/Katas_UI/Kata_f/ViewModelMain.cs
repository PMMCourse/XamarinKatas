using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
    public class ViewModelMain: BindableObject
    {
        private Command<Personas> _busquedaComando;
        private List<Personas> _lista;
        public ICommand busquedaComando => _busquedaComando;
        public List<Personas> lista
        {
            get => _lista;
            set
            {
                OnPropertyChanged();
                _lista = value;
            }
        }
        private string _busqueda;
        public string busqueda
        {
            get=>_busqueda;
            set
            {
                OnPropertyChanged();
                _busqueda = value;
            }
        }

        public ViewModelMain()
        {


            _busquedaComando = new Command<Personas>(PrataformaBusqueda);
        }

        private void PrataformaBusqueda(Personas persona)
        {
            Personas pe = new Personas();
            pe.nombre = busqueda;
        }
        private void insertarEnLista()
        {
            Personas p1 = new Personas(25, "Juan");
            Personas p2 = new Personas(62, "Lola");
            lista.Add(p1);
            lista.Add(p2);
        }
    }
    
}
