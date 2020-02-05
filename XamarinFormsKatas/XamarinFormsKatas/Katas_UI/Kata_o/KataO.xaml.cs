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
            Device.BeginInvokeOnMainThread(async () =>
            {
                var resultado = await this.DisplayAlert("ALERTA!", "Seguro que quieres salir?","Acepto","cancelar");
                if (resultado) await this.Navigation.PopAsync();
            });
            return true;
        }
    }
}