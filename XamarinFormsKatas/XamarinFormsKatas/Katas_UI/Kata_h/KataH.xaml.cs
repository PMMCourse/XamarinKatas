using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataH : ContentPage
	{
		public KataH ()
		{
			InitializeComponent ();
		}
        private async void RotateChema(object sender, EventArgs e)
        {
            await ButChema.TranslateTo(0, -100, 250, Easing.CubicInOut);
            await ButChema.RotateTo(360, 2000, Easing.CubicInOut);
            ButChema.Rotation = 0;
        }
    }
}