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
        Deportista paco = new Deportista(10,"paco",21,"Futbol");
		public KataT ()
		{
			InitializeComponent ();
            puntuacionLabel.Text = paco.puntuacion.ToString();
            nombreLabel.Text = paco.nombre;
            edadLabel.Text = paco.edad.ToString();
            deporteLabel.Text = paco.deporte;
		}
	}
}