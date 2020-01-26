using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_g
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataG : ContentPage
	{
		public KataG ()
		{
			InitializeComponent ();
		}
        private async void animacion(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                await botonAnimate.TranslateTo(25, 0, 200);
                await botonAnimate.TranslateTo(-25, 0, 200);
            }
            botonAnimate.TranslationX = 0;
            await botonAnimate.RotateTo(360,400);
        }
    }
}