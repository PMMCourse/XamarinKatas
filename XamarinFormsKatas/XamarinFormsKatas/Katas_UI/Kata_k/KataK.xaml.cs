using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
		public List<string> MiLista;
		public KataK()
		{
			InitializeComponent();

			MiLista = new List<string>() { "ELEMENTO 1", "ELEMENTO 2", "ELEMENTO 3", "ELEMENTO 4"};

			listaK.ItemsSource = MiLista;

			listaK.Refreshing += ListaK_Refreshing;
		}

		private void ListaK_Refreshing(object sender, EventArgs e)
		{
			listaK.ItemsSource = null;
			listaK.ItemsSource = MiLista;
			listaK.IsRefreshing = false;
		}

		private void Borrar_Clicked(object sender, EventArgs e)
		{
			if (MiLista.Count>0)
			{
				MiLista.RemoveAt(MiLista.Count - 1);
			}
		}
	}
}