using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;
using XamarinFormsKatas.Katas_Logic.Kata_LF.Model;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Deportista> _Deportistas = new ObservableCollection<Deportista>();

        public ObservableCollection<Deportista> Deportistas
        {
            get => _Deportistas;
            set
            {
                _Deportistas = value;
                OnPropertyChanged();
            }
        }
       public MainViewModel()
        {
            _Deportistas.Add(new Deportista() { Deporte = "Futbol", Edad = 22, Puntuacion = 80, Sexo = "Hombre" });
            _Deportistas.Add(new Deportista() { Deporte = "Futbol", Edad = 23, Puntuacion = 100, Sexo = "Mujer" });
            _Deportistas.Add(new Deportista() { Deporte = "Futbol", Edad = 22, Puntuacion = 40, Sexo = "Hombre" });
            _Deportistas.Add(new Deportista() { Deporte = "Baloncesto", Edad = 29, Puntuacion = 60, Sexo = "Mujer" });
            _Deportistas = new ObservableCollection<Deportista>(_Deportistas.Where(x => x.Deporte.Contains("F") && x.Puntuacion > 50));
        }
        
    }
}
