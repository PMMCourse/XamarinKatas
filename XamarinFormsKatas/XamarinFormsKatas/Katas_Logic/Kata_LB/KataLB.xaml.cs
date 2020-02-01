using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLB : ContentPage
	{
		public KataLB ()
		{
			InitializeComponent ();
            GetJSON();

        }
        
        public async void GetJSON()
        {
            // Check network status  
            if (NetworkCheck.IsInternet())
            {

                var client = new System.Net.Http.HttpClient();
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
                string UserJson = await response.Content.ReadAsStringAsync();
                List<Usuarios> UserList = new List<Usuarios>();
                if (UserJson != "")
                {
                    //Converting JSON Array Objects into generic list  
                    UserList = JsonConvert.DeserializeObject<List<Usuarios>>(UserJson);
                }
                //Binding listview with server response    
                Lista.ItemsSource = UserList;
            }
            else
            {
                await DisplayAlert("JSONParsing", "No network is available.", "Ok");
            }
        }
        
    }
}