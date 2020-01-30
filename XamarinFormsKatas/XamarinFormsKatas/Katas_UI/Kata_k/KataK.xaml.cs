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
        Random numAlea= new Random();
        List<int> listaNumeros = new List<int>();

		public KataK ()
		{
			InitializeComponent ();
            LeerDatos();
            PullRefresh.RefreshCommand = new Command(() =>
             {
                 PullRefresh.IsRefreshing = true;
                 PullRefresh.IsRefreshing = true;
                 LeerDatos();
             });
		}

        private void LeerDatos()
        {
            PullRefresh.ItemsSource = null;
            listaNumeros.Clear();
            for (int i = 0; i < 9; i++)
            {
                listaNumeros.Add(numAlea.Next());
            }
            PullRefresh.ItemsSource = listaNumeros;
            PullRefresh.IsRefreshing = false;
        }
    }
}