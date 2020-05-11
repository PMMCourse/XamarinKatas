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
        List<string> lista = new List<string>();

        public KataK()
        {
            InitializeComponent();

            CargarLista();
            ListaK.IsRefreshing = false;

            ListaK.RefreshCommand = new Command(() =>
            {
                ListaK.IsRefreshing = true;

                CargarLista();

                ListaK.ItemsSource = null;
                ListaK.ItemsSource = lista;
                ListaK.IsRefreshing = false;
            });
        }

        private void crearLista()
        {
            lista.Add("DESLIZA");
            lista.Add("PARA");
            lista.Add("ABAJO");
            lista.Add("PARA");
            lista.Add("VER");
            lista.Add("MAGIA");
        }

        private void CargarLista()
        {
            crearLista();
            ListaK.ItemsSource = lista;
        }
    }
}
