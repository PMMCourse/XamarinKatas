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
        List<string> listaPalabras = new List<string>();

		public KataK ()
		{
			InitializeComponent ();

            CargarLista();
            ListaR.IsRefreshing = false;

            ListaR.RefreshCommand = new Command(() =>
            {
                ListaR.IsRefreshing = true;

                CargarLista();

                ListaR.ItemsSource = null;

                ListaR.ItemsSource = listaPalabras;

                ListaR.IsRefreshing = false;
            });
		}

        private void IniciarLista()
        {
            listaPalabras.Add("Palabra nueva 1");
            listaPalabras.Add("Palabra nueva 2");
            listaPalabras.Add("Palabra nueva 3");
        }

        private void CargarLista()
        {
            IniciarLista();
            ListaR.ItemsSource = listaPalabras;
        }
	}
}