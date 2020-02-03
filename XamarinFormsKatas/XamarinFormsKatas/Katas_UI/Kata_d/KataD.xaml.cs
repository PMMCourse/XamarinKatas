using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataD : ContentPage {
        ObservableCollection<Persona> ListaPersonas = new ObservableCollection<Persona>();
        public KataD() {
            InitializeComponent();
            IncluirPersonas();
        }

        void IncluirPersonas() {

            ListaPersonas.Add(new Persona("Francisco", 23));
            ListaPersonas.Add(new Persona("Juan", 32));
            ListaPersonas.Add(new Persona("Chema", 46));

            ListViewPersonas.ItemsSource = ListaPersonas;
        }
    }
}