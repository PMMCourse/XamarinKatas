using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataM : ContentPage
	{
		public KataM ()
		{
			InitializeComponent ();

            BotonCrear.Clicked += CrearLabel;
		}

        private void CrearLabel(Object sender, EventArgs e)
        {
            Label etiqueta = new Label();

            etiqueta.WidthRequest = 300;
            etiqueta.HeightRequest = 60;
            etiqueta.Text = "Soy una etiqueta";

            StackPrincipal.Children.Add(etiqueta);
        }
	}
}