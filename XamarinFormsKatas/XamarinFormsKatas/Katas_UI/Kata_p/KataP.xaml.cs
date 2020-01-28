using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
		public KataP ()
		{
			InitializeComponent ();
		}
        private async void activarIndicator(object sender, EventArgs e) {
                botonActivador.IsEnabled=false;
                indicator.IsEnabled = true;
                indicator.IsRunning = true;
                indicator.IsVisible = true;
                await Task.Delay(5000);
                indicator.IsEnabled = false;
                indicator.IsRunning = false;
                indicator.IsVisible = false;
                botonActivador.IsEnabled=true;
        }
	}
}