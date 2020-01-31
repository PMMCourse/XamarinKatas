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
        List<deportista> listaDepor = new List<deportista>();
		public KataT ()
		{
			InitializeComponent ();
            deportista dep1 = new deportista(38,25, "hombre", "futbol");
            deportista dep2 = new deportista(30, 29, "hombre", "tenis");
            listaDepor.Add(dep1);
            listaDepor.Add(dep2);
            listaDeportista.ItemsSource = listaDepor.Where(x=>x.edad>23&&x.deporte.Contains("T")&&x.puntuacion==30);

        }
	}
}