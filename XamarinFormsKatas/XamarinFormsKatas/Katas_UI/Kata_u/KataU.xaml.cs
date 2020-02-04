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

            var map = new Map(MapSpan.FromCenterAndRadius(new Position(37.393355, -5.983900), Distance.FromMiles(1)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var posicion1 = new Position(37.371861, -5.999654);
            var posicion2 = new Position(37.384217, -5.993467);

            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = posicion1,
                Label = "Fesac"
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = posicion2,
                Label ="Taco Bell"

            };
            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            Sl.Children.Add(map);

        }
	}
}