using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_b
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataB : ContentPage
	{
		public KataB()
		{
			InitializeComponent ();
		}
		

		public void botonB(object sender, EventArgs args)
		{
			 DisplayAlert("Respuesta", "Soy un boton redondo", "pues vale");
		}

	}
}