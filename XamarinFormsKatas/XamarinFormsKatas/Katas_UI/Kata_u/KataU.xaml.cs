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
            var posicion1 = new Position(37.356316, -5.981843); 
            var posicion2 = new Position(37.371638, -5.999653);
            var pin = new Pin {
                Type = PinType.Place,
                Position = posicion1,
                Label="Campo Benito Villamarín"
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = posicion2,
                Label = "Fesac"
            };
            MapView.Pins.Add(pin);
        }
	}
}