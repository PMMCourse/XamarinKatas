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
	public partial class AnimarBoton : ContentPage
	{
		public AnimarBoton ()
		{
			InitializeComponent ();
            BotonAnimar2.Clicked += AnimarBotonnAsync;
		}

        private async void AnimarBotonnAsync(Object sender, EventArgs e)
        {
            await BotonAnimar2.TranslateTo(0, -100, 200);
            await BotonAnimar2.RotateTo(360, 2000);
            await BotonAnimar2.TranslateTo(0, 0, 200);
            BotonAnimar2.Rotation = 0;
            BotonAnimar2.TranslationX = 0;
        }
	}
}