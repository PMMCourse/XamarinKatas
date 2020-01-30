using Akavache;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLB : ContentPage
	{
        private IBlobCache localData;
        List<Articulos> lista = new List<Articulos>();
        Articulos objetito = new Articulos();
        
		public KataLB ()
		{
			InitializeComponent ();
            httpGet();
            /*initializeAkavache();
            insertarObjetos();
            getApi();*/
        }
        private async void httpGet() {
            var client = new HttpClient();
            var url = "https://jsonplaceholder.typicode.com/posts";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();
            List<Articulos> lista = JsonConvert.DeserializeObject<List<Articulos>>(resp);
            listaVista.ItemsSource = lista;
            //initializeAkavache();
        }
        private void initializeAkavache() {
            BlobCache.ApplicationName= "datosOfChema";
            BlobCache.EnsureInitialized();
            localData = BlobCache.LocalMachine;
        }
        private void insertarObjetos()
        {
            localData.InsertObject<List<Articulos>>("posts",new List<Articulos>(lista));
        }
        private async void getApi() {
            listaVista.ItemsSource = await localData.GetObject<List<Articulos>>("posts");
            /* localData.GetObject<List<Articulos>>("posts").Subscribe(posts=> {
                 listaVista.ItemsSource = posts;
            });*/
        }
	}
}