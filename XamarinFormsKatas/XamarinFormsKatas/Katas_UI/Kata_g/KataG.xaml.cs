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
            botonRotar.Clicked += Rotacion;
		}

        public void Rotacion(Object sender, EventArgs e)
        {
            botonRotar.RotateTo(360, 2000);
            botonRotar.Rotation = 0;
        }
	}
}