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
            SelectedItem();
            
            Add();
        }
        void SelectedItem()
        {
            Lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Navigation.PushAsync(new Katas_UI.Kata_e.KataE(e.SelectedItem as Persona));
                    ((ListView)sender).SelectedItem = null;
                }
            };
        }
        void Add()
        {

            Personas.Add(new Persona() { Nombre = "pepe", Edad = 20, image = "imagenp.png" });
            Personas.Add(new Persona() { Nombre = "pepa", Edad = 21, image = "imagens.png" });
            Personas.Add(new Persona() { Nombre = "jose", Edad = 22, image = "imagent.png" });

            Lista.ItemsSource = Personas;
        }
    }
}