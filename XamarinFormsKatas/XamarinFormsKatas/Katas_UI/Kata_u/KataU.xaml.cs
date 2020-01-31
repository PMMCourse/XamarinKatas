using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;


namespace XamarinFormsKatas.Katas_UI.Kata_u
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataU : ContentPage
	{
		public KataU ()
		{
			InitializeComponent ();

            CrearMapa();
		}

        private void CrearMapa()
        {
            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(37.393355, -5.983900), Distance.FromMiles(1)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var fesac = new Pin
            {
                Type = PinType.Place,
                Position = new Position(37.3716506, -6.0018991),
                Label = "Fesac"
            };

            var sevilla = new Pin
            {
                Type = PinType.Place,
                Position = new Position(37.3716876, -6.01722),
                Label = "Campo Sevilla"
            };

            mapa.Pins.Add(fesac);
            mapa.Pins.Add(sevilla);

            ContenedorMapa.Children.Add(mapa);
        }
	}
}