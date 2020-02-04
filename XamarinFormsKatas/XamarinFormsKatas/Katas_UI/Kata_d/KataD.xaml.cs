using System;
using System.Collections.Generic;
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
		public KataD()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			Persona personas = new ListaElementos();
			listNames.ItemsSource = personas._listaP;
			listNames.ItemSelected += itemSelected;
		}
		private void itemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				var person = e.SelectedItem as Persona;
			}
		}
	}
}