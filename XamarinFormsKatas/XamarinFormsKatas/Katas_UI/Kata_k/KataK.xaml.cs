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
        Random aleatorio = new Random();
        List<int> lista = new List<int>();
        public KataK ()
		{
			InitializeComponent ();
            LoadData();
            ListToPullRefresh.RefreshCommand = new Command(() => {
                ListToPullRefresh.IsRefreshing = true;
                LoadData();
            });
        }

        private void LoadData()
        {
            ListToPullRefresh.ItemsSource = null;
            lista.Clear();
            for (int i = 0; i < 8; i++)
            {
                lista.Add(aleatorio.Next());
            }
            ListToPullRefresh.ItemsSource = lista;
            ListToPullRefresh.IsRefreshing = false;
        }
    }
}