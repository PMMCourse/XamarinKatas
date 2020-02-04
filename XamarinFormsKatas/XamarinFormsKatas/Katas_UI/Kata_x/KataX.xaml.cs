using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_x
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataX : ContentPage
	{
		List<string> listaNombres = new List<string>();
		public KataX ()
		{
			InitializeComponent ();
			listaNombres.Add("Fran");
			listaNombres.Add("Juan");
			listaNombres.Add("Fernando");
			Entry1.Focused += HacerVisible;
		}

		private void HacerVisible(Object sender, EventArgs e) {
			Picker1.ItemsSource = listaNombres;
			Picker1.IsVisible = true;
		}
	}
}