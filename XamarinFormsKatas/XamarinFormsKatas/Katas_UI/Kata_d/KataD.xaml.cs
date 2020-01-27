using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
        ObservableCollection<Persona> Personas = new ObservableCollection<Persona>();
        public KataD()
        {
            InitializeComponent();
            Add();
        }
        void Add()
        {

            Personas.Add(new Persona() { Nombre = "pepe", Edad = 20});
            Personas.Add(new Persona() { Nombre = "pepa", Edad = 21});
            Personas.Add(new Persona() { Nombre = "jose", Edad = 22});

            Lista.ItemsSource = Personas;
        }
    }
}