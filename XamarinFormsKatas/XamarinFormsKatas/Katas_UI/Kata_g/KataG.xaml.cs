using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_g
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataG : ContentPage
	{
		public KataG()
		{
			InitializeComponent();
		}
		public void BotonKata_g(object sender, EventArgs args)
		{
			//si lo pongo con , da simplemente la media vuelta
			botonDinamico.RotateTo(180 , 360);
			//si lo pongo asi: botonDinamico.RotateTo(180 * 360); vuelve a su estado original despues de girar
		}
	}
}