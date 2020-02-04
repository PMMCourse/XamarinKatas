using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataE : ContentPage
    {
        
        public KataE ()
		{
			InitializeComponent ();
            insertOnList();
            listaE.ItemTapped += (sender, e) => {
                var persona2 = (Persona)listaE.SelectedItem;
                Navigation.PushAsync(new Katas_UI.Kata_e.ElementoPersona(persona2));
            };
        }

        private void insertOnList()
        {
            Persona paco = new Persona("Paco", 35);
            Persona dani = new Persona("Dani", 21);
            List<Persona> listaPersona = new List<Persona>();
            listaPersona.Add(paco);
            listaPersona.Add(dani);
            listaE.ItemsSource = listaPersona;
        }
    }
}