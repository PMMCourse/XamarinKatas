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
		}
        /*List<Persona> LPersona = new List<Persona>();
        protected override void OnAppearing()
        {
            List<Persona> LPersona = new List<Persona>();
            LPersona.Add(new Persona() { Nombre = "Paco", Edad = "25" });
            LPersona.Add(new Persona() { Nombre = "Ale", Edad = "24" });
            LPersona.Add(new Persona() { Nombre = "Dani", Edad = "23" });
            LPersona.Add(new Persona() { Nombre = "Manolo", Edad = "22" });

            ListOfPerson.ItemsSource = LPersona;

            base.OnAppearing();
        }*/
        /*public void Seleccionado(Object sender, EventArgs e)
        {
            var clicksito = (Persona)LPersona.SelectedItem;
            Navigation.PushAsync(new Katas_UI.Kata_e.KataE(clicksito.Nombre));
        }*/
    }
}