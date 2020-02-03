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
			Rotacion();
		}

		void Rotacion() {
			btnRotacion.Clicked += async (sender, e) => {
				await btnRotacion.RotateTo(360, 2000);
			};
		}
	}
}