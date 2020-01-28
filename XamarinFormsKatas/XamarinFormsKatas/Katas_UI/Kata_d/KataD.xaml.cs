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
		public KataD ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            List<Persona> LPersona = new List<Persona>();
            LPersona.Add(new Persona() { Nombre = "Paco", Edad = "25" });
            LPersona.Add(new Persona() { Nombre = "Ale", Edad = "24" });
            LPersona.Add(new Persona() { Nombre = "Dani", Edad = "23" });
            LPersona.Add(new Persona() { Nombre = "Manolo", Edad = "22" });

            ListOfPerson.ItemsSource = LPersona;

            base.OnAppearing();
        }
    }
}
