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

        Random rnd = new Random();
        int[] num = {10, 20, 30, 40, 50, 60, 70 , 80 };


        List<int> number = new List<int>();
        public KataK()
        {
            InitializeComponent();
            Cargar();

            Numeros.RefreshCommand = new Command(() => {
                Numeros.IsRefreshing = true;
                Cargar();
            });
        }
        public void Cargar()
        {
            Numeros.ItemsSource = null;
            

            for(int i = 0; i < 8; i++) 
            {
                number.Add(num[rnd.Next(0, num.Length)]);
            }

            Numeros.ItemsSource = number;
            Numeros.IsRefreshing = false;
        }
    }
}