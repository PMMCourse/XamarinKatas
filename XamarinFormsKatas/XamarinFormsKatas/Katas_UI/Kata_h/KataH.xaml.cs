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
        private async void animacion(object sender,EventArgs e)
        {
            await botonAnimado.TranslateTo(0, -49, 195);
            await botonAnimado.RotateTo(360, 210);
            botonAnimado.TranslationY = 0;
            botonAnimado.Rotation = 0;
        }
	}
}