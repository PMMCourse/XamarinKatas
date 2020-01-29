using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataT : ContentPage
	{
        public List<Deportista> Lista = new List<Deportista>();

        public KataT ()
		{
			InitializeComponent ();

            var D1 = new Deportista() { Deporte = "Futbol", Sexo = "Hombre", Puntuacion = 100, Edad = 24 };
            var D2 = new Deportista() { Deporte = "Baloncesto", Sexo = "Mujer", Puntuacion = 100, Edad = 23 };
            Lista.Add(D1);
            Lista.Add(D2);
            listview.ItemsSource = Lista.Where(x => x.Deporte.Contains("F") && x.Edad > 20 && x.Puntuacion == 100);

		}
	}
}