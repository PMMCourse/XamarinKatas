using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata_LI : ContentPage
	{
		public Kata_LI ()
		{
			InitializeComponent ();
			llamar.Clicked += hacerLlamada;
		}

		private void hacerLlamada(object sender, EventArgs e)
		{
			DependencyService.Get<Telefono>().hacerLlamada(numTelefono.Text.ToString());
		}
	}
}