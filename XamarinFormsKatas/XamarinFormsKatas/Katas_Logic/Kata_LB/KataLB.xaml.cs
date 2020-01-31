using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLB : ContentPage
	{
        public ObservableCollection<Model> listaJson= new ObservableCollection<Model>();

		public KataLB ()
		{
			InitializeComponent ();
            BindingContext = this;

            LeerJson();
		}

        private void LeerJson()
        {
            string url = @"http://jsonplaceholder.typicode.com/posts";

            using(var cliente = new HttpClient())
            {
                var contenido = cliente.GetStringAsync(url);

                listaJson = JsonConvert.DeserializeObject<ObservableCollection<Model>>(contenido.Result);

                ListaJson.ItemsSource = listaJson;
            }
        }
    }
}


