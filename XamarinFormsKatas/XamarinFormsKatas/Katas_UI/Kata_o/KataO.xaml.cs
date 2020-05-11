using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            this.Disappearing += OnBackButtonPressed;
        }
        private void OnBackButtonPressed(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var resultado = await this.DisplayAlert("ALERTA!", "¿Seguro que quieres salir?", "Salir", "Permanecer en esta pagina");
                if (resultado == true)
                {
                    //await this.Navigation.PopAsync();
                    Process.GetCurrentProcess().CloseMainWindow();
                }
                
            });
            
        }
    }
}
