using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_o
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataO : ContentPage
	{
		public KataO ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(MostrarAlerta);

            return true;
        }

        private async void MostrarAlerta()
        {
            var alerta = await this.DisplayAlert("Alerta", "Deseas salir?", "Si","No");

            if (alerta)
            {
                await this.Navigation.PopAsync();
            }
        }
    }
}