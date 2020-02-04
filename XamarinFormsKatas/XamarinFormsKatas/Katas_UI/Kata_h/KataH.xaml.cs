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

		private void btAnimado_Clicked(object sender, EventArgs e)
		{
			btAnimado.TranslateTo(0, 200, 250, Easing.CubicInOut);
			btAnimado.RotateTo(360, 900, Easing.CubicInOut);
		}
	}
}