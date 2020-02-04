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

		private void AnimarRotacion(object sender, EventArgs e)
		{
			buttonRotation.TranslateTo(0, -10, 10);
			buttonRotation.RotateTo(10, 100);
			buttonRotation.TranslateTo(0, 0, 10);
		}
	}
}