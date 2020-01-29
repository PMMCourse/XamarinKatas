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
            botoncito.Clicked += ContadorMarcha;
		}

        private async void ContadorMarcha(Object sender, EventArgs e)
        {
            botoncito.IsEnabled = false;

            contador.IsVisible = true;
            contador.IsRunning = true;

            await Task.Delay(5000);

            contador.IsRunning = false;
            contador.IsVisible = false;

            botoncito.IsEnabled = true;
        }
    }
}