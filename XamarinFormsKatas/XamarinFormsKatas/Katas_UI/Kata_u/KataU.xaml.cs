using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_t;

namespace XamarinFormsKatas.Katas_UI.Kata_u
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataU : ContentPage
	{
		public List<Deportista> Lista = new List<Deportista>();
		public KataU ()
		{
			InitializeComponent ();
			Deportista Dep1 = new Deportista(18, 23, "Federer", "Tenis");
			Deportista Dep2 = new Deportista(4, 32, "Joaquin", "Fútbol");
			Deportista Dep3 = new Deportista(28, 31, "Messi", "Fútbol");
			Lista.Add(Dep1);
			Lista.Add(Dep2);
			Lista.Add(Dep3);
			listaDeportistas.ItemsSource = Lista.Where(x => x.Deporte.Contains("F") && x.Edad > 20 && x.Puntuacion > 4);
		}
	}
}